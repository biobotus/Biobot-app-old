using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


using Peak.Can.Basic;
using TPCANHandle = System.UInt16;
using BioBotApp.Utils;

namespace BioBotApp.Utils.Communication.pcan
{
    class PCANCom
    {
        public bool isBusy { get; set; }

        public EventHandler SerialBusyEvent;

        #region MEMBER

        /// <summary>
        /// Saves the handle of a PCAN hardware
        /// </summary>
        private static TPCANHandle m_PcanHandle;

        #endregion


        #region CONSTRUCTOR
        public PCANCom()
        {
            isBusy = false;
        }
        #endregion


        #region INSTANCE
        private static PCANCom instance;
        public static PCANCom Instance
        {
            get
            {
                if (instance == null)
                { 
                    instance = new PCANCom();
                }
                return instance;
            }
        }
        #endregion


        #region CAN CONNEXION / DECONNEXION
        public TPCANStatus connect(TPCANHandle handler, TPCANBaudrate baudrate, TPCANType type, UInt32 io, UInt16 interrupt)
        {
            TPCANStatus stsResult;
            m_PcanHandle = handler;

            // Connects a selected PCAN-Basic channel
            //
            stsResult = PCANBasic.Initialize(
                    m_PcanHandle,
                    baudrate,
                    type,
                    io,
                    interrupt);

            readCanTimer = new Timer(50);
            readCanTimer.Start();
            readCanTimer.Elapsed += OnTimedEvent;

            return stsResult;
        }


        public void disconnect()
        {
            // Releases a current connected PCAN-Basic channel
            PCANBasic.Uninitialize(m_PcanHandle);
        }

        #endregion


        #region SEND MESSAGE
        public TPCANStatus send(TPCANMsg CANMsg)
        {
            isBusy = true;
            //System.Threading.Thread.Sleep(1000);
            //while (InterOperationFlag.isSerialBusy != false)
            //{
            //    System.Threading.Thread.Sleep(100);
            //}
            //InterOperationFlag.isCanBusy = true;           

            CANMsg.LEN = 8;
            CANMsg.MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            Logger.Instance.logPacket(CANMsg.DATA, true, (int)CANMsg.ID);
            TPCANStatus temp = PCANBasic.Write(m_PcanHandle, ref CANMsg);
            

            //InterOperationFlag.isCanBusy = false;
            return temp;
        }
        #endregion


        #region READ CAN MESSAGE

        private Timer readCanTimer;
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            ReadMessage();
        }


        /// <summary>
        /// Function for reading PCAN-Basic messages
        /// </summary>
        private void ReadMessages()
        {
            TPCANStatus stsResult;

            // We read at least one time the queue looking for messages.
            // If a message is found, we look again trying to find more.
            // If the queue is empty or an error occurr, we get out from
            // the dowhile statement.
            //			
            do
            {
                stsResult = ReadMessage();
                if (stsResult == TPCANStatus.PCAN_ERROR_ILLOPERATION)
                    break;
            } while (!Convert.ToBoolean(stsResult & TPCANStatus.PCAN_ERROR_QRCVEMPTY));
        }


        /// <summary>
        /// Function for reading CAN messages on normal CAN devices
        /// </summary>
        /// <returns>A TPCANStatus error code</returns>
        private TPCANStatus ReadMessage()
        {
            TPCANMsg CANMsg;
            TPCANStatus stsResult;

            // We execute the "Read" function of the PCANBasic                
            stsResult = PCANBasic.Read(m_PcanHandle, out CANMsg);
            if (stsResult == TPCANStatus.PCAN_ERROR_OK)
            {
                postMessage(CANMsg);
                Logger.Instance.logPacket(CANMsg.DATA, false, (int)CANMsg.ID);
            }
               
            return stsResult;
        }

        #endregion


        #region OBSERVER PATTERN
        private void postMessage(TPCANMsg CANMsg)
        {
            OnMessageReceivedEvent(new PCANComEventArgs(CANMsg));
            isBusy = false;
        }

        protected virtual void OnMessageReceivedEvent(PCANComEventArgs e)
        {
            EventHandler<PCANComEventArgs> handler = OnMessageReceived;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public event EventHandler<PCANComEventArgs> OnMessageReceived;
        #endregion

    }

    #region OBSERVER PATTERN (EVENTARGS)
    public class PCANComEventArgs : EventArgs
    {
        public PCANComEventArgs(TPCANMsg CanMsg)
        {
            this.CanMsg = CanMsg;
        }

        public TPCANMsg CanMsg { get; private set; }
    }
    #endregion

}

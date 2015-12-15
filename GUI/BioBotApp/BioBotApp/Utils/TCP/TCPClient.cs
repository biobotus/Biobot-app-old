using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace BioBotApp.Utils.TCP
{
    class AsyncTcpClient
    {
        // State object for receiving data from remote device.
        public class StateObject
        {
            // Client socket.
            public Socket workSocket = null;
            // Size of receive buffer.
            public const int BufferSize = 256;
            // Receive buffer.
            public byte[] buffer = new byte[BufferSize];
            // Received data string.
            public StringBuilder sb = new StringBuilder();
        }

        private static Socket tcpClientSocket = null;
        private static AsyncTcpClient asyncTcpClient = null;

        // ManualResetEvent instances signal completion.
        private static ManualResetEvent connectDone =
            new ManualResetEvent(false);
        private static ManualResetEvent sendDone =
            new ManualResetEvent(false);
        private static ManualResetEvent receiveDone =
            new ManualResetEvent(false);

        // The response from the remote device.
        private static String response = String.Empty;

        // Event that contains AsyncResult from connected TCP socket
        public event EventHandler<TCPClientAsyncResultEventArgs> tcpClientAsyncResult;

        private AsyncTcpClient()
        {
            //Socket of type Tcp
            tcpClientSocket = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(SockExceptionHandler);
        }

        public void SockExceptionHandler(object o, UnhandledExceptionEventArgs args)
        {
            TCPClientAsyncResultEventArgs result = new TCPClientAsyncResultEventArgs("", tcpClientSocket.Connected);
            onTcpClientAsyncResultCallback(result);
        }

        /// <summary>
        /// getInstance of TcpClient (this is a singleton class)
        /// </summary>
        /// <returns>Unique TcpClient instance</returns>
        public static AsyncTcpClient getInstance()
        {
            if (asyncTcpClient == null)
            {
                asyncTcpClient = new AsyncTcpClient();
            }

            return asyncTcpClient;
        }

        public void connect(String Ip, UInt16 port)
        {
            // Connect to a remote device.

            // Establish the remote endpoint for the socket.
            // The name of the remote device is Ip.
            //Change to these 2 line for Dns resolve
            //IPHostEntry ipHostInfo = Dns.GetHostEntry(Ip);
            //IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPAddress ipAddress = IPAddress.Parse(Ip);
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

            // Create a TCP/IP socket.
            tcpClientSocket = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            // Connect to the remote endpoint.
            tcpClientSocket.BeginConnect(remoteEP,
                new AsyncCallback(connectCallback), tcpClientSocket);
            connectDone.WaitOne(6000);


            // Receive the response from the remote device.

            // receiveDone.WaitOne();

            // Write the response to the console.
            // Console.WriteLine("Response received : {0}", response);

            // Release the socket.
            //client.Shutdown(SocketShutdown.Both);
            // client.Close();


            receive(tcpClientSocket);
        }

        private static void connectCallback(IAsyncResult ar)
        {
            // Retrieve the socket from the state object.
            Socket client = (Socket)ar.AsyncState;

            // Complete the connection.
            client.EndConnect(ar);
            Console.WriteLine("Socket connected to {0}",
                client.RemoteEndPoint.ToString());
            connectDone.Set();

        }
        private void receive(Socket client)
        {

            // Create the state object.
            StateObject state = new StateObject();
            state.workSocket = client;
            // Begin receiving the data from the remote device.
            client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(receiveCallback), state);


        }

        private void receiveCallback(IAsyncResult ar)
        {
            // Retrieve the state object and the client socket 
            // from the asynchronous state object.
            StateObject state = (StateObject)ar.AsyncState;
            Socket client = state.workSocket;

            // Read data from the remote device.
            int bytesRead = client.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There might be more data, so store the data received so far.
                state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                TCPClientAsyncResultEventArgs result =
                    new TCPClientAsyncResultEventArgs(Encoding.ASCII.GetString(state.buffer, 0, bytesRead),
                        tcpClientSocket.Connected);
                onTcpClientAsyncResultCallback(result);

                Console.WriteLine(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                // Get the rest of the data.
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(receiveCallback), state);
            }
            else
            {
                // All the data has arrived; put it in response.
                if (state.sb.Length > 1)
                {
                    response = state.sb.ToString();
                }
                // Signal that all bytes have been received.
                receiveDone.Set();

            }


        }

        protected void onTcpClientAsyncResultCallback(TCPClientAsyncResultEventArgs e)
        {
            if (tcpClientAsyncResult != null)
            {
                tcpClientAsyncResult(this, e);
            }
        }

        public void send(String data)
        {
            if (tcpClientSocket.Connected)
            {
                send(tcpClientSocket, data);
            }
        }

        private static void send(Socket client, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);
            // Begin sending the data to the remote device.
            client.BeginSend(byteData, 0, byteData.Length, 0,
                    new AsyncCallback(sendCallback), client);

        }

        private static void sendCallback(IAsyncResult ar)
        {

            // Retrieve the socket from the state object.
            Socket client = (Socket)ar.AsyncState;
            // Complete sending the data to the remote device.
            int bytesSent = client.EndSend(ar);
            Console.WriteLine("Sent {0} bytes to server.", bytesSent);

            // Signal that all bytes have been sent.
            sendDone.Set();
        }
    }
}

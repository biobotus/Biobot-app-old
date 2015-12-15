using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.TCP
{
    /// <summary>
    /// EventArgs created for TCP socket async callback result.
    /// </summary>
    public class TCPClientAsyncResultEventArgs : EventArgs
    {
        /// <summary>
        /// String containing the resul callback. May be more data to be received
        /// </summary>
        public String AsyncResult { get; set; }

        /// <summary>
        /// The connection state of TcpSocket
        /// </summary>
        public Boolean isConnected { get; set; }

        /// <summary>
        /// TCPClient socket async callback in string format
        /// </summary>
        /// <param name="AsyncResult">The tcp client async result in String format</param>
        public TCPClientAsyncResultEventArgs(String AsyncResult, Boolean isConnected)
        {
            this.AsyncResult = AsyncResult;
            this.isConnected = isConnected;
        }
    }
}

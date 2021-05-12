using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Harmonics.Models.ServerProvider.StringProcessing;

namespace Harmonics.Models.ServerProvider
{
    /**
     * Class ServerProvider provides connection to server and sending messages
     *
     * @author maxicids
     */
    public class ServerProvider
    {
        private const string Ip = "127.0.0.1";
        private const int Port = 3345;
        private readonly Socket TcpSocket;
        private IPEndPoint tcpEndPoint;

        public ServerProvider()
        {
            tcpEndPoint = new IPEndPoint(IPAddress.Parse(Ip), Port);
            TcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            TcpSocket.Connect(tcpEndPoint);
            var ctThread = new Thread(Listen);
            ctThread.Start();
        }
        public void Listen()
        {
            // var buffer = new byte[256];
            // var answer = new StringBuilder();
            // do
            // {
            //     var size = TcpSocket.Receive(buffer);
            //     answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            // } while (TcpSocket.Available > 0);

            //return answer.ToString();
        }
        public string SendMessage(MessageType messageType, string message)
        {
            var data = MessageConverter.ConvertMessage(messageType, message);
            TcpSocket.Send(data);
            
            var buffer = new byte[256];
            var answer = new StringBuilder();
            do
            {
                var size = TcpSocket.Receive(buffer);
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            } while (TcpSocket.Available > 0);

            return answer.ToString();
            
        }
    }
}
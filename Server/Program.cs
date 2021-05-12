using System.Net;
using System.Net.Sockets;

namespace Server
{
    internal static class Program
    {
        private const string Ip = "127.0.0.1";
        private const int Port = 3345;
        
        public static void Main(string[] args)
        {
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(Ip), Port);
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpSocket.Bind(tcpEndPoint);
            tcpSocket.Listen(50);
            
            while (true)
            {
                var client = tcpSocket.Accept();         
                var monoServer = new MonoServer();
                monoServer.StartClient(client);
            }
            // ReSharper disable once FunctionNeverReturns
        }
    }
}
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    public class MonoServer
    {
        private Socket client;

        public void StartClient(Socket clientSocket)
        {
            client = clientSocket;
            var ctThread = new Thread(DoProcessing);
            ctThread.Start();
        }

        private void DoProcessing()
        {
            var buffer = new byte[256];
            var data = new StringBuilder();
            
            do
            {
                var size = client.Receive(buffer);
                data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                var words = data.ToString().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                switch (words[0])
                {
                    case "10":
                        DbProvider.RegistrationQuery(words[1], words[2]);
                        break;
                    case "11":
                        
                    case "12":
                        
                    default:
                        throw new NotImplementedException();
                }
            } while (client.Available > 0);

            client.Send(buffer);
            client.Shutdown(SocketShutdown.Both);
            client.Close();
        }
    }
}
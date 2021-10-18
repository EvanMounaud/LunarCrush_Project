using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace LunarCrush_Project
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
  
            var Socket = new ClientWebSocket();
            Uri ServerUri = new Uri("wss://stream.lunarcrush.com/v2");
            string Token = "Key";

            try
            {
                Socket.ConnectAsync(ServerUri, CancellationToken.None);
                string requette ="?data=assets?";
                string fulllink = ServerUri + requette;
                ArraySegment<byte> bytesToSend = new ArraySegment<byte>;
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

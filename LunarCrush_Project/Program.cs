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
            ListBuilder listBuilder = new ListBuilder();
            listBuilder.Build();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            


        }
    }   
}

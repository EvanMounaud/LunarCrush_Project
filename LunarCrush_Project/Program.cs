using System;
using System.Windows.Forms;

namespace LunarCrush_Project
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ListBuilder listBuilder = new ListBuilder();
            listBuilder.Build("&limit=100");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(listBuilder));
            


        }
    }   
}

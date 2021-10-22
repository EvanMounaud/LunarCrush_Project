using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunarCrush_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void RefreshAsssets_Onclick(object sender, EventArgs e)
        {
            {
                string TargetEndpoint = "https://api.lunarcrush.com/v2?data=assets";
                string symbol = comboBox1.Text;
                string symbolRoute = "&symbol="+symbol;
                textBox1.Text = Convert.ToString(ConnexionClass.Connexion(TargetEndpoint, symbol:symbolRoute));
                Trace.WriteLine(ConnexionClass.Connexion(TargetEndpoint));
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

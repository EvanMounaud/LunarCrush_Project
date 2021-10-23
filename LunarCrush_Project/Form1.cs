using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LunarCrush_Project
{
    public partial class Form1 : Form
    {
        public ListBuilder listBuilder;
        public Form1(ListBuilder listBuilder)
        {
            InitializeComponent();
            foreach (var coin in listBuilder.Cryptos)
            {
                this.comboBox1.Items.Add(coin.Symbol);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string symbol = comboBox1.Text;
            listBuilder = new ListBuilder();
            listBuilder.Build("&limit=100");

            foreach (var coin in listBuilder.Cryptos)
            { if (coin.Symbol == symbol){
                    NameLabel.Text = coin.Name;
                    SymbolLabel.Text = coin.Symbol;
                    BTCLabel.Text = coin.PriceBTC.ToString();
                    USDLabel.Text = coin.PriceUSD.ToString();
                    GalaxyLabel.Text = coin.GScore.ToString();
                    MarketLabel.Text = coin.MarketCap.ToString();
                    AltLabel.Text = coin.AltRank.ToString();
                }
            }
            
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
                string symbol = comboBox1.Text;
                listBuilder = new ListBuilder();
                listBuilder.Build("&limit=100");
                foreach (var coin in listBuilder.Cryptos)
                {
                    if (coin.Symbol == symbol)
                    {
                        NameLabel.Text = coin.Name;
                        SymbolLabel.Text = coin.Symbol;
                        BTCLabel.Text = coin.PriceBTC.ToString();
                        USDLabel.Text = coin.PriceUSD.ToString();
                        GalaxyLabel.Text = coin.GScore.ToString();
                        MarketLabel.Text = coin.MarketCap.ToString();
                        AltLabel.Text = coin.AltRank.ToString();
                    }
                }

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

        private void RefreshMarket_Onclick(object sender, EventArgs e)
        {
            textBox2.Text = CoinOfTheDay.GetCoinOfTheDay();
            textBox3.Text = Exchange.MostExchanged();
            string symbol = comboBox1.Text;
            listBuilder = new ListBuilder();
            listBuilder.Build("&limit=10&sort=mc");
            foreach (var coin in listBuilder.Cryptos)
            {
                    ListViewItem item = new ListViewItem(coin.MarketCap.ToString());
                    item.SubItems.Add(coin.Symbol);
                    item.SubItems.Add(coin.Name);
                    item.SubItems.Add(coin.PriceBTC);
                    item.SubItems.Add(coin.PriceUSD.ToString());
                    item.SubItems.Add(coin.GScore.ToString());
                    listView1.Items.Add(item);
                    Trace.WriteLine(item);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

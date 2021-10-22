using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunarCrush_Project
{
    class Crypto
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public double PriceBTC { get; set; }
        public double PriceUSD { get; set; }
        public int AltRank { get; set; }
        public double GScore { get; set; }
        public double MarketCap { get; set; }
    
        public Crypto(string symbol,string name, double priceBTC, double priceUSD, int altRank, double gscore, double marketCap)
        {
            this.Symbol = symbol;
            this.Name = name;
            this.PriceBTC = priceBTC;
            this.PriceUSD = priceUSD;
            this.AltRank = altRank;
            this.GScore = gscore;
            this.MarketCap = marketCap;
        }
    
    }
}

namespace LunarCrush_Project
{
    public class Crypto
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string PriceBTC { get; set; }
        public double PriceUSD { get; set; }
        public int AltRank { get; set; }
        public double GScore { get; set; }
        public double MarketCap { get; set; }
    
        public Crypto(string symbol,string name, string priceBTC, double priceUSD, int altRank, double gscore, double marketCap)
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

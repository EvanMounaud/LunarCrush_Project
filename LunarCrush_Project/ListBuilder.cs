using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LunarCrush_Project
{
    public class ListBuilder
    {
        public List<Crypto> Cryptos = new List<Crypto>();
        public void Build([Optional] string option)
        {
            if (option == null){
                option = "10";
            }
            Cryptos.Clear();
            var json = ConnexionClass.Connexion("https://api.lunarcrush.com/v2?data=market", options: option);
            foreach(var data in json["data"])
            {
                string symbol;
                if (data["s"] == null){
                    symbol = "unknow";
                }
                else
                {
                    symbol = (string)data["s"];
                }
                string name;
                if (data["n"] == null)
                {
                    name = "unknow";
                }
                else
                {
                    name = (string)data["n"];
                }
                string priceBTC;
                if (data["p_btc"]==null)
                {
                    priceBTC = "0";
                }
                else
                {
                    priceBTC = (string)data["p_btc"];
                }
                double priceUSD;
                if (data["p"] == null)
                {
                    priceUSD = 0;
                }
                else
                {
                    priceUSD = (double)data["p"];
                }
                int altRank;
                if (data["acr"] == null)
                {
                    altRank = 0;
                }
                else
                {
                    altRank = (int)data["acr"];
                }
                double gScore;
                if (data["gs"] == null)
                {
                    gScore = 0;
                }
                else
                {
                    gScore = (double)data["gs"];
                }
                double marketCap;
                if (data["mc"] == null)
                {
                    marketCap = 0;
                }
                else
                {
                    marketCap = (double)data["mc"];
                }

                Crypto crypto = new Crypto(symbol, name, priceBTC, priceUSD, altRank, gScore, marketCap);
                Cryptos.Add(crypto);
            }
           


        }
    }
}
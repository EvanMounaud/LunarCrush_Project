using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunarCrush_Project
{
    class ListBuilder
    {
        public List<Crypto> Cryptos = new List<Crypto>();
        public void Build()
        {

            var json = ConnexionClass.Connexion("https://api.lunarcrush.com/v2?data=market", options: "&limit=10&sort=acr");
            Trace.WriteLine(json);
            foreach(var data in json["data"])
            {
                string symbol = (string)data["s"];
                string name = (string)data["n"];
                double priceBTC = (double)data["p_btc"];
                double priceUSD = (double)data["p"];
                int altRank = (int)data["acr"];
                double gScore = (double)data["gs"];
                double marketCap = (double)data["mc"];

                Crypto crypto = new Crypto(symbol, name, priceBTC, priceUSD, altRank, gScore, marketCap);
                Cryptos.Add(crypto);
            }
            
            Trace.WriteLine(Cryptos.ToString());


        }
    }
}
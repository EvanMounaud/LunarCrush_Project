using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunarCrush_Project
{
    public class CoinOfTheDay
    {
        public static string GetCoinOfTheDay()
        {
            var CoDRoute = "https://api.lunarcrush.com/v2?data=coinoftheday";
            var json = ConnexionClass.Connexion(CoDRoute);
            var coin = json["data"]["name"];
            var symbol = json["data"]["symbol"];
            return ("The coin of the day is " + coin + " which has " + symbol + " as a symbol");

        }
    }
}

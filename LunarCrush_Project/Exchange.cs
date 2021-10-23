namespace LunarCrush_Project
{
    public class Exchange
    {
        public static string MostExchanged()
        {
            var ExchangeRoute = "https://api.lunarcrush.com/v2?data=exchanges";
            int limit = 10;
            var options = "&limit=" + limit.ToString() + "&order_by=1d_trades";
            var json = ConnexionClass.Connexion(ExchangeRoute, options: options);

            var Text = "Today " + (string)json["data"]["global"]["1d_volume"] + " $ has been traded on cryptocurrencies market and here are the top 10 of exchange :";

            foreach (var exchange in json["data"]["exchanges"])
            {
                Text += "\r\n The " + (string)exchange["name"] + " coin with a total exchange of " + (string)exchange["1d_volume"] + "$ on the last 24hours";
            }
            return Text;
        }
    }
}

using System.Net;

namespace CurrencyConverter
{
    class WebScapper
    {
        // Creates a string of latest exchange rates to EUR via fixer.io
        public static string ReturnWebRateData()
        {
            var json = new WebClient().DownloadString("http://data.fixer.io/api/latest?access_key=0dbbc6b1ed7d7b57392d9c3e5ce269c9&format=1");
            return json;
        }
    }
}
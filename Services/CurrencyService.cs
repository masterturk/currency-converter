using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace CurrencyConverter
{
    public class CurrencyService
    {
        // Root Object for JSON Parse
        public class RootObject
        {
            public string code { get; set; }
            public string number { get; set; }
            public string name { get; set; }
        }

        // Creates a string of latest exchange rates to EUR via fixer.io
        public static string ReturnWebRateData()
        {
            var json = new WebClient().DownloadString("http://data.fixer.io/api/latest?access_key=0dbbc6b1ed7d7b57392d9c3e5ce269c9&format=1");
            return json;
        }

        // Creates a Dictionary of all Supported Currencies
        public static Dictionary<string, Currency> GetCurrencies()
        {
            Dictionary<string, Currency> _currencies = new Dictionary<string, Currency>();
            string path = "Currency.json";
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                dynamic currencyParse = JsonConvert.DeserializeObject<List<RootObject>>(json);
                foreach (var item in currencyParse)
                {
                    _currencies.Add(item.code, new Currency(item.code, Int32.Parse(item.number), item.name));
                }
                return _currencies;
            }
        }

        // Parses a string of latest exchange rates to EUR via fixer.io
        public static double ParseData(Currency Currency)
        {
            try
            {
                double amount = 0.0;
                //Scrapes Web Data to get the rates.
                string jsonOriginal = ReturnWebRateData();
                //Removes the headers
                string[] splitInformation = jsonOriginal.Split('{', '}');
                //Our current Data can then be split into "Name : Rate"
                string[] rows = splitInformation[2].Split(',');
                foreach (var row in rows)
                {
                    //Gets rid of spaces and new line characters
                    string line = row.Trim();
                    //Gets the currency code name
                    string name = line.Substring(1, 3);
                    if (name == Currency.CurrencyCode)
                    {
                        //and extracts the amount
                        amount = Convert.ToDouble(line.Substring(6));
                        return amount;
                    }
                }
            }
            catch
            {
                return 0;
            }
            return 0;
        }

        // Converts one currency to another via the Euro exchange rate from fixer.io
        public static double ConvertCurrency(double currencyValue1, double currencyValue2)
        {
            double convertedCurrency = (1 / currencyValue1) * currencyValue2;
            return convertedCurrency;
        }

        // Returns Exchage Rate
        public static double ExchangeRate(Currency currency1, Currency currency2)
        {
                // Gets up-to-date rates
                double firstRate = ParseData(currency1);
                double secondRate = ParseData(currency2);
                if (firstRate == 0 || secondRate == 0) return 0;
                //Calculation 
                double exchange = ConvertCurrency(firstRate, secondRate);
                return exchange;
        }
    }
}

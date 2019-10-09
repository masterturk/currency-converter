using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
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

        // Creates an Array of all Supported Currencies
        public static List<Currency> GetCurrencyList()
        {
            List<Currency> currencyList = new List<Currency>();
            string path = "Currency.json";
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                dynamic currencyParse = JsonConvert.DeserializeObject<List<RootObject>>(json);
                foreach (var item in currencyParse)
                {
                    currencyList.Add(new Currency(item.code, Int32.Parse(item.number), item.name));
                }
                return currencyList;
            }
        }

        // Prints out Currency Names and Codes
        public static void PrintList()
        {
            List<Currency> currencyList = GetCurrencyList();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|               Currency Name              | Currency Code |");
            Console.WriteLine("------------------------------------------------------------");

            foreach (Currency currency in currencyList)
            {
                int nameLength = currency.CurrencyName.Length;
                string moneyName = currency.CurrencyName;
                int codeLength = currency.CurrencyCode.Length;
                string moneyCode = currency.CurrencyCode;
                if (nameLength <= 39)
                {
                    for (int j = 0; j <= 39 - nameLength; j++)
                    {
                        moneyName = moneyName + " ";
                    }
                    moneyCode = "     " + moneyCode + "     ";
                }
                else
                {
                    moneyCode = "     " + moneyCode + "     ";
                }
                Console.WriteLine($"| {moneyName} | {moneyCode} |");
                Console.WriteLine("------------------------------------------------------------");
            }
        }

        // Validates an entered code is a legitimate code
        public static bool ValidCurrencyCode(string code)
        {
            bool valid = false;
            List<Currency> currencyList = GetCurrencyList();
            for (int i = 0; i < 164; i++)
            {
                if (currencyList[i].CurrencyCode == code)
                {
                    valid = true;
                    return valid;
                }
            }
            return valid;
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
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Something went wrong.");
                return 0;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Something went wrong.");
                return 0;
            }
            Console.WriteLine("Something went wrong.");
            return 0;
        }

        // Converts one currency to another via the Euro exchange rate from fixer.io
        public static double ConvertCurrency(double currencyValue1, double currencyValue2)
        {
            double convertedCurrency = (1 / currencyValue1) * currencyValue2;
            return convertedCurrency;
        }

        // Default Currency Not Found Error
        private static string CurrencyNotFound()
        {
            return "The currency you requested could not be found at this time. \nThe code has been entered incorrectly or there is a problem with our API." +
            "\nYou will now be returned to the main menu.";
        }

        // Interfaces with Console to grab user entered codes
        public static string UserCodeInput()
        {
            string input = Console.ReadLine();
            input = input.ToUpper();
            if (ValidCurrencyCode(input) == false)
            {
                Console.WriteLine(CurrencyNotFound());
                return "-1";
            }
            return input;
        }

        // Interfaces with Console to grab user entered codes
        public static string UserYesNoInput()
        {
            Console.Write("Enter the code you will be exchanging from: ");
            string input = Console.ReadLine();
            input = input.ToUpper();
            if (ValidCurrencyCode(input) == false)
            {
                Console.WriteLine(CurrencyNotFound());
                return "-1";
            }
            return input;
        }

        // Leverages other functions to output the exchage rate
        public static void ExchangeProcess()
        {
            try
            {
                // Creates List of Currency Object
                List<Currency> myList = GetCurrencyList();
                // Grabs input & validates bad data
                Console.Write("Enter the code you will be exchanging from: ");
                string first = UserCodeInput();
                if (first == "-1")
                {
                    return;
                }
                Console.Write("Enter the code you will be exchanging to: ");
                string second = UserCodeInput();
                if (second == "-1")
                {
                    return;
                }
                // Finds Currency objects matching user input
                double firstRate = ParseData(myList.Find(x => (x.CurrencyCode == first)));
                double secondRate = ParseData(myList.Find(x => (x.CurrencyCode == second)));
                //Get the name of the currency
                var firstMoneyName = myList.Find(y => (y.CurrencyCode == first));
                var secondMoneyName = myList.Find(y => (y.CurrencyCode == second));
                //Calculation 
                double exchange = ConvertCurrency(firstRate, secondRate);
                exchange = Math.Round(exchange, 2);
                //Print result
                Console.WriteLine($"The {firstMoneyName.CurrencyCode} to {secondMoneyName.CurrencyCode} exchange rate is: 1 {firstMoneyName.CurrencyName} to {exchange} {secondMoneyName.CurrencyName}s");
                Console.Write("Would you like to convert a specific amount? (y/n): ");
                string response = Console.ReadLine().ToLower();
                if (response == "y" || response == "yes")
                {
                    Console.Write($"Please enter an amount you would like to convert (from {firstMoneyName.CurrencyCode} to {secondMoneyName.CurrencyCode}): ");
                    string input = Console.ReadLine();
                    double x = Double.Parse(input);
                    if (x == 0)
                    {
                        Console.WriteLine("Response is not valid.");
                        Console.WriteLine("Press Enter to return to the menu.");
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        exchange = exchange * x;
                        exchange = Math.Round(exchange, 2);
                        Console.WriteLine($"{x} {firstMoneyName.CurrencyName}s is worth {exchange} {secondMoneyName.CurrencyName}s");
                        Console.WriteLine("Press Enter to return to the menu.");
                        Console.ReadLine();
                        return;
                    }
                }
                else if (response == "n" || response == "no")
                {
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                    return;
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine(CurrencyNotFound());
                return;
            }
            catch (System.Exception)
            {
                Console.WriteLine(CurrencyNotFound());
                return;
            }
        }
    }
}

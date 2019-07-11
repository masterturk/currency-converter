using System;
// using ExchangeRate;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Currency Objects
            Currency USD = new Currency("USD", "United States Dollar");
            Currency EUR = new Currency("EUR", "Euro");

            // Console.Write("Please Enter a USD Amount: ");
            // string input = Console.ReadLine();
            // double value = Convert.ToDouble(input);
            // // double exchangeRate = ExchangeRate.Provider.Google.Rate("GBP", "EUR");
            // double exchangedValue = exchangeRate * value;
            // Console.WriteLine($"That Amount is equal to {exchangedValue} EUR");
        }
    }
}
// ExchangeRate.Provider.Google.Rate("GBP", "EUR");
// ExchangeRate.Provider.Google.Convert(Iso4217.GBP, Iso4217.EUR, 500);
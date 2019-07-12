using System;
using System.Collections;
using System.Collections.Generic;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Currency> myList = Currency.ISO4217();
            //Console.WriteLine(WebScapper.ReturnWebRateData());
            // Console.WriteLine(myList[0].CurrencyCode);
            Currency USD = new Currency("USD", 840, "United States dollar");
            double rate = Currency.parseData(USD);
            Console.WriteLine(rate);
			
        }
    }
}

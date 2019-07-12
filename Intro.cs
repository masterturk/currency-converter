using System;
namespace CurrencyConverter
{
    class Intro
    {
        public static void Welcome()
        {
        Console.WriteLine("+-----------------------------------+");
        Console.WriteLine("Welcome to the Currency Exchange App!");
        Console.WriteLine("+-----------------------------------+");
        }

        public static void Menu() {
            Console.WriteLine("+-----------------------------------+");
            Console.WriteLine("1.) Exchange");
            Console.WriteLine("2.) Help");
            Console.WriteLine("3.) Exit");
            Console.WriteLine("+-----------------------------------+");
        }

        public static void Help() {
            Console.WriteLine("All Currencies have a 3 digit code, such as the\n"+
            "United States Dollar is USD and the Euro is EUR. At the main menu, type the code\n" +
            "of your desired currency and then the currency you would like to see the exchange rate of\n");
            Console.WriteLine("Codes can be found at https://www.countries-ofthe-world.com/world-currencies.html");
            Console.WriteLine("Press Enter to go Back");
            Console.ReadLine();
        }
    }   
}
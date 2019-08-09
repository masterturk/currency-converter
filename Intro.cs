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
            Console.WriteLine("2.) List");
            Console.WriteLine("3.) Help");
            Console.WriteLine("4.) Exit");
            Console.WriteLine("+-----------------------------------+");
        }

        public static void List() {
            Currency.PrintList();
            Console.WriteLine("Press Enter to go Back");
            Console.ReadLine();
        }

        public static void Help() {
            Console.WriteLine("All currencies have a 3 digit code, select the 'List' option to view the currenies and codes\n"+
            "provided by our API. To use the converter, select the 'Exchange' option, then type the code\n" +
            "of your desired currency and the currency you would like to see the exchange rate of when prompted.\n");
            Console.WriteLine("More information on codes can be found at https://www.countries-ofthe-world.com/world-currencies.html");
            Console.WriteLine("Press Enter to go Back");
            Console.ReadLine();
        }
    }   
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(WebScapper.ReturnWebRateData());
            //Console.WriteLine(myList[0].CurrencyCode);
            Currency USD = new Currency("USD", 840, "United States dollar");
            bool quit = false;
            string choice;
            do{
                Intro.Welcome();
                Intro.Menu();
                Console.Write("\nWhat would you like to do? ");
                choice = Console.ReadLine();

                switch(choice) {
                    case "1":
                        Currency.exchangeProcess();
                        break;

                    case "2":
                        Intro.Help();
                        break;

                    case "3":
                        quit = true;
                        break;
                    
                    default:
                        Console.WriteLine("Not a valid command.");
                        break;
                    }
                
                Console.Clear();
                    
                } while (quit == false);

                Console.WriteLine("Goodbye!");
                Console.ReadLine();
                Environment.Exit(1);

			
        }
    }
}

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
            bool quit = false;
            string choice;
            do{
                Intro.Welcome();
                Intro.Menu();
                Console.Write("\nWhat would you like to do? ");
                choice = Console.ReadLine();

                switch(choice) {
                    case "1":
                        Currency.ExchangeProcess();
                        break;

                    case "2":
                        Intro.List();
                        break;

                    case "3":
                        Intro.Help();
                        break;

                    case "4":
                        quit = true;
                        break;
                    
                    default:
                        Console.WriteLine("Not a valid command.");
                        break;
                    }
                
                Console.WriteLine("+-----------------------------------+");
                // Console.Clear();
                    
                } while (quit == false);

                Console.WriteLine("Goodbye!");
                Console.ReadLine();
                Environment.Exit(1);

			
        }
    }
}

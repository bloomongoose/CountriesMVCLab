using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesMVCLab
{
    class CountryController
    {
        public List<Country> CountryDB { get; set; }

        public CountryController()
        {
            CountryDB = new List<Country>
            {
                new Country("USA", "North America", new List<string>{"Red", "White", "Blue"}),
                new Country("South Korea", "Asia", new List<string>{"White", "Red", "Blue"}),
                new Country("Scotland", "Europe", new List<string>{"White", "Blue"}),
                new Country("Japan", "North America", new List<string>{"Red", "White"}),
            };
        }

        public void WelcomeAction()
        {
            Console.WriteLine("Welcome. Select a country from the following list.");
        }
        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void CountryListAction()
        {
            CountryListView view = new CountryListView(CountryDB);

            bool runProgram = true;

            while (runProgram)
            {
                view.Display();
                int choice = GetCountryChoice();

                Country result = CountryDB[choice];
                CountryAction(result);

                runProgram = GetContinue();
            }
        }

        public bool GetContinue()
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine("Would you like information on another country? y/n");
                string choice = Console.ReadLine().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if(choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }


            return result;
        }

        public int GetCountryChoice()
        {
            int choice = 0;
            while (true)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if(choice < 0)
                    {
                        Console.WriteLine("Too low. Try again.");
                    }
                    else if(choice >= CountryDB.Count)
                    {
                        Console.WriteLine("Too high. Try again.");
                    }
                    else
                    {
                        //good choice
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That wasn't a number. Try again.");
                }
            }

            return choice;
        }
    }
}

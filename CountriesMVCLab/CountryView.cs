using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesMVCLab
{
    class CountryView
    {
        //properties
        public Country DisplayCountry { get; set; }

        //constructor
        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }

        //methods
        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name} {DisplayCountry.Continent} Colors: ");
            foreach(string color in DisplayCountry.Colors)
            {

                Console.ForegroundColor = Enum.Parse<ConsoleColor>(color.Trim());
                if(color == "Black")
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine($"{color} ");
                Console.ResetColor();
            }
        }
    }
}

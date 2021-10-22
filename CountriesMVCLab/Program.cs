using System;
using System.Collections.Generic;

namespace CountriesMVCLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //TESTING ZONE

            //List<Country> countries = new List<Country>
            //{
            //    new Country("abra", "kadabra", new List<string> { "Red", "Magenta" }),
            //    new Country("abra", "kadabra", new List<string> { "Red", "Magenta" }),
            //    new Country("abra", "kadabra", new List<string> { "Red", "Magenta" })
            //};

            //CountryView countryView = new CountryListView(countries)
            //countryView.Display();

            CountryController controller = new CountryController();

            controller.WelcomeAction();
            controller.CountryListAction();
        }
    }
}

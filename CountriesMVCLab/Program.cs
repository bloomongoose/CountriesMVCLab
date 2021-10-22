using System;
using System.Collections.Generic;

namespace CountriesMVCLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //TESTING ZONE

            CountryView countryView = new CountryView(new Country("abra", "kadabra", new List<string> { "Red", "Magenta" }));
            countryView.Display();
        }
    }
}

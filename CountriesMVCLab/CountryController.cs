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
    }
}

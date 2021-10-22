using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesMVCLab
{
    class Country
    {
        //properties
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }

        //constructor
        public Country(string name, string continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }
    }
}

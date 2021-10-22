using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesMVCLab
{
    class CountryListView
    {
        //properties
        public List<Country> Countries { get; set; }

        //constructor 
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }
        //methods
        public void Display()
        {
            int i = 1;
            Countries.ForEach(c => Console.WriteLine($"{i++} {c.Name}"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Country_MVC
{
    class CountryListView
    {   //properties
        public List<Country> Countries { get; set; }

        //Constuctor
        public CountryListView(List<Country> countryList)
        {
            Countries = countryList;

        }

        //Methods

        public void Display()
        {
            for(int i = 0; i < Countries.Count; i++)
            {   //Don't forget to do i to get the index on it's own.
                Console.WriteLine($"{i+1}, {Countries[i].Name}");



            }

        }

    }
}

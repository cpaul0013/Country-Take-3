using System;
using System.Collections.Generic;
using System.Text;

namespace Country_MVC
{
    class CountryView
    {   //Don't forget getters and setters for all properties
        public Country DisplayCountry { get; set; }
        public CountryView(Country country)
        {
            DisplayCountry = country; 


        }

        public void Display()
        {
           Console.ForegroundColor = Enum.Parse<ConsoleColor>(DisplayCountry.Colors[0]);  
            Console.BackgroundColor = Enum.Parse<ConsoleColor>(DisplayCountry.Colors[1]);
            //rey putting these on the same line with string interp
            Console.WriteLine(DisplayCountry.Name);
            Console.WriteLine(DisplayCountry.Cont);
            foreach(string color in DisplayCountry.Colors)
            {   //Use write not write line to keep all of these on the same line
                Console.Write(color);

            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;


        }


    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace Country_MVC
{
    class Program
    {
        static void Main(string[] args)
        {   //The list could have been made inside of the country controller class
            List<Country> countryList = new List<Country>()
            { new Country("Japan","Asia",new List<string>{"Red","White" }),
              new Country("Canada","North America",new List<string>{"Red","White" }),
              new Country("United Kingdom","Europe",new List<string>{"Red","Blue", "White" }),
              new Country("USA","North America",new List<string>{"Red","Blue", "White" }),
              new Country("Spain","Europe",new List<string>{"Red","Yellow"}),

            };

            // first make an instance in order to call the main method for the program
            CountryController myFirstCOntroller = new CountryController(countryList);
            myFirstCOntroller.CountryListAction();



        }
        public void FileIO()
        {

            // First create a file path. Do not leave it to the default. It will be ignored on the git ignore
            // ..\..\..\ followed bt Name.txt
            string filePath = @"..\..\..\Countries.txt";
            if(File.Exists(filePath) == false)
            {
                List<Country> defaultList = new List<Country>
                { new Country("Japan", "Asia", new List<string> { "Red", "White" }),
               new Country("Canada", "North America", new List<string> { "Red", "White" }),
              new Country("United Kingdom", "Europe", new List<string> { "Red", "Blue", "White" }),
              new Country("USA", "North America", new List<string> { "Red", "Blue", "White" }),
              new Country("Spain", "Europe", new List<string> { "Red", "Yellow" }) };
                
                Console.WriteLine("The file does not exist creating now");
                //be sure to include the file path inside of the parameters
                StreamWriter writer = new StreamWriter(filePath);
                foreach(Country c in defaultList)
                {
                    string colors = "";
                    foreach(string color in c.Colors)
                    {
                        colors += $"{color},";

                    }
                    //Gran entire wor but leave off the last comma
                    colors = colors.Substring(0, colors.Length - 1);
                    //print to file, do not use c.color list, but the string you just created
                    writer.WriteLine($"{c.Name} {c.Cont}{colors}");
                }
                writer.Close();

            }

            //reading file
            StreamReader reader = new StreamReader(filePath);
            //read until you get a null value
            while (true)
            {

                string line = reader.ReadLine();
                if(line == null)
                {
                    //the file has ended
                    break;


                }
                else
                {
                    string[] values = line.Split(",");
                    string newName = values[0];
                    string newContinent = values[1];
                    List<string> newColors = new List<string>();
                    for(int i = 2; i < values.Length; i++)
                    {
                        newColors.Add(values[i]);


                    }
                    Country newCountry = new Country(newName, newContinent, newColors);
                    
                }



            }




        }
    }
}

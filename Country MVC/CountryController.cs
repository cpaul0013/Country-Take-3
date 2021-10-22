using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Country_MVC
{
    class CountryController
    {   //This is the database for the countries
        public List<Country> Countrydb;
        public CountryController(List<Country> countryList)
        {
            Countrydb = countryList;
            //Could have added the list here rather than in the main program
        }

        public void CountryAction(Country c)
        {

            CountryView selectedCountry = new CountryView(c);
            selectedCountry.Display();

        }


        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");

        }

        public void CountryListAction()
        {   //Welcome and Display Option
            CountryListView display = new CountryListView(Countrydb);
            WelcomeAction();
            bool runProgram = true;
            while (runProgram)
            {
                display.Display();

                //validate user input here
                bool validSelection = false;
                //starting value just so it has something, could also be a seperate method
                int userSelection = 0;
                while (!validSelection)
                {
                    try
                    {
                        userSelection = int.Parse(Console.ReadLine().ToLower());
                        if (userSelection > 0 && userSelection <= Countrydb.Count)
                        {
                            validSelection = true;

                        }
                        else if(userSelection <= 0 || userSelection > Countrydb.Count)
                        {
                            Console.WriteLine("That was not a valid input");

                        }

                    }
                    catch
                    {
                        Console.WriteLine("That was not a valid input.");

                    }


                }

                CountryAction(Countrydb[userSelection -1]);
               runProgram = GetContinue("Would you like to view another country? Y / N");

            }
        }

        
        public static bool GetContinue(string custom)
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine(custom);
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y")
                {
                    result = true;
                    Console.Clear();
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("That wasn't a valid option. Try again.");
                }
            }

            return result;
        }

    }

    //public void FileIO()
    //{

    //    // First create a file path. Do not leave it to the default. It will be ignored on the git ignore
    //    // ..\..\..\ followed bt Name.txt
    //    string filePath = @"..\..\..\Countries.txt";
    //    if (File.Exists(filePath) == false)
    //    {
    //        List<Country> defaultList = new List<Country>
    //            { new Country("Japan", "Asia", new List<string> { "Red", "White" }),
    //           new Country("Canada", "North America", new List<string> { "Red", "White" }),
    //          new Country("United Kingdom", "Europe", new List<string> { "Red", "Blue", "White" }),
    //          new Country("USA", "North America", new List<string> { "Red", "Blue", "White" }),
    //          new Country("Spain", "Europe", new List<string> { "Red", "Yellow" }) };

    //        Console.WriteLine("The file does not exist creating now");
    //        //be sure to include the file path inside of the parameters
    //        StreamWriter writer = new StreamWriter(filePath);
    //        foreach (Country c in defaultList)
    //        {
    //            string colors = "";
    //            foreach (string color in c.Colors)
    //            {
    //                colors += $"{color},";

    //            }
    //            //Gran entire wor but leave off the last comma
    //            colors = colors.Substring(0, colors.Length - 1);
    //            //print to file, do not use c.color list, but the string you just created
    //            writer.WriteLine($"{c.Name} {c.Cont}{colors}");
    //        }
    //        writer.Close();

    //    }

    //    //reading file
    //    StreamReader reader = new StreamReader(filePath);
    //    //read until you get a null value
    //    while (true)
    //    {

    //        string line = reader.ReadLine();
    //        if (line == null)
    //        {
    //            //the file has ended
    //            break;


    //        }
    //        else
    //        {
    //            string[] values = line.Split(",");
    //            string newName = values[0];
    //            string newContinent = values[1];
    //            List<string> newColors = new List<string>();
    //            for (int i = 2; i < values.Length; i++)
    //            {
    //                newColors.Add(values[i]);


    //            }
    //            Country newCountry = new Country(newName, newContinent, newColors);
               

    //        }



        }




    

using System;
using System.Collections.Generic;
using System.Text;

namespace Country_MVC
{
    class Country
    { public string Name { get; set; }
      public string Cont { get; set; }
        //Don't forget to add get set to Lists as well
     public List<string> Colors { get; set; }

    public Country(string name, string cont, List<string> colors)
        {
            Name = name;
            Cont = cont;
            Colors = colors;




        }

      
    }
}

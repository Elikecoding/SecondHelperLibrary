using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ModelClasses
{
    public class Animal
    {
        //This is the animal class which contains the properties and attributes for my animals
        public string Type { get; set; }

        public decimal Weight { get; set; }

        public int TopSpeed { get; set; }

        public string Colour { get; set; }

        public string Noise { get; set; }

        public string Diet { get; set; }

    }
}

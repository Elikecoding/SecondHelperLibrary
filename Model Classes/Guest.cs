using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ModelClasses
{
    //Use this as an example, every class should have there own file and the file name should match the class name 
     public class Guest : Person
    {
        public bool HasRegistered { get; set; }
    }
}

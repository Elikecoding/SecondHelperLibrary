using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ModelClasses
{
    //This class will represent an instance of your person 
    public class Person
    {
        //This is the proper way to create public variables DO NOT USE public variables
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsGoldCustomer { get; set; }
    }
}

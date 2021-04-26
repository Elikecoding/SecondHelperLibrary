using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.LogicClasses
{
    public class ErrorLogger
    {
        //Create a string property for my error
        public string lastError { get; set; }

        //Event handler for my errors 
        public event EventHandler<Guid> ErrorLogged;

        public void Log(string error)
        {
            if (String.IsNullOrWhiteSpace(error))
            {
                //If my string is null tell me
                throw new ArgumentNullException();
            }
            else
            {
                //Store my error in a log 
                lastError = error;
                ErrorLogged?.Invoke(this, Guid.NewGuid());
            }
        }

    }
}

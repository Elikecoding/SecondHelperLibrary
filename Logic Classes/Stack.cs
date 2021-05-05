using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.LogicClasses
{
    //Stack helper method
    public class Stack<mS>
    {
        //Create my list
        private readonly List<mS> myList = new List<mS>();

        //Count the number of objects
        public int Count => myList.Count;

        //Add objects
        public void Push(mS obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
            myList.Add(obj);
        }

        //Remove objects
        public mS Pop()
        {
            if (myList.Count == 0)
            {
                throw new InvalidOperationException();
            }
            var result = myList[myList.Count - 1];
            myList.RemoveAt(myList.Count - 1);

            return result;
        }

        //Peek into Stack
        public mS Peek()
        {
            if (myList.Count == 0)
            {
                throw new InvalidOperationException();
            }

            return myList[myList.Count - 1];
        }

    }
}

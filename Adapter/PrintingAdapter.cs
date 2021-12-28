using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class PrintingAdapter
    {
        public void IntStringAdapt()
        { 
            PrintingInts printInt = new();
            ReturningStrings returnString = new();

            var value = Convert.ToInt32(returnString.ReturnString());
            printInt.Print(value);
        }

    }
}

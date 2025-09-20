using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    // Define a generic class named Employee with a type parameter T (which can be any data type).
    public class Employee<T>
    {
        /* Property to hold a list of items of type T.
         "Things" will change its data type depending on what T is.*/
        public List<T> Things { get; set; }
    }



}


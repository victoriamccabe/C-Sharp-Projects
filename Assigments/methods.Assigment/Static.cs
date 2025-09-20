using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A static class cannot be instantiated. All its members must also be static.
public static class Static
{
    // A static method that multiplies a number by 5 and returns it
    public static int MultiplyByTwo(int number)
    {
        return number * 5;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_and_Decrement_Examples
{
    class Program
    {
        static void Main()
        {
            // ++ increments by 1.
            // -- decrements by 1.
            // Great for loops and counting.
            int x = 0;
            int y = 0;
            Console.WriteLine(x++); // Outputs 0; x is now 1.
            Console.WriteLine(++y); // Outputs 1; y is now 1.
            Console.WriteLine(--x); // Outputs 0; x is now 0.
            Console.WriteLine(y--); // Outputs 1; y is now 0.
        }
    }
}

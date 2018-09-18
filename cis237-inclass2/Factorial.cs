using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass2
{
    class Factorial
    {
        public int SolveFactorial(int number)
        {
            // This is the base case
            // If the number is one, just return it.
            if (number == 1)
            {
                return 1;
            }
            // Not the base case, so make a recursive call
            // to ourself
            return number * SolveFactorial(number - 1);
        }
    }
}

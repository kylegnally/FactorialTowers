using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass2
{
    class TowerOfHanoi
    {
        public void SolveHanoi()
        {
            Console.WriteLine("Enter the number of discs to use.");
            Console.WriteLine("Less than 5 is good");

            string input = Console.ReadLine();
            int discNumber = Int32.Parse(input);

            // Inital call to start the recursion
            Solve(discNumber, 'A', 'B', 'C');
        }

        private void Solve(int numberOfDiscs, char src, char temp, char dest)
        {
            // If this is true, we hit the base case.
            // All printing is done in the base case.
            if (numberOfDiscs == 1)
            {
                Console.WriteLine("Move disc from tower {0} to tower {1}", src, dest);
            }
            else
            {
                // Make a recursive call to move n-1 discs from the source peg, to the
                // temp peg
                Solve(numberOfDiscs - 1, src, dest, temp);
                // Make the recursive call to move the 1 (bottom) disc from the src
                // to the destination
                Solve(1, src, temp, dest);
                // Make the recursive call to move n-1 discs from the temp peg, to the
                // destination peg
                Solve(numberOfDiscs - 1, temp, src, dest);
            }
        }
    }
}

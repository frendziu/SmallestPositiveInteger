using System;
using System.Linq;

namespace SmallestPositiveInteger
{
    class Program
    {

        static int solution(int[] A)
        {

            var smallestInt = 1;

            if ((A == null) || (A.Length == 0)) { return smallestInt; }

            A = A.OrderBy(x => x).ToArray();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 0)
                    continue;
                else if (A[i] == smallestInt)
                {
                    smallestInt++;
                }
            }

            return smallestInt;
        }

        static void Main(string[] args)
        {
            

            int[] tabA = new int[] { 1, 3, 6, 4, 1, 2 };
            int[] tabB = new int[] {1 , 2 , 3};
            int[] tabC = new int[] { };
            int[] tabD = new int[] { -1, -3 };
            int[] tabE = new int[] { 4 };

            Console.WriteLine("Tab A: " + solution(tabA));
            Console.WriteLine("Tab B: " + solution(tabB));
            Console.WriteLine("Tab C: " + solution(tabC));
            Console.WriteLine("Tab D: " + solution(tabD));
            Console.WriteLine("Tab E: " + solution(tabE));
        }
    }
}

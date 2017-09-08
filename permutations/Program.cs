using System;
using System.Threading;

namespace permutations
{
    class Program
    {
        static void calcPerm(int steps, int nFactorial, int divisor) {
            if (steps == 2)
            {
                Console.WriteLine(nFactorial);
                Console.WriteLine(divisor);
                Console.WriteLine(nFactorial / divisor);
            }
        }  
        static void Main(string[] args)
        {
            // A code has 4 digits in a specific order, the digits are between 0-9. How many different permutations are there if one digit may only be used once?
            //use permutation formula p(n,r) = n! / (n-r)!
            int n = 10; //number of different digits to choose from. (0-9)
            int r = 4; //4 digit lock combo
            int nFactorial = 1;
            int divisor = 1;
            int steps = 0; //if this == 2 then both threads are complete.

            Thread tAlpha = new Thread(() =>
            {
                for (int i = n; i > 0; i--) // Thread Alpha
                {
                    nFactorial *= i;
                }
                steps++;
                calcPerm(steps, nFactorial, divisor);
            });
            tAlpha.Start();

            for (int j = n-r; j > 0; j--)// Thread Bravo
            {
                divisor *= j;
            }
            steps++;
            calcPerm(steps, nFactorial, divisor);
            Thread.Sleep(8000);


        }
    }
}


using System;
using System.Collections.Generic;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise03
    {

        public String ShowMultiPrime(int n)
        {
            var stringPrime = new List<int>();
            var i = 2;

            if(n <= i)
            {
                throw new Exception("Input wrong");
            }

            do
            {
                if (n % i == 0)
                {
                    stringPrime.Add(i);
                    n /= i;
                }
                else
                {
                    i++;
                }
            } while (i <= n);

            return string.Join(" * ",stringPrime);
        }
    }
}

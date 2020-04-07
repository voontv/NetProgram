
using System;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise03
    {

        public String ShowMultiPrime(int n)
        {

            String stringPrime = null;
            var i = 2;

            if(n <= i)
            {
                return n.ToString();
            }

            do
            {
                if (n % i == 0)
                {
                    if (stringPrime != null)
                    {
                        stringPrime += " * " + i;
                    }
                    else
                    {
                        stringPrime += i;
                    }
                    n /= i;
                }
                else
                {
                    i++;
                }
            } while (i <= n);

            return stringPrime;
        }
    }
}

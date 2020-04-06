
using System;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise03
    {

        public bool IsPrime(int n)
        {

            if(n < 2)
            {
                return false;
            }

            for(int i=2; i < n / i; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

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

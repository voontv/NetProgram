
using System;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise03
    {

        public bool isPrime(int n)
        {

            if(n < 2)
            {
                return false;
            }

            for(int i=2; i < n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        public String showMultiPrime(int n)
        {

            String stringPrime = null;
            var i = 2;

            if(n <= i)
            {
                return n.ToString();
            }

            do
            {
                if (n % i == 0 && isPrime(i))
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise17
    {

        public bool IsPrime(int n)
        {

            if(n < 2)
            {
                return false;
            }

            for(int i = 2; i < n/i; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsSymmetric(int n)
        {
            var number = n;
            var sum = 0;

            while(number > 0)
            {
                sum = sum * 10 + number % 10;
                number /= 10;
            }

            return n == sum;
        }

        public int FindNumbers(int n)
        {
            var m = n;

            while( m>= n)
            {
                if(IsPrime(m) && IsSymmetric(m))
                {
                    break;
                }
                else
                {
                    m++;
                }
            }
            return m;
        }
    }
}

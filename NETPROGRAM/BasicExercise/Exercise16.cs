using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise16
    {

        public bool IsPrime(int n)
        {

            if(n < 2)
            {
                return false;
            }

            for(int i = 2; i <= n / 2; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public List<int> RangesPrime(int n,int minInRange = 0)
        {

            return Enumerable.Range(2, n - 1).Where(x => IsPrime(x) && x > minInRange).ToList(); ;
        }

        public int FindNumber()
        {
            var n = 2 * 3 * 5;
            var minRange = 7;
            var isCorrect = true;

            do
            {

                foreach (int i in RangesPrime(n, minRange))
                {
                    if(n % i == 0)
                    {
                        isCorrect = false;
                        minRange = n;
                        n += 2 * 3 * 5;
                        break;
                    }
                }
            } while (!isCorrect);

            return n;
        }
    }
}

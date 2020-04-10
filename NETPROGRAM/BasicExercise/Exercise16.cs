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

        public bool FindNumber(int number)
        {
            var minRange = 7;

            if(number % (2 * 3 * 5) != 0)
            {
                return false;
            }

            foreach (int i in RangesPrime(number, minRange))
            {
                if(number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

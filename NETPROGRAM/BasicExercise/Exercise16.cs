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

            for(var i = 2; i <= n / i; i++)
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

            return Enumerable.Range(minInRange + 1, n - minInRange + 1).Where(x => IsPrime(x)).ToList(); ;
        }

        public bool CheckNumber(int number)
        {
            var minRange = 5;

            if(number % (3 * 5) != 0)
            {
                return false;
            }

            foreach (var i in RangesPrime(number, minRange))
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

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

        public List<int> RangesPrime(int n)
        {

            return Enumerable.Range(1, n + 1).Where(x => IsPrime(x)).ToList(); ;
        }

        public bool CheckNumber(int number)
        {
            if(number < 2)
            {
                return false;
            }

            foreach (var i in RangesPrime(number))
            {
                if(number % i == 0 && i > 5)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

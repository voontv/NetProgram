using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise18
    {

        public int SumSquareNumber(int n)
        {
            var sum = 0;

            while (n > 0)
            {
                sum += (n % 10) * (n % 10);
                n /= 10;
            }           

            return sum;
        }

        public bool IsHappy(int number)
        {
            do
            {
                number = SumSquareNumber(number);

                if(number == 1)
                {
                    return true;
                }
            
            } while (number > 9);

            return false;
        }
    }
}

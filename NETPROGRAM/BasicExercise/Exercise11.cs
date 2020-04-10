
using System.Collections.Generic;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise11
    {

        public int BinaryNumberReverse(int n)
        {
            
            if(n == 0)
            {
                return 0;
            }

            var number = 0;
            var i = 1;

            while (n > 0)
            {
               
                number = (number << 1) | (n & 1);
                n >>= 1;

            }

            return number;
        }
    }
}

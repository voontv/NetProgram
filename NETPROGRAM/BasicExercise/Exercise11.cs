
using System.Collections.Generic;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise11
    {

        public int LengthBinaryNumber(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            var length = 0;

            while (n > 0)
            {
                length += 1;
                n /= 2;
            }

            return length;
        }

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

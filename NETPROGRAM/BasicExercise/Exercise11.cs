
using System.Collections.Generic;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise11
    {

        public int BinaryNumberReverse(int n)
        {
            var number = 0;
            var listNumber = new List<int>();

            if(n == 0)
            {
                return 0;
            }

            while(n > 0)
            {
                listNumber.Add(n % 2);
                n /= 2;
            }

            for(int i = 0; i<listNumber.Count; i++)
            {
                number += listNumber[i] * (int) System.Math.Pow(2, listNumber.Count - i - 1);
            }

            return number;
        }
    }
}

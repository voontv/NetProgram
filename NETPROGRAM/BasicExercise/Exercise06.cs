
using System;
using System.Linq;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise06
    {

        public int SumWithN(int n)
        {
            if (n < 1)
            {
                throw new Exception("Wrong input");
            }

            return Enumerable.Range(0, n+1).Aggregate((sum, i) => sum + i * (i + 1));
        }
    }
}


using System;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise06
    {

        public int SumWithN(int n)
        {
            if(n < 1)
            {
                throw new Exception("Wrong input");
            }

            var sum = 0;
            
            for(int i =1; i<=n; i++)
            {
                sum += i * (i + 1);
            }

            return sum;
        }
    }
}

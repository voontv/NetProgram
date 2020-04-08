using System;
using System.Collections.Generic;
using System.Linq;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise05
    {

        public int PowInt(int m, int n)
        {
            if(n == 0)
            {
                return 1;
            }

            var pow = 1;

            for(int i = 1; i<= n; i++)
            {
                pow *= m;
            }

            return pow;
        }
   
        public bool IsValid(int n)
        {
            int length = n.ToString().Length;
            int result = 0;
            int number = n;

            do
            {

                result += PowInt(number % 10, length);
                number /= 10;

            } while (number > 0);


            return (result == n);
        }

        public List<int> FindNumbers(int n)
        {

            return Enumerable.Range(100, n-100).Where(s => IsValid(s)).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise05
    {

        public int PowInt(int number, int index)
        {
            if(index == 0)
            {
                return 1;
            }

            var pow = 1;

            for(int i = 1; i<= index; i++)
            {
                pow *= number;
            }

            return pow;
        }
   
        public bool CheckNumberRequest(int n)
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

        public List<int> ShowListNumber(int n)
        {

            return Enumerable.Range(100, n-100).Where(s => CheckNumberRequest(s)).ToList();
        }
    }
}

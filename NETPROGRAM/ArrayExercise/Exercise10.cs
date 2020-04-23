using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class Exercise10
    {

        public bool IsSquareNumber(int n)
        {

            for(var i = 1; i * i <= n; i++)
            {
                if(i * i > n)
                {
                    return false;
                }

                if(i * i == n)
                {
                    return true;
                }
            }

            return false;
        }

        public int SumSquare(int[] array)
        {

            return array.Where(IsSquareNumber).Sum();
        }
    }
}

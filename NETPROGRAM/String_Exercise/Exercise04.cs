using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.String_Exercise
{
    public class Exercise04
    {

        public int PowInt(int n,int m)
        {
            var mul = 1;
                      
            for(var i = 1; i <= m; i++)
            {
                mul *= n;
            }

            return mul;
        }

        public int SumIntInString(string s)
        {
            var sum = 0;
            var lengInt = 0;

            foreach(var ch in s.ToCharArray().Reverse())
            {
                if (Char.IsDigit(ch))
                {
                    sum += int.Parse(ch.ToString()) * PowInt(10, lengInt);
                    lengInt++;
                }
                else
                {
                    lengInt = 0;
                }
            }

            return sum;
        }
    }
}

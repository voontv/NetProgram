using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NETPROGRAM.String_Exercise
{
    public class Exercise04
    {

        public int PowInt(int n, int m)
        {
            var mul = 1;

            for (var i = 1; i <= m; i++)
            {
                mul *= n;
            }

            return mul;
        }

        public int SumIntInString(string s)
        {
            var sum = 0;
            var count = 0;
            s += " ";

            for (var i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    for (var j = i + 1; j < s.Length; j++)
                    {
                        if (!Char.IsDigit(s[j]))
                        {
                            count = j - i;
                            break;
                        }
                    }

                    sum += int.Parse(s.Substring(i, count));
                    i += count;
                    count = 0;
                }
            }

            return sum;
        }

        public int SumIntRegex(string s)
        {
            var sum = 0;

            foreach (var index in Regex.Split(s, @"[\D]"))
            {
                if (!index.Equals(""))
                {
                    sum += int.Parse(index);
                }
            }

            return sum;
        }
    }
}

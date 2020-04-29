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

            foreach (var index in Regex.Split(s, @"\D+").Skip(1))
            {
                sum += int.Parse(index);
            }

            return sum;
        }
    }
}

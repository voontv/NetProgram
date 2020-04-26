using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NETPROGRAM.String_Exercise
{
    public class Exercise06
    {

        public string OptimizeString(string s)
        {
            var stringBuilder = new StringBuilder();
            s += " ";

            for (var i = 0; i < s.Length - 1; i++)
            {
                for (var j = i + 1; j < s.Length; j++)
                {
                    if (s[j] != s[i])
                    {
                        if (j - i > 1)
                        {
                            stringBuilder.Append(s[i].ToString() + (j - i).ToString());
                        }
                        else
                        {
                            stringBuilder.Append(s[i].ToString());
                        }

                        i = j;
                    }
                }
            }

            return stringBuilder.ToString();
        }
    }
}

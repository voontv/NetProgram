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

                if (s[s.Length - 1] != s[s.Length - 2])
                {
                    stringBuilder.Append(s.Last());
                }
            }

            return stringBuilder.ToString();
        }

        public string OptimizeStringRegex(string s)
        {
            var stringBuilder = new StringBuilder(s);

            for (var i = 0; i < s.Length; i++)
            {
                var count = Regex.Replace(s, s[i] + "*", "").Length - s.Length;

                stringBuilder.Append((count > 1) ? (s[i] + count) : s[i]);
                i += count - 1;
            }

            return stringBuilder.ToString();
        }
    }
}

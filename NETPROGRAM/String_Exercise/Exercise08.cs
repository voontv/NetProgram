using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NETPROGRAM.String_Exercise
{
    public class Exercise08
    {

        public string RemoveCharRedundancy(string s)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(s[0]);

            foreach (var ch in s.Skip(1))
            {
                if (stringBuilder[stringBuilder.Length - 1] != ch)
                {
                    stringBuilder.Append(ch);
                }
            }

            return stringBuilder.ToString();
        }
    }
}

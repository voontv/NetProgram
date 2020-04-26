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

            for (var i = 1; i < s.Length; i++)
            {
                if (stringBuilder.ToString().Last() != s[i])
                {
                    stringBuilder.Append(s[i]);
                }
            }

            return stringBuilder.ToString();
        }
    }
}

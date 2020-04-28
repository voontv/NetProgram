using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.String_Exercise
{
    public class Exercise01
    {

        public string SnakeCase(string s)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(s[0]);

            foreach (var ch in s.Substring(1))
            {
                if (Char.IsUpper(ch))
                {
                    stringBuilder.Append('_');
                }

                stringBuilder.Append(ch);
            }

            return stringBuilder.ToString().ToLower();
        }
    }
}

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

            for(var i = 0 ; i < s.Length; i++)
            {

                if (i > 0 && Char.IsUpper(s[i]))
                {
                    stringBuilder.Append("_"+s[i].ToString());
                }
                else
                {
                    stringBuilder.Append(s[i]);
                }
            }

            return stringBuilder.ToString().ToLower();           
        }
    }
}

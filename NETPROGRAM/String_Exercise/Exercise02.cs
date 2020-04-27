using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.String_Exercise
{
    public class Exercise02
    {

        public string UpperCase(string s)
        {
            StringBuilder upperString = new StringBuilder();

            foreach (var subString in s.Split('_'))
            {
                upperString.Append(char.ToUpper(subString[0]));
                upperString.Append(subString.Substring(1));
            }

            return upperString.ToString();
        }
    }
}

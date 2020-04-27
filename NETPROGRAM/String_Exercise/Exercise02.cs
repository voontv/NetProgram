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
            string result = "";

            foreach (var sub in s.Split('_'))
            {
                result = string.Concat(result, Char.ToUpper(sub[0]), sub.Substring(1));
            }

            return result;
        }
    }
}

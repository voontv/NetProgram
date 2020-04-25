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

            foreach(var subString in s.Split('_'))
            {
                upperString.Append(subString.First().ToString().ToUpper() + subString.Remove(0,1));
            }

            return upperString.ToString();
        }
    }
}

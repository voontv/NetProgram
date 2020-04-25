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
        
            for(var i = s.Length - 1 ; i > 0 ; i--)
            {

                if (Char.IsUpper(s[i]))
                {
                    s = s.Insert(i, "_");
                }
            }

            return s.ToLower();           
        }
    }
}

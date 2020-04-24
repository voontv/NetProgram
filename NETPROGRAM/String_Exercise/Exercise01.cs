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
            var snakeString = s.ToLower();
            for(var i = s.Length - 2 ; i > 0 ; i--)
            {

                if (s.ToLower()[i] - s[i] > 0)
                {
                    snakeString = snakeString.Insert(i, "_");
                }
            }

            return snakeString;
            
        }
    }
}

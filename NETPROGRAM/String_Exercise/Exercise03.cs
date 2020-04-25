using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.String_Exercise
{
    public class Exercise03
    {

        public string ReverseString(string s)
        {

            return new string(s.Reverse().ToArray());
        }     
    }
}

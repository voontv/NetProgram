using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.String_Exercise
{
    public class Exercise05
    {

        public bool IsSymmetry(String s)
        {
            bool isSymmetry = true;

            for(var i =0; i < s.Length/2; i++)
            {

                if(s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }

            return isSymmetry;
        }
    }
}

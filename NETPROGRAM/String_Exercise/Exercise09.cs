using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NETPROGRAM.String_Exercise
{
    public class Exercise09
    {

        public bool IsBarcodeEAN13(string s)
        {
            var sum = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += int.Parse(s[i].ToString());
                }
                else
                {
                    sum += 3 * int.Parse(s[i].ToString());
                }

            }
            return sum % 10 == 0;
        }
    }
}

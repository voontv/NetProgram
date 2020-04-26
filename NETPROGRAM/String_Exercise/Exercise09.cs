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

            return (from index in Enumerable.Range(0, s.Length)
                    group int.Parse(s[index].ToString()) by index % 2)
                    .Sum(x => (x.Key == 0) ? x.ToArray().Sum() : (3 * x.ToArray().Sum())) % 10 == 0;
        }
    }
}

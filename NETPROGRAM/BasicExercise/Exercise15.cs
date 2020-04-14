using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise15
    {


        public int CountFactorial(int n)
        {
            
            return (int)Math.Ceiling(Enumerable.Range(1, n).Sum(x =>Math.Log10(x)));
        }
    }
}

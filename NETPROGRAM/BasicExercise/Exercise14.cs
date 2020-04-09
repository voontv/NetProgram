using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise14
    {
        
        public int CountNumberZero(int n)
        {

            return Enumerable.Range(0, n+1).Aggregate((a, b) => {
                
                return a += (b % 10 == 0) ? (b.ToString().Length - 1) : ((b % 5 == 0) ? 1 : 0);
            });
        }
    }
}

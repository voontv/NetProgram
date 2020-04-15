using System;
using System.Collections.Generic;
using System.Linq;


namespace NETPROGRAM.ArrayExercise
{
    public class Exercise01
    {

        public List<int> CorrectNumbers(int[] array)
        {
            
            return (from i in (from n in array  
                               group n
                               by n)
                   where (i.Count() >= 2)
                   select i.Key).ToList();
        }
    }
}

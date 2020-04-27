using System;
using System.Collections.Generic;
using System.Linq;


namespace NETPROGRAM.ArrayExercise
{
    public class Exercise01
    {

        public List<int> CorrectNumbers(int[] array)
        {
            
            return (from n in array  
                               group n
                               by n into gr
                               where (gr.Count() >= 3)
                               select gr.Key).ToList();
        }
    }
}

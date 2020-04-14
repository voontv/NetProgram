using System;
using System.Collections.Generic;
using System.Linq;


namespace NETPROGRAM.ArrayExercise
{
    public class Exercise01
    {

        public List<int> CorrectNumbers(int[] array)
        {
            var arrayOrder = (from n in array
                             orderby n
                             select n).ToArray();
            var listNumbers = new List<int>();
            var count = 1;
            var i = 0;

            do
            {
                if(arrayOrder[i] == arrayOrder[i+1])
                {
                    count++;    
                }
                else
                {
                    count = 1;
                }

                if(count == 2)
                {
                    listNumbers.Add(arrayOrder[i]);
                }

                i++;

            } while (i < arrayOrder.Length - 1);

            return listNumbers;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class Exercise05
    {

        public List<List<int>> ArrayUpMax(int[] array)
        {
            var indexDown = 0;
            var dictory = new Dictionary<int, int>();

            for (var i = 0; i < array.Length; i++)
            {
                
                if ((i != array.Length -1 && array[i] > array[i + 1]) || (i == array.Length -1 && array[i-1] <= array[i]))
                {

                    dictory.Add(indexDown, i + 1);
                    indexDown = i + 1;

                }
            }
            
            return (from index in dictory 
                    where (index.Value - index.Key) >= (from i in dictory select i.Value - i.Key).Max()
                    select (array.Skip(index.Key)).Take(index.Value).ToList()).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise04
    {

        public List<int> FiboInRangeN(int n)
        {
            if (n < 1)
            {
                throw new Exception("Can not find Fibo number same request");
            }

            var listNumber = new List<int>() { 1, 1};
            var i = 2;
            while (listNumber[i - 2] + listNumber[i - 1] <= n)
            {
                listNumber.Add(listNumber[i - 2] + listNumber[i - 1]);
                i++;
            }
         
            return listNumber.ToList();
        }
    }
}

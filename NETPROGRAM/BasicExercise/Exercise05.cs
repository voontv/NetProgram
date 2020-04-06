using System;
using System.Collections.Generic;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise05
    {
   
        public bool CheckNumberRequest(int n)
        {
            int length = n.ToString().Length;
            int result = 0;
            int number = n;

            do
            {

                result += (int) Math.Pow(number % 10, length);
                number /= 10;

            } while (number > 0);


            return (result == n);
        }

        public List<int> showListNumber(int n)
        {
            List<int> numberList = new List<int>();

            for(int i = 100; i <= n; i++)
            {
                if(CheckNumberRequest(i))
                {
                    numberList.Add(i);
                }
            }

            return numberList;
        }
    }
}

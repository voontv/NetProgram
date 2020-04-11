using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise15
    {

        public int CountZeroFactorial(int n)
        {
            var count = 0;

            for(int i= 1; i <= n; i++)
            {
                if(i % 10 == 0)
                {
                    for(int j = i.ToString().Length - 1; j >= 0; j--)
                    {
                        if(i % PowInt(10, j) == 0)
                        {
                            if(i % (5 * PowInt(10, j)) == 0)
                            {
                                count += j + 1;
                            }
                            else
                            {
                                count += j;
                            }
                            break;
                        }
                    }
                }
                else if(i % 5 == 0)
                {
                    if((i - 25) % 100 == 0)
                    {
                        count += 2;
                    }
                    else
                    {
                        count += 1;
                    }
                }
            }

            return count;
        }
        
        public long Factorial(int n)
        {

            return Enumerable.Range(1, n).Aggregate((a, b) => a * b);
        }

        public long PowInt(int m, int n)
        {
            if(n == 0)
            {
                return 1;
            }

            long multi = 1;
            
            for(int i = 0; i < n; i++)
            {
                multi *= m; 
            }

            return multi;
        }

        public int CountFactorial(int n)
        {
            long multiOptimize = 1;

            for(int i = 1; i<= n; i++)
            {
                multiOptimize *= i;
                if (i % 10 == 0)
                {
                    for (int j = i.ToString().Length - 1; j >= 0; j--)
                    {
                        if (i % PowInt(10, j) == 0)
                        {
                            if (i % (5 * PowInt(10, j)) == 0)
                            {
                                multiOptimize /= 5 * PowInt(10, j);
                            }
                            else
                            {
                                multiOptimize /= PowInt(10, j);
                            }
                            break;
                        }
                    }
                }
                else if (i % 5 == 0)
                {
                    if ((i - 25) % 100 == 0)
                    {
                        multiOptimize /= 100;
                    }
                    else
                    {
                        multiOptimize /= 10;
                    }
                }
            }

            return multiOptimize.ToString().Length + CountZeroFactorial(n);
        }
    }
}

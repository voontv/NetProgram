using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise13
    { 

        public bool CheckStringIp(params String[] stringIp)
        {

            foreach(String s in stringIp)
            {
                if (!int.TryParse(s, out int x) || !(x >= 0 && x <= 255))
                {
                    return false;
                }

            }            

            return true;
        }

        public bool FindRangeIP(string stringIp)
        {

            if(stringIp.Length < 4 || stringIp.Length > 12)
            {

                return false;
            }
            
            for(int i =0; i<3; i++)
            {
                
                if(stringIp.Substring(i+1).Length >= 3 && stringIp.Substring(i+1).Length <= 9)
                {
                    var stringA = stringIp.Substring(0, i + 1);         

                    for (int j = i + 1; j < i + 1 + 3 ; j++)
                    {

                        if (stringIp.Substring(j+1).Length >= 2 && stringIp.Substring(j+1).Length <= 6)
                        {
                            var stringB = stringIp.Substring(i + 1, j - i); 

                            for (int k = j + 1; k < j + 1 + 3; k++)
                            {

                                if (stringIp.Substring(k+1).Length >= 1 && stringIp.Substring(k+1).Length <= 3)
                                {
                                    var stringC = stringIp.Substring(j + 1, k - j);
                                    var stringD = stringIp.Substring(k + 1);

                                    if (CheckStringIp(stringA, stringB, stringC, stringD))
                                    {
                                        return true;         
                                    }
                                  
                                }
                            }
                        }             
                    }
                }            

            }

            return false;

        }
    }
}

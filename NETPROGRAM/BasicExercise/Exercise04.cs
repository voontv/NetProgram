namespace NETPROGRAM.BasicExercise
{
    public class Exercise04
    {

        public int FiboInPositionN(int n)
        {

            if (n <= 2 && n > 0)
                return 1;

            return FiboInPositionN(n - 1) + FiboInPositionN(n - 2);
        }

        public string showRangeFibo(int n)
        {
            string rangeFibo = null;

            if(n < 1)
            {
                return "Can not find Fibo number same request";
            }

            for(int i = 0; i<= n; i++)
            {
                if (FiboInPositionN(i+1) <= n)
                {

                    if (rangeFibo != null)
                    {
                        rangeFibo += " " + FiboInPositionN(i + 1);
                    }
                    else
                    {
                        rangeFibo += FiboInPositionN(i + 1);
                    }

                }
                else
                {
                    break;
                }
            }

            return rangeFibo;
        }
    }
}

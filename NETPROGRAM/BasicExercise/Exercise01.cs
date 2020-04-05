
namespace NETPROGRAM.BasicExercise
{
    public class Exercise01
    {

        public int UCLN(int a,int b)
        {
            if (a * b == 0) return a + b;

            while(a != b)
            {
                if(a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }                
            }

            return a;
        }

        public long BCNN(int a, int b)
        {
            if (a * b == 0) return 0;

            return a *b / UCLN(a, b);
        }
    }
}

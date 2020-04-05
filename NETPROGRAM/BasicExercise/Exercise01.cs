
namespace NETPROGRAM.BasicExercise
{
    public class Exercise01
    {

        public int UCLN(int a,int b)
        {
            if (a * b == 0) return a + b;

            var numA = (a > b) ? b : a;

            var numB = (a > b) ? a : b;

            while(numA != numB)
            {
                if(numA > numB)
                {
                    numA -= numB;
                }
                else
                {
                    numB -= numA;
                }                
            }

            return numA;
        }

        public long BCNN(int a, int b)
        {
            if (a * b == 0) return 0;

            return a *b / UCLN(a, b);
        }
    }
}

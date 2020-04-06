

namespace NETPROGRAM.BasicExercise
{
    public class Exercise07
    {

        public long Factorial(int n)
        {
            if(n < 1)
            {
                return 1;
            }
            var result = 1;

            for(int i =1; i <=n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}

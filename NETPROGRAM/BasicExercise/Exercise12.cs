
namespace NETPROGRAM.BasicExercise
{
    public class Exercise12
    {
  
        public bool SymmetryNumber(int n)
        {
            var sum = 0;
            var temp = n;

            while(n != 0)
            {
                sum =10 * sum + (n % 10);
                n /= 10;
            }

            return (sum == temp);
        }
    }
}

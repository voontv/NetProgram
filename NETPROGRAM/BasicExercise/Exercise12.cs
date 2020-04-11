
namespace NETPROGRAM.BasicExercise
{
    public class Exercise12
    {
  
        public bool SymmetryNumber(int n)
        {
            var sum = 0;
            sum =10 * sum + (n % 10);
            n /= 10;
        
            return (sum == 0);
        }
    }
}

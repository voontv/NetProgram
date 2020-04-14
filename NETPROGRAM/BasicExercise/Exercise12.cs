
namespace NETPROGRAM.BasicExercise
{
    public class Exercise12
    {
  
        public bool SymmetryNumber(int number)
        {
            var sum = 0;
            var n = number;

            while(n > 0)
            {
                sum = 10 * sum + (n % 10);
                n /= 10;
            }           
        
            return (sum == number);
        }
    }
}


namespace NETPROGRAM.BasicExercise
{
    public class Exercise12
    {
  
        public bool SymmetryNumber(int n)
        {
            var length = n.ToString().Length;
            var sum = 0;
            var i = 1;
            var temp = n;

            while(n != 0)
            {
                sum =10 * sum + (n % 10);
                n /= 10;
                i++;
            }

            return (sum == temp);
        }
    }
}

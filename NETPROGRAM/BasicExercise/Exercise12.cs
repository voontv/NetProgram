
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

            if(n == 0)
            {
                return true;
            }

            while(n != 0)
            {
                sum += (n % 10) * (int) System.Math.Pow(10, length - i);
                n /= 10;
                i++;
            }

            return (sum == temp);
        }
    }
}

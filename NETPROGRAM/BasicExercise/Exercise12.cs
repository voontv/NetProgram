
namespace NETPROGRAM.BasicExercise
{
    public class Exercise12
    {

        public int PowInt(int number, int index)
        {
            if (index == 0)
            {
                return 1;
            }

            var pow = 1;

            for (int i = 1; i <= index; i++)
            {
                pow *= number;
            }

            return pow;
        }

        public bool SymmetryNumber(int n)
        {
            var length = n.ToString().Length;
            var sum = 0;
            var i = 1;
            var temp = n;

            while(n != 0)
            {
                sum += (n % 10) * PowInt(10, length - i);
                n /= 10;
                i++;
            }

            return (sum == temp);
        }
    }
}


namespace NETPROGRAM.BasicExercise
{
    public class Exercise08
    {
        const double E = 0.0001;

        public double PI()
        {
            var result = 0.0;
            var i = 0;
            var x = 1.0;

            while (x > E)
            {
                if(i %2 == 0)
                {
                    result += x;
                }
                else
                {
                    result -= x;
                }
                                         
                i++;
                x = 1.0 / (2 * i + 1);

            }

            return 4.0 * result;
        }
    }
}

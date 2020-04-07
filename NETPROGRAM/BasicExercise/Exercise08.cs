
namespace NETPROGRAM.BasicExercise
{
    public class Exercise08
    {
        const double E = 0.0001;

        public double PI()
        {
            var result = 0.0;
            var i = 0;

            while (1.0/(2 * i + 1) > E)
            {
                    
                result += System.Math.Pow(-1, i) * (1.0 / (2 * i + 1));                         
                i++;

            }

            return System.Math.Round(4.0 * result,5);
        }
    }
}

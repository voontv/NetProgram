namespace NETPROGRAM.BasicExercise
{
    public class Exercise02
    {

        public int sumNumberInt(int a)
        {

            var number = a;
            int sum = 0;

            do
            {
                sum += number % 10;
                number = number / 10;
            } while(number != 0);

            return sum;
        }
    }
}

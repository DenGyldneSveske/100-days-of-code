namespace NextPrimeNumber
{
    public class NextPrime
    {
        public static int findNextPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return findNextPrime(number + 1);
                }
            }
            return number;
        }
    }
}
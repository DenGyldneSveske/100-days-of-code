namespace JohnnyProgress
{
    public class makingProgress
    {
        public static int isJohnnyMakingProgress(int[] milesRun)
        {
            int numberOfProgressDays = 0;
            for (int i = 0; i < milesRun.Length - 1; i++)
            {
                if (milesRun[i] < milesRun[i + 1])
                {
                    numberOfProgressDays += 1;
                }
            }
            return numberOfProgressDays;
        }
    }
}
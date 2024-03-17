using System;

namespace ConvertAgeToDays
{
    public class AgeConverter
    {
        public static int calcAge(int age)
        {
            int yearLength = 365;
            if (age >= 0)
            {
                return age * yearLength;
            }
            return 0;
        }
    }
}
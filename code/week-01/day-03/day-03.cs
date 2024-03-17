namespace BarbecueSkewers
{
    public class Skewers
    {
        public static int[] calculateSkewers(string[] grill)
        {
            int numberOfVegetarianSkewers = 0;
            int numberOfNonVegetarianSkewers = 0;
            for (int i = 0; i < grill.Length; i++)
            {
                char[] skewer = grill[i].ToCharArray();
                int piecesOfMeat = 0;
                for (int j = 0; j < skewer.Length; j++)
                {
                    if (skewer[j] == 'x')
                    {
                        piecesOfMeat += 1;
                    }
                }
                if (piecesOfMeat == 0)
                {
                    numberOfVegetarianSkewers += 1;
                }
                else
                {
                    numberOfNonVegetarianSkewers += 1;
                }
            }
            return new int[] { numberOfVegetarianSkewers, numberOfNonVegetarianSkewers };
        }
    }
}
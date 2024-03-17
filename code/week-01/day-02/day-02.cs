namespace FindingNemo
{
    public class NemoFinder
    {
        public static string findNemo(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "Nemo")
                {
                    return $"I found Nemo at {i + 1}!";
                }
            }
            return "I can't find Nemo :(";
        }
    }
}
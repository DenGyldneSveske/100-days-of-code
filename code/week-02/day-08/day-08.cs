namespace LetterCombinations
{
    public class CreateLetterCombinations
    {
        public static List<string> letterCombinations(string digits)
        {
            Dictionary<char, string> digitToLetters = new Dictionary<char, string>()
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };

            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits))
                return result;


            void generateCombinations(int index, string current)
            {
                if (index == digits.Length)
                {
                    result.Add(current);
                    return;
                }

                char digit = digits[index];
                string letters = digitToLetters[digit];

                foreach (char letter in letters)
                {
                    generateCombinations(index + 1, current + letter);
                }
            }

            generateCombinations(0, "");
            return result;
        }
    }
}










// if (Enumerable.Range(2, 9).Contains(Int32.Parse(letter.ToString())))
// {
//     for (int i = 0; i < 4; i++)
//     {
//         if (letterPlacements[int.Parse(letter.ToString()), i] != "")
//         {
//             if (result.Count == 0)
//             {
//                 result.
//                             }
//         }
//     }
// }
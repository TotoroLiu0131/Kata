namespace GetMiddleCharacter
{
    public class Kata
    {
        public static string GetMiddleCharacter(string input)
        {
            var middleIndex = input.Length / 2;
            return input.Length % 2 == 0 ? input.Substring(middleIndex - 1, 2) : input[middleIndex].ToString();
        }
    }
}
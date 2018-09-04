namespace GetMiddleCharacter
{
    public class Kata
    {
        public string GetMiddleCharacter(string input)
        {
            return input.Length % 2 == 0 ?
                input.Substring(input.Length / 2 - 1, 2) :
                input.Substring(input.Length / 2, 1);
        }
    }
}
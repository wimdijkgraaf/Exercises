using System.Text.RegularExpressions;

namespace BasicAlgorithm.BasicAlgorithmClass
{
    public class AlgorithmClass
    {
        public async Task<int> SumOfNumbersInArray(int[] input)
        {
            int result = (input[0] == input[1]) ? input.Sum() * 3 : input.Take(2).Sum();
            return result;
        }

        public async Task<int> AbsoluteDiferenceOrTriple(int input)
        {
            int result = (input > 51) ? Math.Abs(input - 51) * 3 : Math.Abs(input - 51);
            return result;
        }

        public async Task<bool> Is30OrSum30(int[] input)
        {
            var result = input.Contains(30) || input[0] + input[1] == 30 ? true : false;

            return result;
        }

        public async Task<bool> IsWithin10Of100Or200(int input)
        {
            var result = (input >= 90 && input <= 110) || (input >= 190 && input <= 210);

            return result;
        }

        public async Task<string> AddIf(string input)
        {
            return (input.StartsWith("if") ? input : $"if {input}");
        }

        public async Task<string> RemoveAtPosition(string input, int position)
        {
            string result = input.Remove(position, 1);

            return result;
        }

        public async Task<string> ExchangeFirstAndLast(string input)
        {
            if (input.Length <= 1) { return input; }

            char[] charList = input.ToCharArray();
            char temp = charList[0];
            charList[0] = charList[^1];
            charList[^1] = temp;
            var result = new string(charList);

            return result;
        }

        public async Task<string> FourCoppiesOfFirstCharacter(string input)
        {
            if (input.Length < 2) { return input; }

            string firstCharacter = input.Substring(0, 2);
            var result = string.Concat(Enumerable.Repeat(firstCharacter, 4));

            return result.Trim();
        }

        public async Task<string> LastCharAtFrontAndBack(string input)
        {
            char firstChar = input[^1];

            var result = string.Concat(firstChar, input, firstChar);
            return result;
        }

        public async Task<bool> IsMultipleOf3Or7(int input)
        {
            var result = input % 3 == 0 || input % 7 == 0 ? true : false;

            return result;
        }

        public async Task<string> AddFirstThreeCharAtFrontAndBack(string input)
        {
            if (input.Length <= 2) { return string.Concat(Enumerable.Repeat(input, 3)); };

            string firstThree = input.Substring(0, 3);
            return string.Concat(firstThree, input, firstThree);

        }

        public async Task<bool> StartsWithCSharp(string input)
        {
            return input.StartsWith("C#");
        }

        public async Task<bool> CheckTemperatureLessThan0AndMoreThan100(int[] input)
        {
            return (input[0] > 100 || input[1] > 100) && (input[0] < 0 ^ input[1] < 0);
        }

        public async Task<bool> IsBetween100And200(int[] input)
        {
            return input.Any(i => i >= 100 && i <= 200);
        }

        public async Task<bool> IsInRange20To50(int[] input)
        {
            return input.Any(i => i >= 20 && i <= 50);
        }

        public async Task<string> RemoveYTAtIndex1(string input)
        {
            return input.Substring(1, 2).Equals("yt") ? input.Remove(1, 2) : input;
        }

        public async Task<int> LargestInt(int[] input)
        {
            return input.Max();
        }

        public async Task<int> IsClosestTo100(int[] input)
        {
            if (input[0] == input[1]) { return 0; }
            return 100 - input[0] < 100 - input[1] ? input[0] : input[1];
        }

        public async Task<bool> IsBetween40_50Or50_60(int[] input)
        {
            var intervalo1 = input.All(i => i >= 40 && i <= 50);
            var intervalo2 = input.All(i => i >= 50 && i <= 60);
            return intervalo1 || intervalo2;
        }

        public async Task<int> IsLargestBetween20_30(int[] input)
        {
            return input.Any(i => i < 20 || i > 30) ? 0 : input.Max();
        }

        public async Task<bool> HasBetween2Or4Zs(string input)
        {
            int count = 0;
            char[] chars = input.ToCharArray();

            foreach (char item in chars)
            {
                if (item == 'Z' || item == 'z') { count++; }
            }

            return count >= 2 && count <= 4 ? true : false;
        }

        public async Task<bool> HasSameLastDigit(int[] input)
        {
            return input[0].ToString().Last() == input[1].ToString().Last();
        }

        public async Task<string> UpperCaseLastThree(string input)
        {
            if (input.Length <= 3) { return input.ToUpper(); }

            return Regex.Replace(input, ".{3}$", match => match.Value.ToUpper());
        }

        public async Task<string> CopyStringByNTimes(string input, int repeat)
        {
            if (repeat == 1) { return input; }

            return string.Concat(Enumerable.Repeat(input, repeat));
        }
    }
}

using System.Text.RegularExpressions;

namespace Basics.ClassLibrary
{
    public class ExerciseClass
    {
        private Dictionary<int, string> _romanCentury = new Dictionary<int, string>
        {
            {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
            {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
            {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
        };

        public async Task<double> Add(params double[] values)
        {
            return values.Aggregate((a, b) => a + b);
        }

        public async Task<double> Subtract(params double[] values)
        {
            return values.Aggregate((a, b) => a - b);
        }

        public async Task<double> Multiply(params double[] values)
        {
            return values.Aggregate((a, b) => a * b);
        }

        public async Task<double> Divide(params double[] values)
        {
            return values.Aggregate((a, b) => a / b);
        }

        public async Task<(int Value1, int Value2)> SwapValues(int v1, int v2)
        {
            return (v2, v1);
        }

        public async Task<double[]> MultiplyUpToTen(double value)
        {
            double[] result = new double[11];

            for (int i = 0; i <= 10; i++)
            {
                result[i] = value * i;
            }
            return result;
        }

        public async Task<double> Average(params double[] values)
        {
            return values.Average();
        }

        public async Task<string> CheckAge(int age)
        {
            string result = (age < 30) ? "You're young" : "You're old";
            return result;
        }

        public async Task<string> NumbersInRows(string input)
        {
            var result = "";
            for (int i = 1; i <= 2; i++)
            {
                result += string.Concat(Enumerable.Repeat(input + " ", 4)
                    .ToArray()).Trim() + Environment.NewLine;
                result += string.Concat(Enumerable.Repeat(input + "", 4)
                    .ToArray()).Trim() + Environment.NewLine;
            }
            return result.Trim();
        }

        public async Task<string> NumbersInBlock(string input)
        {
            var result = "";

            result += string.Concat(Enumerable.Repeat(input, 3)
                .ToArray()).Trim() + Environment.NewLine;

            for (int i = 1; i <= 3; i++)
            {
                result += string.Concat(Enumerable.Repeat(input + " ", 2)
                    .ToArray()).Trim() + Environment.NewLine;
            }

            result += string.Concat(Enumerable.Repeat(input, 3)
                .ToArray()).Trim() + Environment.NewLine;

            return result.Trim();
        }

        public async Task<double> CelsiusToFahrenheitConverter(double input)
        {
            return input + 56;
        }

        public async Task<double> CelsiusToKelvinConverter(double input)
        {
            return input + 273;
        }

        public async Task<string> RemoveCharacterByIndex(string input, int index)
        {
            var result = input.Remove(index, 1);
            return result;
        }

        public async Task<string> SwapFirstAndLastCharacters(string input)
        {
            if (input.Length <= 1) return input;

            char[] chars = input.ToCharArray();
            char temp = chars[0];
            chars[0] = chars[input.Length - 1];
            chars[input.Length - 1] = temp;

            return new string(chars);
        }

        public async Task<string> AddFirstCharacterInFrontAndBack(string input)
        {
            char first = input[0];

            var result = $"{first}{input}{first}";
            return result;
        }

        public async Task<bool> CheckIfItsPositiveAndNegative(int value1, int value2)
        {
            var doesFit = (value1 ^ value2) < 0;
            return doesFit;
        }

        public async Task<int> SumOrTriple(int value1, int value2)
        {
            return (value1 + value2) * (value1 == value2 ? 3 : 1);
        }

        public async Task<int> AbsoluteDiferenceOrDouble(int n1, int n2)
        {
            var result = (n1 - n2) * (n1 > n2 ? 2 : -1);
            return result;
        }

        public async Task<bool> FindThe20(int n1, int n2)
        {
            var values = new[] { n1, n2 };
            if (values.Contains(20))
            {
                return true;
            }
            else
            {
                if (n1 + n2 == 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public async Task<bool> CheckIfItsWithin20(int input)
        {
            var itsWithin = Math.Abs(input - 100) <= 20 || (Math.Abs(input - 200) <= 20);
            return itsWithin;
        }

        public async Task<string> TurnLower(string text)
        {
            var result = text.ToLower();
            return result;
        }

        public async Task<string> FindLongestWord(string input)
        {
            string longestWord = input.Split(' ').OrderByDescending(p => p.Length).First();

            return longestWord;
        }

        public async Task<int[]> FindAllOddNumbers(int n1, int n2)
        {
            List<int> oddList = new List<int>();
            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 != 0)
                {
                    oddList.Add(i);
                }
            }
            return oddList.ToArray();
        }

        public async Task<int> SumAllPrime(int n1, int n2)
        {
            int soma = 0;
            int count = 0;
            int num = 2;

            while (count < n2)
            {
                if (IsPrime(num))
                {
                    soma += num;
                    count++;
                }
                num++;
            }
            return soma;
        }

        private static bool IsPrime(int num) // 100
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        public async Task<int> SumDigits(int input)
        {
            string text = input.ToString();

            var sum = 0;

            for (var i = 0; i < text.Length; i++)
            {
                var value = int.Parse(text[i].ToString());
                sum += value;
            }

            return sum;
        }

        public async Task<string> ReverseText(string input)
        {
            string[] words = input.Split(' ');
            string[] reverseWords = words.Reverse().ToArray();
            string result = string.Join(" ", reverseWords);

            return result;
        }

        public async Task<long> FileSizeCounter(string filePath)
        {
            FileInfo file = new FileInfo(filePath);

            return file.Length;
        }

        public async Task<int> ToDecimalConverter(string input)
        {
            int result = int.Parse(input, System.Globalization.NumberStyles.HexNumber);
            return result;
        }

        public async Task<int[]> MultiplyArray(int[] input1, int[] input2)
        {
            int count = input1.Length;
            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = input1[i] * input2[i];
            }
            return result;
        }

        public async Task<string> CopyLastFourCharacters(string input)
        {
            int length = input.Length;
            string subString = input.Substring(length - 4);

            string result = string.Concat(Enumerable.Repeat(subString, 4));
            return result.Trim();
        }

        public async Task<bool> CheckIfItsMultiple(double n1, double n2)
        {
            double result = n1 / n2;
            bool doesFit = (int)result == result;

            return doesFit;
        }

        public async Task<bool> CheckTheFirstWord(string input, string output)
        {
            string[] list = input.Split(' ');
            bool result = list[0] == output;

            return result;
        }

        public async Task<bool> CheckIfItsLessThan100AndGreaterThan200(int n1, int n2)
        {
            bool result = n1 < 100 && n2 > 200;
            return result;
        }

        public async Task<bool> FitsRange(int n1, int n2)
        {
            bool result = (n1 > -10) && (n1 < 10) && (n2 > -10) && (n2 < 10);

            return result;
        }

        public async Task<string> RemoveCharacterByString(string input, string remove)
        {
            string result = input.Replace(remove, "");
            return result;
        }

        public async Task<bool> StringFinder(string input, string lookingFor)
        {
            return input.Contains(lookingFor) ? true : false;
        }

        public async Task<(int Largest, int Lowest)> FindLargestAndLowest(int n1, int n2, int n3)
        {
            (int Largest, int Lowest) result;
            result.Largest = Math.Max(Math.Max(n1, n2), n3);
            result.Lowest = Math.Min(Math.Min(n1, n2), n3);

            return result;
        }

        public async Task<int> NextTo20(int n1, int n2)
        {
            int value1 = 20 - n1;
            int value2 = 20 - n2;

            int result = (n1 == n2) ? 0 : ((value1 < value2) ? n1 : n2);
            return result;
        }

        public async Task<string> FirstFourUpperCase(string input)
        {
            string result = "";
            if (input.Length <= 4)
            {
                return input.ToUpper();
            }
            else
            {
                result = input.Substring(0, 4).ToUpper() + input.Substring(4);
                return result;
            }
        }

        public async Task<string> RemoveOddNumberedCharacters(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i += 2)
            {
                result += input.Substring(i, 1);
            }

            return result;
        }

        public async Task<string> EspecificNumberCounter(int n1, int[] array)
        {
            int count = 0;

            //foreach (int item in array)
            //{
            //    count += item == n1 ? 1 : 0;
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    count += array[i] == n1 ? 1 : 0;
            //}

            count = array.Where(x => x == n1).Count();

            return $"Number {n1} found {count} times";
        }

        public async Task<bool> FirstOrLast(int n1, int[] array)
        {
            bool result = (array[0] == n1) || (array[^1] == n1);

            return result;
        }

        public async Task<int> SumArray(int[] array)
        {
            int result = 0;
            int count = array.Length;

            for (int i = 0; i < count; i++)
            {
                result += array[i];
            }

            return result;
        }

        public async Task<bool> FirstOrLastCompare(int[] array, int[] array2)
        {
            return array[0] == array2[0] || array[^1] == array2[^1];
        }

        public async Task<int[]> ArrayInverter(int[] array)
        {
            int[] result = array.Reverse().ToArray();

            return result;
        }

        public async Task<int> LargestBetweenFirstAndLast(int[] array)
        {
            int count = array.Length - 1;
            int result = (array[0] > array[count]) ? array[0] : array[count];

            return result;
        }

        public async Task<int[]> MiddleArray(params int[][] arrays)
        {
            return arrays.Select(a => a[1]).ToArray();
        }

        public async Task<bool> HasOddNumber(int[] array)
        {
            return array.Any(n => n % 2 != 0);
        }

        public async Task<string> CenturyOfTheYear(int year)
        {

            int century = (year + 99) / 100;

            string result = "";

            foreach (var item in _romanCentury.OrderByDescending(x => x.Key))
            {
                while (century >= item.Key)
                {
                    result += item.Value;
                    century -= item.Key;
                }
            }
            return result;
        }

        public async Task<int> LargestProductToAdjacent(int[] array)
        {
            int product = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                product = ((array[i] * array[i + 1]) > product) ? (array[i] * array[i + 1]) : product;
            }

            return product;
        }

        public async Task<bool> IsPalindrome(string input)
        {
            string reverseInput = new string(input.Reverse().ToArray());
            bool result = (reverseInput == input) ? true : false;

            return result;
        }

        public async Task<int[]> ArrayCheck(int[] array)
        {
            int[] missing = new int[9];
            int count = 0;

            for (int i = 1; i <= 9; i++)
            {
                if (!array.Contains(i)) { missing[count] = i; count++; };
            }

            return missing.Take(count).ToArray();
        }

        public async Task<string> FileNameFinder(string filePath)
        {
            string fileName = filePath.Split('\\').Last();

            return fileName;
        }

        public async Task<int[]> MultiplyArrayByLength(int[] array)
        {
            var result = array.Select(x => x * array.Length).ToArray();
            return result;
        }

        public async Task<int> MinValueFromString(string n1, string n2)
        {
            int v1 = int.Parse(n1);
            int v2 = int.Parse(n2);

            return (v1 > v2) ? v2 : v1;
        }

        public async Task<string> TextEncripter(string input)
        {
            var encript = new Dictionary<string, string>
            {
                {"P", "9"},
                {"T", "0"},
                {"S", "1"},
                {"H", "6"},
                {"A", "8"}
            };

            string result = encript.Aggregate(input, (a, b) => a.Replace(b.Key, b.Value));

            return result;
        }

        public async Task<int> SpecificCharacterCounter(string input, char upperCase, char lowerCase)
        {
            char[] charList = input.Substring(0, input.Length - 1).ToArray();
            int result = 0;

            foreach (var item in charList)
            {
                result = (item == upperCase || item == lowerCase) ? result + 1 : result + 0;
            }

            return result;
        }

        public async Task<bool> CheckIfItsOnlyUpperOrLowerCase(string input)
        {
            var result = input.All(c => char.IsUpper(c)) || input.All(c => char.IsLower(c));
            return result;
        }

        public async Task<string> RemoveFirstAndLastCharacter(string input)
        {
            var result = input.Length > 2 ? input.Substring(1, input.Length - 2) : input;
            return result;
        }

        public async Task<bool> CheckIfItsConsecutive(string input)
        {
            bool result = false;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    result = true;
                }
            }

            return result;
        }

        public async Task<bool> WholeNumberAverage(int[] array)
        {
            double average = array.Average();

            return (average == (int)average) ? true : false;
        }

        public async Task<string> OrderByAlphabetical(string input)
        {
            string result = new string(input.OrderBy(x => x).ToArray());
            return result;
        }

        public async Task<string> OddOrEvenLength(string input)
        {
            string result = (input.Length % 2 == 0) ? "Even Length" : "Odd Length";
            return result;
        }

        public async Task<int> OddNumberByPosition(int position)
        {
            int result = (position * 2) - 1;

            return result;
        }

        public async Task<int> AsciiNumber(char input)
        {
            return (int)input;
        }

        public async Task<bool> IsPlural(string input)
        {
            bool result = input.EndsWith("s");
            return result;
        }

        public async Task<double> SumOfSqr(int[] array)
        {
            double result = array.Sum(n => n * n);
            return result;
        }

        public async Task<string[]> GetTypeOfArray(object[] array)
        {
            var result = array.Select(x => x.GetType().Name).ToArray();
            return result;
        }

        public async Task<bool> SwapAndCheckTheLargest(int input)
        {
            bool result = ((input % 10 * 10) + (input / 10)) > input ? true : false;

            return result;
        }

        public async Task<string> NonLetterRemoval(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    result += c;
                }
            }
            return result;
        }

        public async Task<string> VowelRemover(string input)
        {
            string result = new Regex(@"[aeiouAEIOU]").Replace(input, "");
            return result;
        }

        public async Task<int[]> LowerCaseIndexer(string input)
        {
            var result = input.Select((x, i) => i).Where(i => char.IsLower(input[i])).ToArray();
            return result;
        }

        public async Task<double[]> CumulativeSum(double[] array)
        {
            double[] result = new double[array.Length];

            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                result[i] = Math.Round(sum, 2);
            }
            return result;
        }

        public async Task<string> LetterAndNumberCount(string input)
        {
            int letterCount = 0;
            int digitCount = 0;
            string breakInput = input.Replace(" ", "").Replace(".", "");

            foreach (char c in breakInput)
            {
                if (!char.IsLetter(c))
                {
                    digitCount++;
                }
                else
                {
                    letterCount++;
                }
            }

            string result = $"{letterCount} letters and {digitCount} digits";
            return result;
        }

        public async Task<int> SumOfInteriorAnglesOfAPoligon(int input)
        {
            int result = 180 * (input - 2);

            return result;
        }

        public async Task<string> PositiveAndNegativeArray(double[] array)
        {
            int positives = array.Count(x => x > 0);
            int negatives = array.Count(x => x < 0);
            return $"{positives} positives and {negatives} negatives";
        }

        public async Task<string> BinaryCounter(int input)
        {
            var binary = Convert.ToString(input, 2);
            var zeros = binary.Count(c => c == '0');
            var ones = binary.Count(c => c == '1');
            return $"{zeros} zeros and {ones} ones";
        }

        public async Task<int[]> IntegerExtractor(object[] mixedArray)
        {
            var result = mixedArray.OfType<int>().ToArray();

            return result;
        }

        public async Task<int> NextPrime(int input)
        {
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    input++;
                    i = 2;
                }
            }
            return input;
        }

        public async Task<string> LongestCommonPrefix(string[] input)
        {
            var result = input.Aggregate((a, b) =>
                string.Join("", a.TakeWhile((c, i) => i < b.Length && c == b[i])));

            return result;
        }

        public async Task<bool> CheckIfBracketsIsClosed(string input)
        {
            var pile = new Stack<char>();
            var map = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' },
                { '>', '<' }
            };

            foreach (var character in input)
            {
                if (map.ContainsValue(character))
                {
                    pile.Push(character);
                }
                else if (map.ContainsKey(character))
                {
                    if (pile.Count == 0 || pile.Pop() != map[character])
                    {
                        return false;
                    }
                }
            }

            return pile.Count == 0;
        }

        public async Task<bool> CheckIfCharacterAreSame(string input)
        {
            return input.Distinct().Count() == 1;
        }

        public async Task<bool> CheckIfItsOnlyNumbers(string input)
        {
            double result;

            return double.TryParse(input, out result);
        }

        public async Task<int[]> PrimeList(int input)
        {
            var primeList = new List<int>();
            int integer = 2;

            while (primeList.Count <= input)
            {
                if (IsPrime(integer))
                {
                    primeList.Add(integer);
                }
                integer++;
            }

            return primeList.ToArray();
        }

        public async Task<bool> IsSameTypeAndValue(object[] input)
        {
            bool isEqual = input[0].GetType().Equals(input[1].GetType());

            return isEqual ? input[0].ToString() == input[1].ToString() : false;
        }

        public async Task<string> IdentityMatrixCreator(int input)
        {
            string result = "";

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    result += (i == j) ? "1" : "0";
                    if (j < input - 1) result += " ";
                }
                if (i < input - 1) result += Environment.NewLine;
            }

            return result;
        }

        public async Task<string> SortString(string input)
        {
            var letters = input.Where(c => char.IsLetter(c)).OrderBy(c => char.ToLower(c));
            var numbers = input.Where(c => char.IsDigit(c)).OrderBy(c => c);
            string result = "";

            result = (input.Trim() == "") ? "Blank String" : new string(letters.Concat(numbers).ToArray());

            return result;
        }

        public async Task<int> EqualsBetweenThree(int[] input)
        {
            var result = input.GroupBy(n => n);
            return result.Where(g => g.Count() > 1).Sum(g => g.Count());
        }
    }
}

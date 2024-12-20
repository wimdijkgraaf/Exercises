using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibrary
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
            var value1 = v2;
            var value2 = v1;
            return (value1, value2);
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

        private static bool IsPrime(int num)
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
    }
}
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace BasicAlgorithm.BasicAlgorithmClass
{
    public class AlgorithmClass
    {
        public async Task<int> SumOfNumbersInArray(int[] input)
        {
            int result = (input[0] == input[1]) ? input.Sum() * 2 : input.Take(2).Sum();
            return result;
        }
    }
}

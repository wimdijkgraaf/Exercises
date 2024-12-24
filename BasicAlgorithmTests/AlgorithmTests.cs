using BasicAlgorithm.BasicAlgorithmClass;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace BasicAlgorithm.BasicAlgorithmTests
{
    [TestClass]
    public class AlgorithmTests
    {
        private readonly AlgorithmClass _exercise;

        public AlgorithmTests()
        {
            _exercise = new AlgorithmClass();
        }

        [TestMethod]
        public async Task ShouldSumIntegersFromArrayOrTripleIfItsEqual()
        {
            //Arrange
            int[] input = { 1, 2 };
            int[] input2 = { 3, 2 };
            int[] input3 = { 2, 2 };

            //Act
            int result = await _exercise.SumOfNumbersInArray(input);
            int result2 = await _exercise.SumOfNumbersInArray(input2);
            int result3 = await _exercise.SumOfNumbersInArray(input3);

            //Assert
            result.Should().Be(3);
            result2.Should().Be(5);
            result3.Should().Be(8);
        }
    }
}
using System.Reflection;
using ClassLibrary;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace ExerciseTests
{
    [TestClass]
    public class ExerciseTests
    {
        private readonly ExerciseClass _exercise;

        public ExerciseTests()
        {
            _exercise = new ExerciseClass();
        }

        [TestMethod]
        public async Task ShouldAddTwoNumbers()
        {
            //Arrange
            var value1 = 10;
            var value2 = 20;

            //Act
            var result = await _exercise.Add(value1, value2);

            //Assert
            result.Should().Be(30);
        }

        [TestMethod]
        public async Task ShouldDivideTwoNumbers()
        {
            //Arrange
            var value1 = 100;
            var value2 = 20;

            //Act
            var result = await _exercise.Divide(value1, value2);

            //Assert
            result.Should().Be(5);
        }

        [TestMethod]
        public async Task ShouldSwapTwoNumbers()
        {
            //Arrange
            var swap = new ExerciseClass();
            var number1 = 5;
            var number2 = 10;

            //Act
            (int Value1, int Value2) result = await swap.SwapValues(number1, number2);

            //Assert
            result.Value1.Should().Be(10);
            result.Value2.Should().Be(5);
        }

        [TestMethod]
        public async Task ShouldMultiplyThreeNumbers()
        {
            //Arrange
            var value1 = 10;
            var value2 = 5;
            var value3 = 2;

            //Act
            var result = await _exercise.Multiply(value1, value2, value3);

            //Assert
            result.Should().Be(100);
        }

        [TestMethod]
        public async Task ShouldCalculateTwoNumbers()
        {
            //Arrange
            double value1 = 25;
            double value2 = 4;
            double value3 = 10;

            //Act
            var add = await _exercise.Add(value1, value2);
            var subtract = await _exercise.Subtract(value1, value2);
            var multiply = await _exercise.Multiply(value1, value2);
            var divide = await _exercise.Divide(value1, value2);
            var expression = await _exercise.Divide(await _exercise.Multiply(value1, value2), value3);

            //Assert
            add.Should().Be(29);
            subtract.Should().Be(21);
            multiply.Should().Be(100);
            divide.Should().Be(6.25);
            expression.Should().Be(10);
        }

        [TestMethod]
        public async Task ShouldMultiplyForAllNumbersUpTo10()
        {
            //Arrange
            double value = 5;

            //Act
            double[] result = await _exercise.MultiplyUpToTen(value);

            //Assert
            result[0].Should().Be(0);
            result[5].Should().Be(25);
            result[10].Should().Be(50);
        }

        [TestMethod]
        public async Task ShouldFindTheAverage()
        {
            //Arrange
            double value1 = 10;
            double value2 = 15;
            double value3 = 20;
            double value4 = 30;

            //Act
            var result = await _exercise.Average(value1, value2, value3, value4);

            //Assert
            result.Should().Be(18.75);
        }

        [TestMethod]
        public async Task ShouldCheckAge()
        {
            //Arrange
            int age = 25;

            //Act
            var result = await _exercise.CheckAge(age);

            //Assert
            result.Should().Be("You're young");
        }

        [TestMethod]
        public async Task ShouldRepeatNumbersInRows()
        {
            //Arrange
            string number = "25";

            //Act
            string result = await _exercise.NumbersInRows(number);

            //Assert
            result.Should().Be("25 25 25 25\r\n25252525\r\n25 25 25 25\r\n25252525");
        }

        [TestMethod]
        public async Task ShouldRepeatNumbersAsABlock()
        {
            //Arrange
            string number = "5";

            //Act
            string result = await _exercise.NumbersInBlock(number);

            //Assert
            result.Should().Be("555\r\n5 5\r\n5 5\r\n5 5\r\n555");
        }

        [TestMethod]
        public async Task ShouldConvertCelsiusToKelvinAndFahrenheit()
        {
            //Arrange
            double celsius = 30;

            //Act
            var resultFahrenheit = await _exercise.CelsiusToFahrenheitConverter(celsius);
            var resultKelvin = await _exercise.CelsiusToKelvinConverter(celsius);

            //Assert
            resultFahrenheit.Should().Be(86);
            resultKelvin.Should().Be(303);
        }

        [TestMethod]
        public async Task ShouldRemoveCharacterByIndex()
        {
            //Arrange
            string input = "w3resource";
            int index = 1;
            int index2 = 9;
            int index3 = 0;

            //Act
            var result1 = await _exercise.RemoveCharacterByIndex(input, index);
            var result2 = await _exercise.RemoveCharacterByIndex(input, index2);
            var result3 = await _exercise.RemoveCharacterByIndex(input, index3);

            //Assert
            result1.Should().Be("wresource");
            result2.Should().Be("w3resourc");
            result3.Should().Be("3resource");
        }

        [TestMethod]
        public async Task ShouldSwapFirstAndLastCharacters()
        {
            //Arrange
            string input1 = "w3resource";
            string input2 = "Python";

            //Act
            var result1 = await _exercise.SwapFirstAndLastCharacters(input1);
            var result2 = await _exercise.SwapFirstAndLastCharacters(input2);

            //Assert
            result1.Should().Be("e3resourcw");
            result2.Should().Be("nythoP");
        }

        [TestMethod]
        public async Task ShouldAddFirstCharacterInFrontAndBack()
        {
            //Arrange
            string input = "The quick brown fox jumps over the lazy dog";

            //Act
            string result = await _exercise.AddFirstCharacterInFrontAndBack(input);

            //Assert
            result.Should().Be("TThe quick brown fox jumps over the lazy dogT");
        }

        [TestMethod]
        public async Task ShouldCheckIfItsPositiveOrNegative()
        {
            //Arrange
            int value1 = -5;
            int value2 = 25;
            int value3 = 30;
            int value4 = -40;

            //Act
            bool result = await _exercise.CheckIfItsPositiveAndNegative(value1, value2);
            bool result2 = await _exercise.CheckIfItsPositiveAndNegative(value2, value3);
            bool result3 = await _exercise.CheckIfItsPositiveAndNegative(value1, value4);

            //Assert
            result.Should().Be(true);
            result2.Should().Be(false);
            result3.Should().Be(false);
        }

        [TestMethod]
        public async Task ShouldSumOrTriple()
        {
            //Arrange
            int value1 = 5;
            int value2 = 10;
            int value3 = 5;

            //Act
            int result1 = await _exercise.SumOrTriple(value1, value2);
            int result2 = await _exercise.SumOrTriple(value1, value3);

            //Assert
            result1.Should().Be(15);
            result2.Should().Be(30);
        }

        [TestMethod]
        public async Task ShouldGetAbsoluteDiferenceOrDoubleIt()
        {
            //Arrange
            int n1 = 13;
            int n2 = 40;
            int n3 = 50;
            int n4 = 21;

            //Act
            int result1 = await _exercise.AbsoluteDiferenceOrDouble(n1, n2);
            int result2 = await _exercise.AbsoluteDiferenceOrDouble(n3, n4);

            //Assert
            result1.Should().Be(27);
            result2.Should().Be(58);
        }

        [TestMethod]
        public async Task ShouldFind20OrSum20()
        {
            //Arrange
            int n1 = 5;
            int n2 = 15;
            int n3 = 20;
            int n4 = 25;

            //Act
            bool result1 = await _exercise.FindThe20(n1, n2);
            bool result2 = await _exercise.FindThe20(n1, n3);
            bool result3 = await _exercise.FindThe20(n1, n4);

            //Assert
            result1.Should().Be(true);
            result2.Should().Be(true);
            result3.Should().Be(false);
        }

        [TestMethod]
        public async Task ShouldCheckWithin20Of100Or200()
        {
            //Arrange
            int n1 = 25;
            int n2 = 50;
            int n3 = 80;
            int n4 = 185;

            //Act
            bool result1 = await _exercise.CheckIfItsWithin20(n1);
            bool result2 = await _exercise.CheckIfItsWithin20(n2);
            bool result3 = await _exercise.CheckIfItsWithin20(n3);
            bool result4 = await _exercise.CheckIfItsWithin20(n4);

            //Assert
            result1.Should().Be(false);
            result2.Should().Be(false);
            result3.Should().Be(true);
            result4.Should().Be(true);
        }

        [TestMethod]
        public async Task ShouldTurnIntoLower()
        {
            //Arrange
            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string name = "JESUALDO";

            //Act
            string result = await _exercise.TurnLower(text);
            string resultName = await _exercise.TurnLower(name);

            //Assert
            result.Should().Be("abcdefghijklmnopqrstuvwxyz");
            resultName.Should().Be("jesualdo");
        }

        [TestMethod]
        public async Task ShouldFindLongestWord()
        {
            //Arrange
            string text = "You are not prepared";
            string text2 = "We cannot to hide";

            //Act
            string result = await _exercise.FindLongestWord(text);
            string result2 = await _exercise.FindLongestWord(text2);

            //Assert
            result.Should().Be("prepared");
            result2.Should().Be("cannot");
        }

        [TestMethod]
        public async Task ShouldFindAllOddNumbers()
        {
            //Arrange
            int n1 = 1;
            int n2 = 20;

            //Act
            int[] result = await _exercise.FindAllOddNumbers(n1, n2);
            int count = result.Length;

            //Assert
            result[0].Should().Be(1);
            result[9].Should().Be(19);
        }

        [TestMethod]
        public async Task ShouldSumAllPrimeNumbersUntilLimit()
        {
            //Arrange
            int n1 = 1;
            int n2 = 500;

            //Act
            int result = await _exercise.SumAllPrime(n1, n2);

            //Assert
            result.Should().Be(824693);
        }

        [TestMethod]
        public async Task ShouldSumDigits()
        {
            //Arrange
            int n1 = 12;
            int n2 = 254;

            //Act
            int result = await _exercise.SumDigits(n1);
            int result2 = await _exercise.SumDigits(n2);

            //Assert
            result.Should().Be(3);
            result2.Should().Be(11);
        }

        [TestMethod]
        public async Task ShouldReverseText()
        {
            //Arrange
            string input = "You are not prepared";

            //Act
            string result = await _exercise.ReverseText(input);

            //Assert
            result.Should().Be("prepared not are You");
        }

        [TestMethod]
        public async Task ShouldShowFileSizeInBytes()
        {
            //Arrange
            string filePath = @"D:\Material de aula\Aula de Programação\curso_C#\Aulas\Exercises\ClassLibrary\ReadableFile.xml";

            //Act
            long result = await _exercise.FileSizeCounter(filePath);

            //Assert
            result.Should().Be(767);
        }

        [TestMethod]
        public async Task ShouldConvertHexadecimalToDecimal()
        {
            //Arrange
            string input = "4B0";
            string input2 = "5C1";

            //Act
            int result = await _exercise.ToDecimalConverter(input);
            int result2 = await _exercise.ToDecimalConverter(input2);

            //Assert
            result.Should().Be(1200);
            result2.Should().Be(1473);
        }

        [TestMethod]
        public async Task ShouldMultiplyArrays()
        {
            //Arrange
            int[] input1 = [1, 3, -5, 4];
            int[] input2 = [1, 4, -5, -2];

            //Act
            int[] result = await _exercise.MultiplyArray(input1, input2);

            //Assert
            result[0].Should().Be(1);
            result[1].Should().Be(12);
            result[2].Should().Be(25);
            result[3].Should().Be(-8);
        }

        [TestMethod]
        public async Task ShouldCopyLastFourCharacters()
        {
            //Arrange
            string input = "The quick brown fox jumps over the lazy dog.";
            string input2 = "You are not prepared";

            //Act
            string result = await _exercise.CopyLastFourCharacters(input);
            string result2 = await _exercise.CopyLastFourCharacters(input2);

            //Assert
            result.Should().Be("dog.dog.dog.dog.");
            result2.Should().Be("aredaredaredared");
        }

        [TestMethod]
        public async Task ShouldCheckIfItsMultiple()
        {
            //Arrange
            double n1 = 15;
            double n2 = 3;
            double n3 = 4;

            //Act
            bool result = await _exercise.CheckIfItsMultiple(n1, n2);
            bool result2 = await _exercise.CheckIfItsMultiple(n1, n3);

            //Assert
            result.Should().Be(true);
            result2.Should().Be(false);
        }

        [TestMethod]
        public async Task ShouldStartWithSameWord()
        {
            //Arrange
            string input = "Hello how are you";
            string output = "Hello";
            string output2 = "World";

            //Act
            bool result = await _exercise.CheckTheFirstWord(input, output);
            bool result2 = await _exercise.CheckTheFirstWord(input, output2);

            //Assert
            result.Should().Be(true);
            result2.Should().Be(false);
        }

        [TestMethod]
        public async Task ShouldCheckIfItsLessThan100AndGreaterThan200()
        {
            //Arrange
            int n1 = 75;
            int n2 = 250;

            //Act
            bool result = await _exercise.CheckIfItsLessThan100AndGreaterThan200(n1, n2);

            //Assert
            result.Should().Be(true);
        }

        [TestMethod]
        public async Task ShouldBeInsideRange()
        {
            //Arrange
            int n1 = -5;
            int n2 = 8;
            int n3 = 15;

            //Act
            bool result = await _exercise.FitsRange(n1, n2);
            bool result2 = await _exercise.FitsRange(n1, n3);

            //Assert
            result.Should().Be(true);
            result2.Should().Be(false);
        }

        [TestMethod]
        public async Task ShouldRemoveStringPart()
        {
            //Arrange
            string input = "PHP Tutorial";
            string remove = "HP";

            //Act
            string result = await _exercise.RemoveCharacterByString(input, remove);

            //Assert
            result.Should().Be("P Tutorial");
        }

        [TestMethod]
        public async Task ShouldFindTheString()
        {
            //Arrange
            string input = "PHP";
            string lookingFor = "PH";

            //Act
            bool result = await _exercise.StringFinder(input, lookingFor);

            //Assert
            result.Should().Be(true);
        }

        [TestMethod]
        public async Task ShouldFindLargestAndLowest()
        {
            //Arrange
            int n1 = 15;
            int n2 = 25;
            int n3 = 30;

            int n4 = 252;
            int n5 = 62;
            int n6 = 12;

            //Act
            (int Largest, int Lowest) result = await _exercise.FindLargestAndLowest(n1, n2, n3);
            (int Largest, int Lowest) result2 = await _exercise.FindLargestAndLowest(n4, n5, n6);

            //Assert
            result.Largest.Should().Be(30);
            result.Lowest.Should().Be(15);
            result2.Largest.Should().Be(252);
            result2.Lowest.Should().Be(12);
        }

        [TestMethod]
        public async Task ShouldFindTheClosestTo20()
        {
            //Arrange
            int n1 = 15;
            int n2 = 12;
            int n3 = 15;

            //Act
            int result = await _exercise.NextTo20(n1, n2);
            int result2 = await _exercise.NextTo20(n1, n3);

            //Assert
            result.Should().Be(15);
            result2.Should().Be(0);
        }

        [TestMethod]
        public async Task ShouldUpperCaseFirstFourCharacters()
        {
            //Arrange
            string input = "This isnt over";
            string input2 = "w3r";

            //Act
            string result = await _exercise.FirstFourUpperCase(input);
            string result2 = await _exercise.FirstFourUpperCase(input2);

            //Assert
            result.Should().Be("THIS isnt over");
            result2.Should().Be("W3R");
        }

        [TestMethod]
        public async Task ShouldRemoveOddNumberedChar()
        {
            //Arrange
            string input = "w3resource";

            //Act
            string result = await _exercise.RemoveOddNumberedCharacters(input);

            //Assert
            result.Should().Be("wrsuc");
        }

        [TestMethod]
        public async Task ShouldCountTheEspecificNumberInsideArray()
        {
            //Arrange
            int n1 = 5;
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

            //Act
            string result = await _exercise.EspecificNumberCounter(n1, array);

            //Assert
            result.Should().Be("Number 5 found 2 times");
        }

        [TestMethod]
        public async Task ShouldFindIfItsFirstOrLast()
        {
            //Arrange
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            int n1 = 25;

            //Act
            bool result = await _exercise.FirstOrLast(n1, array);

            //Assert
            result.Should().Be(false);
        }
    }
}
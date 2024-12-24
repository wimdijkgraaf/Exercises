using System.Drawing;
using System.Reflection;
using System.Transactions;
using System.Xml.XPath;
using ClassLibrary;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            int n2 = 9;

            //Act
            bool result = await _exercise.FirstOrLast(n1, array);
            bool result2 = await _exercise.FirstOrLast(n2, array);

            //Assert
            result.Should().Be(false);
            result2.Should().Be(true);
        }

        [TestMethod]
        public async Task ShouldSumAllIntsInArray()
        {
            //Arrange
            int[] array = [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1];

            //Act
            int result = await _exercise.SumArray(array);

            //Assert
            result.Should().Be(69);
        }

        [TestMethod]
        public async Task ShouldCompareFirstOrLastElementsOfArray()
        {
            //Arrange
            int[] array = [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1];
            int[] array2 = [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5];
            int[] array3 = [0, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5];

            //Act
            bool result = await _exercise.FirstOrLastCompare(array, array2);
            bool result2 = await _exercise.FirstOrLastCompare(array, array3);

            //Assert
            result.Should().Be(true);
            result2.Should().Be(false);
        }

        [TestMethod]
        public async Task ShouldInvertAnArray()
        {
            //Arrange
            int[] array = [1, 2, 8];

            //Act
            int[] result = await _exercise.ArrayInverter(array);

            //Assert
            result[0].Should().Be(8);
            result[1].Should().Be(2);
            result[2].Should().Be(1);
        }

        [TestMethod]
        public async Task ShouldFindLargesBetweenFirstAndLastNumberOfArray()
        {
            //Arrange
            int[] array = [1, 2, 5, 7, 8];
            int[] array2 = [9, 2, 5, 7, 8];

            //Act
            int result = await _exercise.LargestBetweenFirstAndLast(array);
            int result2 = await _exercise.LargestBetweenFirstAndLast(array2);

            //Assert
            result.Should().Be(8);
            result2.Should().Be(9);
        }

        [TestMethod]
        public async Task ShouldCreateArrayWithElementsOfTheMiddleOfOtherArray()
        {
            //Arrange
            int[] array1 = [1, 2, 5];
            int[] array2 = [0, 3, 8];
            int[] array3 = [-1, 0, 2];

            //Act
            int[] result = await _exercise.MiddleArray(array1, array2, array3);

            //Assert
            result[0].Should().Be(2);
            result[1].Should().Be(3);
            result[2].Should().Be(0);
        }

        [TestMethod]
        public async Task ShouldFindTheOddNumbersInArray()
        {
            //Arrange
            int[] array = [2, 4, 7, 8, 6];

            //Act
            bool result = await _exercise.HasOddNumber(array);

            //Assert
            result.Should().Be(true);
        }

        [TestMethod]
        public async Task ShouldFindTheCenturyOfAnYear()
        {
            //Arrange
            int year = 2024;
            int year2 = 901;

            //Act
            string result = await _exercise.CenturyOfTheYear(year);
            string result2 = await _exercise.CenturyOfTheYear(year2);

            //Assert
            result.Should().Be("XXI");
            result2.Should().Be("X");
        }

        [TestMethod]
        public async Task ShouldFindLargestProductBetweenAdjacent()
        {
            //Arrange
            int[] array = { 2, 4, 2, 6, 9, 3 };
            int[] array2 = { 3, 5, 8, 8, 7, 4, 6 };

            //Act
            int result = await _exercise.LargestProductToAdjacent(array);
            int result2 = await _exercise.LargestProductToAdjacent(array2);

            //Assert
            result.Should().Be(54);
            result2.Should().Be(64);
        }

        [TestMethod]
        public async Task ShouldCheckIfItsAPalindrome()
        {
            //Arrange
            string input = "ovo";
            string input2 = "analize";

            //Act
            bool result = await _exercise.IsPalindrome(input);
            bool result2 = await _exercise.IsPalindrome(input2);

            //Assert
            result.Should().Be(true);
            result2.Should().Be(false);
        }

        [TestMethod]
        public async Task ShouldCheckHowManyIntegersIsMissing()
        {
            //Arrange
            int[] array = [1, 3, 4, 7, 9];
            int[] array2 = [2, 5, 8];

            //Act
            int[] result = await _exercise.ArrayCheck(array);
            int[] result2 = await _exercise.ArrayCheck(array2);

            //Assert
            result[0].Should().Be(2);
            result[^1].Should().Be(8);
            result2[0].Should().Be(1);
            result2[^1].Should().Be(9);
        }

        [TestMethod]
        public async Task ShouldFindFileName()
        {
            //Arrange
            string filePath = @"D:Temp\curso_C#\Aulas\Storage\Calculator.xml";
            string filePath2 = @"D:Temp\curso_C#\Aulas\Storage\Calculator.json";

            //Act
            string result = await _exercise.FileNameFinder(filePath);
            string result2 = await _exercise.FileNameFinder(filePath2);

            //Assert
            result.Should().Be("Calculator.xml");
            result2.Should().Be("Calculator.json");
        }

        [TestMethod]
        public async Task ShouldMultiplyArrayNumbersByItsLength()
        {
            //Arrange
            int[] array = [2, 5, 8, 10];

            //Act
            int[] result = await _exercise.MultiplyArrayByLength(array);

            //Assert
            result[0].Should().Be(8);
            result[^1].Should().Be(40);
        }

        [TestMethod]
        public async Task ShouldFindMinValueFromAString()
        {
            //Arrange
            string n1 = "25";
            string n2 = "33";

            //Act
            int result = await _exercise.MinValueFromString(n1, n2);

            //Assert
            result.Should().Be(25);
        }

        [TestMethod]
        public async Task ShouldEncriptAString()
        {
            //Arrange
            string input = "JAVASCRIPT";

            //Act
            string result = await _exercise.TextEncripter(input);

            //Assert
            result.Should().Be("J8V81CRI90");
        }

        [TestMethod]
        public async Task ShouldCountSpecificCharacterInAString()
        {
            //Arrange
            string input = "PHP Exercises";
            char upperCase = 'E';
            char lowerCase = 'e';
            string input2 = "Latest News, Breaking News LIVE";
            char upperCase2 = 'A';
            char lowerCase2 = 'a';

            //Act
            int result = await _exercise.SpecificCharacterCounter(input, upperCase, lowerCase);
            int result2 = await _exercise.SpecificCharacterCounter(input2, upperCase2, lowerCase2);

            //Assert
            result.Should().Be(3);
            result2.Should().Be(2);
        }

        [TestMethod]
        public async Task ShouldCheckIfItsOnlyLowerOrUpperCase()
        {
            //Arrange
            string input = "PHP";
            string input2 = "python";
            string input3 = "JavaScript";

            //Act
            bool result = await _exercise.CheckIfItsOnlyUpperOrLowerCase(input);
            bool result2 = await _exercise.CheckIfItsOnlyUpperOrLowerCase(input2);
            bool result3 = await _exercise.CheckIfItsOnlyUpperOrLowerCase(input3);

            //Assert
            result.Should().Be(true);
            result2.Should().Be(true);
            result3.Should().Be(false);
        }

        [TestMethod]
        public async Task ShouldRemoveFirstAndLastCharacter()
        {
            //Arrange
            string input = "PHP";
            string input2 = "Python";
            string input3 = "JavaScript";

            //Act
            string result = await _exercise.RemoveFirstAndLastCharacter(input);
            string result2 = await _exercise.RemoveFirstAndLastCharacter(input2);
            string result3 = await _exercise.RemoveFirstAndLastCharacter(input3);

            //Assert
            result.Should().Be("H");
            result2.Should().Be("ytho");
            result3.Should().Be("avaScrip");
        }

        [TestMethod]
        public async Task ShouldCheckIfItsConsecutive()
        {
            //Arrange
            string input = "PHP";
            string input2 = "PHHP";
            string input3 = "PHPP";
            string input4 = "PPHP";

            //Act
            bool result = await _exercise.CheckIfItsConsecutive(input);
            bool result2 = await _exercise.CheckIfItsConsecutive(input2);
            bool result3 = await _exercise.CheckIfItsConsecutive(input3);
            bool result4 = await _exercise.CheckIfItsConsecutive(input4);

            //Assert
            result.Should().Be(false);
            result2.Should().Be(true);
            result3.Should().Be(true);
            result4.Should().Be(true);
        }

        [TestMethod]
        public async Task ShouldHaveAWholeNumberAverage()
        {
            //Arrange
            int[] array = { 1, 2, 3, 5, 4, 2, 3, 4 }; //Average = 12
            int[] array2 = { 2, 4, 2, 6, 4, 8 }; //Average = 

            //Act
            bool result = await _exercise.WholeNumberAverage(array);
            bool result2 = await _exercise.WholeNumberAverage(array2);

            //Assert
            result.Should().Be(true);
            result2.Should().Be(false);
        }

        [TestMethod]
        public async Task ShouldOrderByAlphabetical()
        {
            //Arrange
            string input = "PHP";
            string input2 = "javascript";
            string input3 = "python";

            //Act
            string result = await _exercise.OrderByAlphabetical(input);
            string result2 = await _exercise.OrderByAlphabetical(input2);
            string result3 = await _exercise.OrderByAlphabetical(input3);

            //Assert
            result.Should().Be("HPP");
            result2.Should().Be("aacijprstv");
            result3.Should().Be("hnopty");
        }

        [TestMethod]
        public async Task ShouldCheckIfLengthIsOddOrEven()
        {
            //Arrange
            string input = "PHP";
            string input2 = "JavaScript";
            string input3 = "Python";

            //Act
            string result = await _exercise.OddOrEvenLength(input);
            string result2 = await _exercise.OddOrEvenLength(input2);
            string result3 = await _exercise.OddOrEvenLength(input3);

            //Assert
            result.Should().Be("Odd Length");
            result2.Should().Be("Even Length");
            result3.Should().Be("Even Length");
        }

        [TestMethod]
        public async Task ShouldFindTheOddNumber()
        {
            //Arrange
            int position = 1;
            int position2 = 2;
            int position3 = 4;
            int position4 = 100;

            //Act
            int result = await _exercise.OddNumberByPosition(position);
            int result2 = await _exercise.OddNumberByPosition(position2);
            int result3 = await _exercise.OddNumberByPosition(position3);
            int result4 = await _exercise.OddNumberByPosition(position4);

            //Assert
            result.Should().Be(1);
            result2.Should().Be(3);
            result3.Should().Be(7);
            result4.Should().Be(199);
        }

        [TestMethod]
        public async Task ShouldFindTheAsciiValueOfACharacter()
        {
            //Arrange
            char input = '1';
            char input2 = 'A';
            char input3 = 'a';
            char input4 = '#';

            //Act
            int result = await _exercise.AsciiNumber(input);
            int result2 = await _exercise.AsciiNumber(input2);
            int result3 = await _exercise.AsciiNumber(input3);
            int result4 = await _exercise.AsciiNumber(input4);

            //Assert
            result.Should().Be(49);
            result2.Should().Be(65);
            result3.Should().Be(97);
            result4.Should().Be(35);
        }

        [TestMethod]
        public async Task ShouldCheckIfItsSingularOrPlural()
        {
            //Arrange
            string input = "Exercise";
            string input2 = "Exercises";
            string input3 = "Book";
            string input4 = "Books";

            //Act
            bool result = await _exercise.IsPlural(input);
            bool result2 = await _exercise.IsPlural(input2);
            bool result3 = await _exercise.IsPlural(input3);
            bool result4 = await _exercise.IsPlural(input4);

            //Assert
            result.Should().Be(false);
            result2.Should().Be(true);
            result3.Should().Be(false);
            result4.Should().Be(true);
        }

        [TestMethod]
        public async Task ShouldCalculateTheSumOfTheSquaresOfAnArray()
        {
            //Arrange
            int[] array = { 1, 2, 3 };
            int[] array2 = { -2, 0, 3, 4 };

            //Act
            double result = await _exercise.SumOfSqr(array);
            double result2 = await _exercise.SumOfSqr(array2);

            //Assert
            result.Should().Be(14);
            result2.Should().Be(29);
        }

        [TestMethod]
        public async Task ShouldReturnTypeName()
        {
            //Arrange
            object[] array = new object[5];
            array[0] = 25;
            array[1] = "Anna";
            array[2] = false;
            array[3] = DateTime.Now;
            array[4] = 112.22;

            //Act
            string[] result = await _exercise.GetTypeOfArray(array);

            //Assert
            result[0].Should().Be("Int32");
            result[1].Should().Be("String");
            result[2].Should().Be("Boolean");
            result[3].Should().Be("DateTime");
            result[4].Should().Be("Double");
        }

        [TestMethod]
        public async Task ShouldCheckSwappedTwoDigitNumber()
        {
            //Arrange
            int input = 25;
            int input2 = 64;

            //Act
            bool result = await _exercise.SwapAndCheckTheLargest(input);
            bool result2 = await _exercise.SwapAndCheckTheLargest(input2);

            //Assert
            result.Should().Be(true);
            result2.Should().Be(false);
        }

        [TestMethod]
        public async Task ShouldRemoveNonLetters()
        {
            //Arrange
            string input = "Py@th12on";
            string input2 = "Python 3.0";
            string input3 = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";

            //Act
            string result = await _exercise.NonLetterRemoval(input);
            string result2 = await _exercise.NonLetterRemoval(input2);
            string result3 = await _exercise.NonLetterRemoval(input3);

            //Assert
            result.Should().Be("Python");
            result2.Should().Be("Python");
            result3.Should().Be("sdfdsjlljdslfnoswjeusdfds");
        }

        [TestMethod]
        public async Task ShouldRemoveVowelFromString()
        {
            //Arrange
            string input = "Python";
            string input2 = "C Sharp";
            string input3 = "JavaScript";

            //Act
            string result = await _exercise.VowelRemover(input);
            string result2 = await _exercise.VowelRemover(input2);
            string result3 = await _exercise.VowelRemover(input3);

            //Assert
            result.Should().Be("Pythn");
            result2.Should().Be("C Shrp");
            result3.Should().Be("JvScrpt");
        }

        [TestMethod]
        public async Task ShouldGetTheIndexOfLowerCaseCharacters()
        {
            //Arrange
            string input = "Python";
            string input2 = "JavaScript";

            //Act
            int[] result = await _exercise.LowerCaseIndexer(input);
            int[] result2 = await _exercise.LowerCaseIndexer(input2);

            //Assert
            result.Should().BeEquivalentTo(new int[] { 1, 2, 3, 4, 5 });
            result2.Should().BeEquivalentTo(new int[] { 1, 2, 3, 5, 6, 7, 8, 9 });
        }

        [TestMethod]
        public async Task ShouldSumCumulativeInArray()
        {
            //Arrange
            double[] array = { 1, 3, 4, 5, 6, 7 };
            double[] array2 = { 1.2, -3, 4.1, 6, -5.47 };

            //Act
            double[] result = await _exercise.CumulativeSum(array);
            double[] result2 = await _exercise.CumulativeSum(array2);

            //Assert
            result.Should().BeEquivalentTo(new double[] { 1, 4, 8, 13, 19, 26 });
            result2.Should().BeEquivalentTo(new double[] { 1.2, -1.8, 2.3, 8.3, 2.83 });
        }

        [TestMethod]
        public async Task ShouldCountLettersAndNumbers()
        {
            //Arrange
            string input = "Python 3.0";
            string input2 = "dsfkaso230samdm2423sa";

            //Act
            string result = await _exercise.LetterAndNumberCount(input);
            string result2 = await _exercise.LetterAndNumberCount(input2);

            //Assert
            result.Should().Be("6 letters and 2 digits");
            result2.Should().Be("14 letters and 7 digits");
        }

        [TestMethod]
        public async Task ShouldSumOfInteriorAnglesOfAPoligon()
        {
            //Arrange
            int input = 6;

            //Act
            int result = await _exercise.SumOfInteriorAnglesOfAPoligon(input);

            //Assert
            result.Should().Be(720);
        }

        [TestMethod]
        public async Task ShouldCountPositivesAndNegativesInArray()
        {
            //Arrange
            double[] array = { 10, -11, 12, -13, 14, -18, 19, -20 };
            double[] array2 = { -4, -3, -2, 0, 3, 5, 6, 2, 6 };

            //Act
            string result = await _exercise.PositiveAndNegativeArray(array);
            string result2 = await _exercise.PositiveAndNegativeArray(array2);

            //Assert
            result.Should().Be("4 positives and 4 negatives");
            result2.Should().Be("5 positives and 3 negatives");
        }

        [TestMethod]
        public async Task ShouldCountZerosAndOnesInBinary()
        {
            //Arrange
            int input = 12;
            int input2 = 1234;

            //Act
            string result = await _exercise.BinaryCounter(input);
            string result2 = await _exercise.BinaryCounter(input2);

            //Assert
            result.Should().Be("2 zeros and 2 ones");
            result2.Should().Be("6 zeros and 5 ones");
        }

        [TestMethod]
        public async Task ShouldExtractNonIntegersFromArray()
        {
            //Arrange
            object[] mixedArray = new object[6];
            mixedArray[0] = 25;
            mixedArray[1] = "Anna";
            mixedArray[2] = false;
            mixedArray[3] = System.DateTime.Now;
            mixedArray[4] = -112;
            mixedArray[5] = -34.67;

            //Act
            int[] result = await _exercise.IntegerExtractor(mixedArray);

            //Assert
            result.Should().BeEquivalentTo(new int[] { 25, -112 });
        }

        [TestMethod]
        public async Task ShouldFindNextPrimeNumber()
        {
            //Arrange
            int input = 120;
            int input2 = 321;
            int input3 = 43;
            int input4 = 4433;

            //Act
            int result = await _exercise.NextPrime(input);
            int result2 = await _exercise.NextPrime(input2);
            int result3 = await _exercise.NextPrime(input3);
            int result4 = await _exercise.NextPrime(input4);

            //Assert
            result.Should().Be(127);
            result2.Should().Be(331);
            result3.Should().Be(43);
            result4.Should().Be(4441);
        }

        [TestMethod]
        public async Task ShouldFindLongestCommonPrefix()
        {
            //Arrange
            string[] input = { "Padas", "Packed", "Pace", "Pacha" };
            string[] input2 = { "Jacket", "Joint", "Junky", "Jet" };
            string[] input3 = { "Bort", "Whang", "Yarder", "Zoonic" };

            //Act
            string result = await _exercise.LongestCommonPrefix(input);
            string result2 = await _exercise.LongestCommonPrefix(input2);
            string result3 = await _exercise.LongestCommonPrefix(input3);

            //Assert
            result.Should().Be("Pa");
            result2.Should().Be("J");
            result3.Should().Be("");
        }

        [TestMethod]
        public async Task ShouldCheckIfBracketsIsClosed()
        {
            //Arrange
            string input = " \"<>\"";
            string input2 = "\"<>()[]{}\"";
            string input3 = "\"(<>\"";
            string input4 = "[<>()[]{}]";
            string input5 = "(]";

            //Act
            bool result = await _exercise.CheckIfBracketsIsClosed(input);
            bool result2 = await _exercise.CheckIfBracketsIsClosed(input2);
            bool result3 = await _exercise.CheckIfBracketsIsClosed(input3);
            bool result4 = await _exercise.CheckIfBracketsIsClosed(input4);
            bool result5 = await _exercise.CheckIfBracketsIsClosed(input5);

            //Assert
            result.Should().Be(true);
            result2.Should().Be(true);
            result3.Should().Be(false);
            result4.Should().Be(true);
            result5.Should().BeFalse();
        }

        [TestMethod]
        public async Task ShouldCheckIfAllCharactersAreSame()
        {
            //Arrange
            string input = "aaa";
            string input2 = "abcd";
            string input3 = "3333";
            string input4 = "2342342";

            //Act
            bool result = await _exercise.CheckIfCharacterAreSame(input);
            bool result2 = await _exercise.CheckIfCharacterAreSame(input2);
            bool result3 = await _exercise.CheckIfCharacterAreSame(input3);
            bool result4 = await _exercise.CheckIfCharacterAreSame(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
        }

        [TestMethod]
        public async Task ShouldCheckIfItsOnlyNumbers()
        {
            //Arrange
            string input = "123";
            string input2 = "123.33";
            string input3 = "33/33";
            string input4 = "234234d2";

            //Act
            bool result = await _exercise.CheckIfItsOnlyNumbers(input);
            bool result2 = await _exercise.CheckIfItsOnlyNumbers(input2);
            bool result3 = await _exercise.CheckIfItsOnlyNumbers(input3);
            bool result4 = await _exercise.CheckIfItsOnlyNumbers(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeFalse();
            result4.Should().BeFalse();
        }

        [TestMethod]
        public async Task ShouldShowPrimeNumbersByOrder()
        {
            //Arrange
            int input = 10;

            //Act
            int[] result = await _exercise.PrimeList(input);

            //Assert
            result.Should().BeEquivalentTo(new int[]{2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31});
        }

        [TestMethod]
        public async Task ShouldCheckEqualityOfValueAndType()
        {
            //Arrange
            object[] input = { "AAA", "BBB" };
            object[] input2 = { true, false };
            object[] input3 = { true, "true" };
            object[] input4 = { 10, 10 };
            object[] input5 = { 10, 10.0 };
            object[] input6 = { 10, "10"};

            //Act
            bool result = await _exercise.IsSameTypeAndValue(input);
            bool result2 = await _exercise.IsSameTypeAndValue(input2);
            bool result3 = await _exercise.IsSameTypeAndValue(input3);
            bool result4 = await _exercise.IsSameTypeAndValue(input4);
            bool result5 = await _exercise.IsSameTypeAndValue(input5);
            bool result6 = await _exercise.IsSameTypeAndValue(input6);

            //Assert
            result.Should().BeFalse();
            result2.Should().BeFalse();
            result3.Should().BeFalse();
            result4.Should().BeTrue();
            result5.Should().BeFalse();
            result6.Should().BeFalse();
        }

        [TestMethod]
        public async Task ShouldCreateIdentityMatrix()
        {
            //Arrange
            int input = 3;

            //Act
            string result = await _exercise.IdentityMatrixCreator(input);

            //Assert
            result.Should().Be("1 0 0\r\n0 1 0\r\n0 0 1");
        }

        [TestMethod]
        public async Task ShouldSortCharactersInAString()
        {
            //Arrange
            string input = "AAAbfed231";
            string input2 = " ";
            string input3 = "Python";
            string input4 = "W3resource";

            //Act
            string result = await _exercise.SortString(input);
            string result2 = await _exercise.SortString(input2);
            string result3 = await _exercise.SortString(input3);
            string result4 = await _exercise.SortString(input4);

            //Assert
            result.Should().Be("AAAbdef123");
            result2.Should().Be("Blank String");
            result3.Should().Be("hnoPty");
            result4.Should().Be("ceeorrsuW3");
        }

        [TestMethod]
        public async Task ShouldCompareEqualityOfThreeIntegers()
        {
            //Arrange
            int[] input = { 1, 2, 3 };
            int[] input2 = { 1, 3, 3};
            int[] input3 = { 3, 3, 3 };

            //Act
            int result = await _exercise.EqualsBetweenThree(input);
            int result2 = await _exercise.EqualsBetweenThree(input2);
            int result3 = await _exercise.EqualsBetweenThree(input3);

            //Assert
            result.Should().Be(0);
            result2.Should().Be(2);
            result3.Should().Be(3);
        }
    }
}
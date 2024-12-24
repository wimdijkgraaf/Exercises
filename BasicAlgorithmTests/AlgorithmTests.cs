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
            result3.Should().Be(12);
        }

        [TestMethod]
        public async Task ShouldReturnAbsoluteDifferenceWithTripleForGreater()
        {
            //Arrange
            int input = 53;
            int input2 = 30;
            int input3 = 51;

            //Act
            int result = await _exercise.AbsoluteDiferenceOrTriple(input);
            int result2 = await _exercise.AbsoluteDiferenceOrTriple(input2);
            int result3 = await _exercise.AbsoluteDiferenceOrTriple(input3);

            //Assert
            result.Should().Be(6);
            result2.Should().Be(21);
            result3.Should().Be(0);
        }

        [TestMethod]
        public async Task ShouldCheckIfIts30OrSum30()
        {
            //Arrange
            int[] input = { 30, 0 };
            int[] input2 = { 25, 5 };
            int[] input3 = { 20, 30 };
            int[] input4 = { 20, 25 };

            //Act
            bool result = await _exercise.Is30OrSum30(input);
            bool result2 = await _exercise.Is30OrSum30(input2);
            bool result3 = await _exercise.Is30OrSum30(input3);
            bool result4 = await _exercise.Is30OrSum30(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
        }

        [TestMethod]
        public async Task ShouldCheckIfItsWithin10Of100Or200()
        {
            //Arrange
            int input = 103;
            int input2 = 90;
            int input3 = 89;
            int input4 = 205;

            //Act
            bool result = await _exercise.IsWithin10Of100Or200(input);
            bool result2 = await _exercise.IsWithin10Of100Or200(input2);
            bool result3 = await _exercise.IsWithin10Of100Or200(input3);
            bool result4 = await _exercise.IsWithin10Of100Or200(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeFalse();
            result4.Should().BeTrue();
        }

        [TestMethod]
        public async Task ShouldAddIfAtTheBeggining()
        {
            //Arrange
            string input = "if else";
            string input2 = "else";

            //Act
            string result = await _exercise.AddIf(input);
            string result2 = await _exercise.AddIf(input2);

            //Assert
            result.Should().Be("if else");
            result2.Should().Be("if else");
        }

        [TestMethod]
        public async Task ShouldRemoveCharacterAtPosition()
        {
            //Arrange
            string input = "Python";
            int position = 1;
            int position2 = 0;
            int position3 = 4;

            //Act
            string result = await _exercise.RemoveAtPosition(input, position);
            string result2 = await _exercise.RemoveAtPosition(input, position2);
            string result3 = await _exercise.RemoveAtPosition(input, position3);

            //Assert
            result.Should().Be("Pthon");
            result2.Should().Be("ython");
            result3.Should().Be("Pythn");
        }

        [TestMethod]
        public async Task ShouldExchangeFirstAndLastCharacter()
        {
            //Arrange
            string input = "abcd";
            string input2 = "a";
            string input3 = "xy";

            //Act
            string result = await _exercise.ExchangeFirstAndLast(input);
            string result2 = await _exercise.ExchangeFirstAndLast(input2);
            string result3 = await _exercise.ExchangeFirstAndLast(input3);

            //Assert
            result.Should().Be("dbca");
            result2.Should().Be("a");
            result3.Should().Be("yx");
        }

        [TestMethod]
        public async Task ShouldGenerateFourCopiesOfFirstCharacter()
        {
            //Arrange
            string input = "C Sharp";
            string input2 = "JS";
            string input3 = "a";

            //Act
            string result = await _exercise.FourCoppiesOfFirstCharacter(input);
            string result2 = await _exercise.FourCoppiesOfFirstCharacter(input2);
            string result3 = await _exercise.FourCoppiesOfFirstCharacter(input3);

            //Assert
            result.Should().Be("C C C C");
            result2.Should().Be("JSJSJSJS");
            result3.Should().Be("a");
        }

        [TestMethod]
        public async Task ShouldAddLastCharacterAtFrontAndBack()
        {
            //Arrange
            string input = "Red";
            string input2 = "Green";
            string input3 = "1";

            //Act
            string result = await _exercise.LastCharAtFrontAndBack(input);
            string result2 = await _exercise.LastCharAtFrontAndBack(input2);
            string result3 = await _exercise.LastCharAtFrontAndBack(input3);

            //Assert
            result.Should().Be("dRedd");
            result2.Should().Be("nGreenn");
            result3.Should().Be("111");
        }

        [TestMethod]
        public async Task ShouldBeMultipleOf3Or7()
        {
            //Arrange
            int input = 3;
            int input2 = 14;
            int input3 = 12;
            int input4 = 37;

            //Act
            bool result = await _exercise.IsMultipleOf3Or7(input);
            bool result2 = await _exercise.IsMultipleOf3Or7(input2);
            bool result3 = await _exercise.IsMultipleOf3Or7(input3);
            bool result4 = await _exercise.IsMultipleOf3Or7(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
        }

        [TestMethod]
        public async Task ShouldAddFirstThreeCharactersAtFrontAndBack()
        {
            //Arrange
            string input = "Python";
            string input2 = "JS";
            string input3 = "Code";

            //Act
            string result = await _exercise.AddFirstThreeCharAtFrontAndBack(input);
            string result2 = await _exercise.AddFirstThreeCharAtFrontAndBack(input2);
            string result3 = await _exercise.AddFirstThreeCharAtFrontAndBack(input3);

            //Assert
            result.Should().Be("PytPythonPyt");
            result2.Should().Be("JSJSJS");
            result3.Should().Be("CodCodeCod");
        }

        [TestMethod]
        public async Task ShouldCheckIfItStartsWithCSharp()
        {
            //Arrange
            string input = "C# Sharp";
            string input2 = "C#";
            string input3 = "C++";

            //Act
            bool result = await _exercise.StartsWithCSharp(input);
            bool result2 = await _exercise.StartsWithCSharp(input2);
            bool result3 = await _exercise.StartsWithCSharp(input3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeFalse();
        }

        [TestMethod]
        public async Task ShouldTemperatureBeLessThan0AndMoreThan100()
        {
            //Arrange
            int[] input = { 120, -1 };
            int[] input2 = { -1, 120 };
            int[] input3 = { 2, 120 };

            //Act
            bool result = await _exercise.CheckTemperatureLessThan0AndMoreThan100(input);
            bool result2 = await _exercise.CheckTemperatureLessThan0AndMoreThan100(input2);
            bool result3 = await _exercise.CheckTemperatureLessThan0AndMoreThan100(input3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeFalse();
        }

        [TestMethod]
        public async Task ShouldCheckIfOneIntIsBetween100And200()
        {
            //Arrange
            int[] input = { 100, 199 };
            int[] input2 = { 250, 300 };
            int[] input3 = { 105, 190 };

            //Act
            bool result = await _exercise.IsBetween100And200(input);
            bool result2 = await _exercise.IsBetween100And200(input2);
            bool result3 = await _exercise.IsBetween100And200(input3);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
        }

        [TestMethod]
        public async Task ShouldCheckIfItsInRange20To50()
        {
            //Arrange
            int[] input = { 11, 20, 12 };
            int[] input2 = { 30, 30, 17 };
            int[] input3 = { 25, 35, 50 };
            int[] input4 = { 15, 12, 8 };

            //Act
            bool result = await _exercise.IsInRange20To50(input);
            bool result2 = await _exercise.IsInRange20To50(input2);
            bool result3 = await _exercise.IsInRange20To50(input3);
            bool result4 = await _exercise.IsInRange20To50(input4);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeTrue();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
        }

        [TestMethod]
        public async Task ShouldRemoveYTAtIndex1()
        {
            //Arrange
            string input = "Python";
            string input2 = "ytade";
            string input3 = "jsues";

            //Act
            string result = await _exercise.RemoveYTAtIndex1(input);
            string result2 = await _exercise.RemoveYTAtIndex1(input2);
            string result3 = await _exercise.RemoveYTAtIndex1(input3);

            //Assert
            result.Should().Be("Phon");
            result2.Should().Be("ytade");
            result3.Should().Be("jsues");
        }

        [TestMethod]
        public async Task ShouldFindLargetsInt()
        {
            //Arrange
            int[] input = { 1, 2, 3 };
            int[] input2 = { 1, 3, 2 };
            int[] input3 = { 1, 1, 1 };
            int[] input4 = { 1, 2, 2 };

            //Act
            int result = await _exercise.LargestInt(input);
            int result2 = await _exercise.LargestInt(input2);
            int result3 = await _exercise.LargestInt(input3);
            int result4 = await _exercise.LargestInt(input4);

            //Assert
            result.Should().Be(3);
            result2.Should().Be(3);
            result3.Should().Be(1);
            result4.Should().Be(2);
        }

        [TestMethod]
        public async Task ShouldShowClosestTo100()
        {
            //Arrange
            int[] input = { 78, 95 };
            int[] input2 = { 95, 95 };
            int[] input3 = { 99, 70 };

            //Act
            int result = await _exercise.IsClosestTo100(input);
            int result2 = await _exercise.IsClosestTo100(input2);
            int result3 = await _exercise.IsClosestTo100(input3);

            //Assert
            result.Should().Be(95);
            result2.Should().Be(0);
            result3.Should().Be(99);
        }

        [TestMethod]
        public async Task ShouldCheckIfBothIntsAreBetween40And50And60()
        {
            //Arrange
            int[] input = { 78, 95 };
            int[] input2 = { 25, 35 };
            int[] input3 = { 40, 50 };
            int[] input4 = { 55, 60 };

            //Act
            bool result = await _exercise.IsBetween40_50Or50_60(input);
            bool result2 = await _exercise.IsBetween40_50Or50_60(input2);
            bool result3 = await _exercise.IsBetween40_50Or50_60(input3);
            bool result4 = await _exercise.IsBetween40_50Or50_60(input4);

            //Assert
            result.Should().BeFalse();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
            result4.Should().BeTrue();
        }

        [TestMethod]
        public async Task ShouldFindLargestBetween20_30()
        {
            //Arrange
            int[] input = { 78, 95 };
            int[] input2 = { 20, 30 };
            int[] input3 = { 21, 25 };
            int[] input4 = { 28, 28 };

            //Act
            int result = await _exercise.IsLargestBetween20_30(input);
            int result2 = await _exercise.IsLargestBetween20_30(input2);
            int result3 = await _exercise.IsLargestBetween20_30(input3);
            int result4 = await _exercise.IsLargestBetween20_30(input4);

            //Assert
            result.Should().Be(0);
            result2.Should().Be(30);
            result3.Should().Be(25);
            result4.Should().Be(28);
        }

        [TestMethod]
        public async Task ShouldHave2Or4Zs()
        {
            //Arrange
            string input = "frizz";
            string input2 = "zane";
            string input3 = "Zazz";
            string input4 = "false";
            string input5 = "zzzz";
            string input6 = "ZZZZ";

            //Act
            bool result = await _exercise.HasBetween2Or4Zs(input);
            bool result2 = await _exercise.HasBetween2Or4Zs(input2);
            bool result3 = await _exercise.HasBetween2Or4Zs(input3);
            bool result4 = await _exercise.HasBetween2Or4Zs(input4);
            bool result5 = await _exercise.HasBetween2Or4Zs(input5);
            bool result6 = await _exercise.HasBetween2Or4Zs(input6);

            //Assert
            result.Should().BeTrue();
            result2.Should().BeFalse();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
            result5.Should().BeTrue();
            result6.Should().BeTrue();
        }

        [TestMethod]
        public async Task ShouldHaveSameLastDigit()
        {
            //Arrange
            int[] input = { 123, 456 };
            int[] input2 = { 12, 512 };
            int[] input3 = { 7, 87 };
            int[] input4 = { 12, 45 };

            //Act
            bool result = await _exercise.HasSameLastDigit(input);
            bool result2 = await _exercise.HasSameLastDigit(input2);
            bool result3 = await _exercise.HasSameLastDigit(input3);
            bool result4 = await _exercise.HasSameLastDigit(input4);

            //Assert
            result.Should().BeFalse();
            result2.Should().BeTrue();
            result3.Should().BeTrue();
            result4.Should().BeFalse();
        }

        [TestMethod]
        public async Task ShouldUpperCaseLastThreeCharacters()
        {
            //Arrange
            string input = "Python";
            string input2 = "JavaScript";
            string input3 = "js";
            string input4 = "PHP";

            //Act
            string result = await _exercise.UpperCaseLastThree(input);
            string result2 = await _exercise.UpperCaseLastThree(input2);
            string result3 = await _exercise.UpperCaseLastThree(input3);
            string result4 = await _exercise.UpperCaseLastThree(input4);

            //Assert
            result.Should().Be("PytHON");
            result2.Should().Be("JavaScrIPT");
            result3.Should().Be("JS");
            result4.Should().Be("PHP");
        }

        [TestMethod]
        public async Task ShouldCopyTheStringByNTimes()
        {
            //Arrange
            string input = "JS";
            int repeat = 2;
            int repeat2 = 3;
            int repeat3 = 1;

            //Act
            string result = await _exercise.CopyStringByNTimes(input, repeat);
            string result2 = await _exercise.CopyStringByNTimes(input, repeat2);
            string result3 = await _exercise.CopyStringByNTimes(input, repeat3);

            //Assert
            result.Should().Be("JSJS");
            result2.Should().Be("JSJSJS");
            result3.Should().Be("JS");
        }
    }
}
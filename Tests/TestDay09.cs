using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay09
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "ADVENT";
            Assert.Equal(6, Day09.PartOne(input));
            input = "A(1x5)BC";
            Assert.Equal(7, Day09.PartOne(input));
            input = "(3x3)XYZ";
            Assert.Equal(9, Day09.PartOne(input));
            input = "A(2x2)BCD(2x2)EFG";
            Assert.Equal(11, Day09.PartOne(input));
            input = "(6x1)(1x3)A";
            Assert.Equal(6, Day09.PartOne(input));
            input = "X(8x2)(3x3)ABCY";
            Assert.Equal(18, Day09.PartOne(input));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "ADVENT";
            Assert.Equal(6, Day09.PartTwo(input));
            input = "(3x3)XYZ";
            Assert.Equal(9, Day09.PartTwo(input));
            input = "X(8x2)(3x3)ABCY";
            Assert.Equal(20, Day09.PartTwo(input));
            input = "(27x12)(20x12)(13x14)(7x10)(1x12)A";
            Assert.Equal(241920, Day09.PartTwo(input));
            input = "(25x3)(3x3)ABC(2x3)XY(5x2)PQRSTX(18x9)(3x2)TWO(5x7)SEVEN";
            Assert.Equal(445, Day09.PartTwo(input));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day09.in");
            Assert.Equal(98135, Day09.PartOne(input));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day09.in");
            Assert.Equal(10964557606, Day09.PartTwo(input));
        }
    }
}


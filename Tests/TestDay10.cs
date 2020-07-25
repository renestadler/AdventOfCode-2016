using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay10
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "value 5 goes to bot 2\nbot 2 gives low to bot 1 and high " +
                "to bot 0\nvalue 3 goes to bot 1\nbot 1 gives low to output 1 and high " +
                "to bot 0\nbot 0 gives low to output 2 and high to output 0\nvalue 2 " +
                "goes to bot 2";
            Assert.Equal(0, Day10.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "value 5 goes to bot 2\nbot 2 gives low to bot 1 and high " +
                "to bot 0\nvalue 3 goes to bot 1\nbot 1 gives low to output 1 and high " +
                "to bot 0\nbot 0 gives low to output 2 and high to output 0\nvalue 2 " +
                "goes to bot 2";
            Assert.Equal(0, Day10.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day10.in");
            Assert.Equal(116, Day10.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day10.in");
            Assert.Equal(23903, Day10.PartTwo(input.Split("\r\n")));
        }
    }
}


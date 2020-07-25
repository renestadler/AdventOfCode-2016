using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay04
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "aaaaa-bbb-z-y-x-123[abxyz]\na-b-c-d-e-f-g-h-987[abcde]\nnot-a-real-room-404[oarel]\ntotally-real-room-200[decoy]";
            Assert.Equal(1514, Day04.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "qzmt-zixmtkozy-ivhz-343[zimth]\nqzmt-zixmtkozy-ivhz-343[zimth]";
            Assert.Equal(0, Day04.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day04.in");
            Assert.Equal(361724, Day04.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day04.in");
            Assert.Equal(482, Day04.PartTwo(input.Split("\r\n")));
        }
    }
}

using AOC_2016;
using Xunit;

namespace Tests
{
    public class TestDay06
    {
        [Fact]
        public void TestPartOneSample()
        {
            string input = "eedadn\ndrvtee\neandsr\nraavrd\natevrs\ntsrnev\nsdttsa\n" +
                "rasrtv\nnssdts\nntnada\nsvetve\ntesnvt\nvntsnd\nvrdear\ndvrsen\nenarar";
            Assert.Equal("easter", Day06.PartOne(input.Split("\n")));
        }

        [Fact]
        public void TestPartTwoSample()
        {
            string input = "eedadn\ndrvtee\neandsr\nraavrd\natevrs\ntsrnev\nsdttsa\n" +
                "rasrtv\nnssdts\nntnada\nsvetve\ntesnvt\nvntsnd\nvrdear\ndvrsen\nenarar";
            Assert.Equal("advent", Day06.PartTwo(input.Split("\n")));
        }

        [Fact]
        public void TestPartOneInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day06.in");
            Assert.Equal("wkbvmikb", Day06.PartOne(input.Split("\r\n")));
        }

        [Fact]
        public void TestPartTwoInput()
        {
            string input = System.IO.File.ReadAllText("./Inputs/Day06.in");
            Assert.Equal("evakwaga", Day06.PartTwo(input.Split("\r\n")));
        }
    }
}

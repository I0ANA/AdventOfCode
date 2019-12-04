using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2018;

namespace AdventOfCode2018.Tests
{
    [TestClass]
    public class Day1
    {
        [DataTestMethod]
        [DataRow(1,1,1,3)]
        [DataRow(1,1,-2,0)]
        [DataRow(-1,-2,-3,-6)]
        public void Sum_3_positive(int a, int b, int c, int result)
        {

            var calibrator = new FrequencyCalibrator();
            int frequency = calibrator.Calibrate(new int[]{ a, b, c});

            Assert.AreEqual(result, frequency);
        }

        [TestMethod]
        public void TestPlusString()
        {
            const int expectedResult = 2;
            var plusString = "+2";

            var result = int.Parse(plusString);

            Assert.AreEqual(expectedResult, result);
        }
    }
}

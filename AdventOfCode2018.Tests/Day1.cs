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
            int location = calibrator.GetLocation(new int[]{ a, b, c});

            Assert.AreEqual(result, location);
        }

        [DataTestMethod]
        [DataRow(0, new int[] { 1, -1 })]
        [DataRow(2, new int[] { 1, -2, 3, 1 })]
        [DataRow(10, new int[] { 3, 3, 4, -2, -4 })]
        [DataRow(14, new int[] { 7, 7, -2, -7, -4 })]
        [DataRow(5, new int[] { -6, 3, 8, 5, -6 })]
        public void FirstFrequencyTwice(int result, params int[] frequenciesChanges)
        {
            var calibrator = new FrequencyCalibrator();
            var firstFrequencyTwice = calibrator.Calibrate(frequenciesChanges);

            Assert.AreEqual(result, firstFrequencyTwice);
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

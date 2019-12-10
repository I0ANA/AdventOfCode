using AdventOfCode.Core.Enums;
using AdventOfCode2019.Main.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2019.Tests
{
    [TestClass]
    public class Day2_IntcodeTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1,    9, 10,  3, 2, 3, 11, 0, 99, 30, 40, 50 }, new int[] { 3500, 9, 10, 70, 2, 3, 11, 0, 99, 30, 40, 50 })]
        [DataRow(new int[] { 1, 0, 0, 0, 99 }, new int[] { 2, 0, 0, 0, 99 })]
        [DataRow(new int[] { 2, 3, 0, 3, 99 }, new int[] { 2, 3, 0, 6, 99 })]
        [DataRow(new int[] { 2, 4, 4, 5, 99, 0 }, new int[] { 2, 4, 4, 5, 99, 9801 })]
        [DataRow(new int[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 }, new int[] { 30, 1, 1, 4, 2, 5, 6, 0, 99})]
        public void Intcode_ProcessOpcodes(int [] source, int [] expectedResult)
        {
            //
            var intcodeProcessor = new IntcodeProcessor();

            //Act
            var result = intcodeProcessor.ProcessOpcodes(source);

            //Assert
            CollectionAssert.AreEqual(result, expectedResult);
        }
    }
}

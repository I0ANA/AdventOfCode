using AdventOfCode.Core.Enums;
using AdventOfCode.Core.Services;
using AdventOfCode2019.Main.Services;
using Microsoft.Extensions.FileProviders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            //Arrange
            var intcodeProcessor = new IntcodeProcessor();

            //Act
            var result = intcodeProcessor.ProcessOpcodes(source);

            //Assert
            CollectionAssert.AreEqual(result, expectedResult);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 0, 0, 4, 99, 5, 6, 0, 99 }, new int[] {1, 1, 30 })]
        public void Intcode_FindInputsThatProduce(int[] source, int[] expected)
        {
            //Arrange
            var intcodeProcessor = new IntcodeProcessor();

            //Act
            var result = intcodeProcessor.FindInputsThatProduce(expected[2], source, 0, 1);

            //Assert
            Assert.AreEqual(expected[0], result.Item1);
            Assert.AreEqual(expected[1], result.Item2);
            Assert.AreEqual(100 * expected[0] + expected[1], result.Item3);
        }
    }
}

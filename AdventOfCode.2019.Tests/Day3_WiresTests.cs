using System.ComponentModel.DataAnnotations;
using AdventOfCode2019.Main.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2019.Tests
{
    [TestClass]
    public class Day3_WiresTests
    {
        [DataTestMethod]
        [DataRow("R8,U5,L5,D3", "U7,R6,D4,L4", 6)]
        [DataRow("R75,D30,R83,U83,L12,D49,R71,U7,L72", "U62,R66,U55,R34,D71,R55,D58,R83", 159)]
        [DataRow("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51", "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7", 135)]
        public void WiresSystem_FindManhattanDistanceFromTheCentralPortToTheClosestIntersection(string pathWire1, string pathWire2, int distanceToTheClosesIntersectionPoint)
        {
            var wiresSystem = new WiresSystem();

            int result = wiresSystem.FindManhattanDistanceFromTheCentralPortToTheClosestIntersection(pathWire1, pathWire2);
            
            Assert.AreEqual(result, distanceToTheClosesIntersectionPoint);
        }
    }
}
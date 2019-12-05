using AdventOfCode2019.Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2019.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(12, 2),
        DataRow(14, 2),
        DataRow(1969, 654),
        DataRow(100756, 33583)]
        public void GetRequiredFuel(int mass, int expectedRequiredFuel)
        {
            var engine = new ModuleEngine();
            var fuel = engine.GetRequiredFuel(mass);

            Assert.AreEqual(expectedRequiredFuel, fuel);
        }
    }
}

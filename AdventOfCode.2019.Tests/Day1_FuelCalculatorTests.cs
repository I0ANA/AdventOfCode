using AdventOfCode2019.Main.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2019.Tests
{
    [TestClass]
    public class Day1Tests
    {
        [DataTestMethod]
        [DataRow(12, 2),
        DataRow(14, 2),
        DataRow(1969, 654),
        DataRow(100756, 33583)]
        public void GetRequiredMassFuel(int mass, int expectedRequiredFuel)
        {
            var fuelCalculator = new FuelCalculator();
            var fuel = fuelCalculator.GetRequiredFuelForModuleMass(mass);

            Assert.AreEqual(expectedRequiredFuel, fuel);
        }

        [DataTestMethod]
        [DataRow(14, 2)]
        [DataRow(1969, 966)]
        [DataRow(100756, 50346)]
        public void GetRequiredFuelFuel(int mass, int expectedRequiredFuel)
        {
            var fuelCalculator = new FuelCalculator();

            var requiredFuel = fuelCalculator.GetRequiredFuelForFuelMass(mass);

            Assert.AreEqual(expectedRequiredFuel, requiredFuel);
        }
    }
}

using System;
using System.Linq;

namespace AdventOfCode2019.Main
{
    public class FuelCalculator : IFuelCalculator
    {
        public int GetRequiredFuelForModuleMass(int moduleMass)
        {
            decimal dec = moduleMass / 3;
            return (int)Math.Floor(dec) - 2;
        }

        public int GetRequiredFuelForModulesMasses(params int[] masses)
        {
            return masses.Sum(GetRequiredFuelForModuleMass);
        }

        public int GetRequiredFuelForFuelMass(int fuelMass)
        {
            if (fuelMass <= 0)
                return 0;

            var currentReqFuel = GetRequiredFuelForModuleMass(fuelMass);

            if (currentReqFuel <= 0)
                return 0;
            
            var totalReqFuel = currentReqFuel + GetRequiredFuelForFuelMass(currentReqFuel);

            return totalReqFuel;
        }

        public int GetRequiredFuelForFuelMasses(params int[] fuelMassed)
        {
            return fuelMassed.Sum(GetRequiredFuelForFuelMass);
        }
    }
}
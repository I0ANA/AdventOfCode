using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode2019.Main
{
    public class FuelCalculator : IFuelCalculator
    {
        public int GetRequiredFuel(int moduleMass)
        {
            decimal dec = moduleMass / 3;
            return (int)Math.Floor(dec) - 2;
        }

        public int ProcessMasses(params int[] masses)
        {
            return masses.Sum(GetRequiredFuel);
        }

        public int GetRequiredFuelFuel(int requiredFuel, int mass)
        {
            if (mass <= 0)
                return 0;

            var currentReqFuel = GetRequiredFuel(mass);

            if (currentReqFuel <= 0)
                return 0;

            var totalReqFuel = requiredFuel + currentReqFuel;

            totalReqFuel += GetRequiredFuelFuel(totalReqFuel, GetRequiredFuel(mass));

            return totalReqFuel;
        }
    }
}
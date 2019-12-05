using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode2019.Main
{
    public class ModuleEngine : IModuleEngine
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
    }
}
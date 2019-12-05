using System;

namespace AdventOfCode2019.Main
{
    public class ModuleEngine
    {
        public int GetRequiredFuel(int moduleMass)
        {
            decimal dec = moduleMass / 3;
            return (int)Math.Floor(dec) - 2;
        }
    }
}
using System;
using System.Linq;

namespace AdventOfCode2018
{
    public class FrequencyCalibrator : IFrequencyCalibrator
    {
        public int Calibrate(int[] frequencies)
        {
            return frequencies.Sum();
        }
    }
}
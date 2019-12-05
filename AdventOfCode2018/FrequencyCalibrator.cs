using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018
{
    public class FrequencyCalibrator : IFrequencyCalibrator
    {
        public int GetLocation(int[] frequencies)
        {
            return frequencies.Sum();
        }

        public int GetLocation(int startLocation, int frequency)
        {
            return startLocation + frequency;
        }

        public int Calibrate(params int[] frequencyChanges)
        {
            var calibrationFrequencies = new List<int>();

            var currentLocation = 0;
            foreach(var frequency in frequencyChanges)
            {
                currentLocation = GetLocation(currentLocation, frequency);
                calibrationFrequencies.Add(currentLocation);
            }

            if (currentLocation == 0)
                return currentLocation;

            var checkCalibrationFrequency = currentLocation;
            while (true)
            {
                foreach (var frequency in frequencyChanges)
                {
                    checkCalibrationFrequency = GetLocation(checkCalibrationFrequency, frequency);

                    if (calibrationFrequencies.Contains(checkCalibrationFrequency))
                        return checkCalibrationFrequency;
                }              
            }
        }
    }
}
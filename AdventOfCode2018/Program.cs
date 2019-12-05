using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2018
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFileProvider physicalProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());

            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IFrequencyCalibrator, FrequencyCalibrator>()
                .AddSingleton<IFileImporter, FileImporter>()
                .AddSingleton<IFileProvider>(physicalProvider)
                .BuildServiceProvider();

            //do the actual work here
            var fileImporter = serviceProvider.GetService<IFileImporter>();
            var frequencyCahnges = fileImporter.ReadFile("2018_Day1.txt");

            var calibrator = serviceProvider.GetService<IFrequencyCalibrator>();

            var calibration = calibrator.GetLocation(frequencyCahnges.ToArray());

            Console.WriteLine(calibration);

            Console.ReadLine();
        }
    }
}

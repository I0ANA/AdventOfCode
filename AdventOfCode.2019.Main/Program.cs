using System;
using System.IO;
using System.Linq;
using AdventOfCode.Core.Interfaces;
using AdventOfCode.Core.Services;
using AdventOfCode2019.Main.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace AdventOfCode2019.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileProvider physicalProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());

            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IFuelCalculator, FuelCalculator>()
                .AddSingleton<IIntcodeProcessor, IntcodeProcessor>()
                .AddSingleton<IFileImporter, FileImporter>()
                .AddSingleton<IFileProvider>(physicalProvider)
                .BuildServiceProvider();

            //do the actual work here
            var fileImporter = serviceProvider.GetService<IFileImporter>();

            //Day1
            //var modulesMasses = fileImporter.ReadFile("AdventOfCode2019_Day1.txt");

            //var moduleEngine = serviceProvider.GetService<IFuelCalculator>();

            //var fuelRequiredForModuleMasses = moduleEngine.GetRequiredFuelForModulesMasses(modulesMasses.ToArray());
            //var fuelRequiredForFuelMasses = moduleEngine.GetRequiredFuelForFuelMasses(modulesMasses.ToArray());

            //Console.WriteLine("fuelRequiredForModuleMasses " + fuelRequiredForModuleMasses);
            //Console.WriteLine("fuelRequiredForFuelMasses " + fuelRequiredForFuelMasses);

            //Day 2
            var intcodeProcessor = serviceProvider.GetService<IIntcodeProcessor>();

            var intcodeInput = fileImporter.ReadFile("AdventOfCode2019_Day2_Intcode.txt", ",").ToArray();
            intcodeInput[1] = 12;
            intcodeInput[2] =  2;
            var processedIntcode = intcodeProcessor.ProcessOpcodes(intcodeInput);

            Console.WriteLine("value at position 0 after processing " + processedIntcode[0]);
            //value at position 0 after processing 521344 -- not right  --forgot to apply pre-process requirements...
            //4945026

            //Part two
            intcodeInput = fileImporter.ReadFile("AdventOfCode2019_Day2_Intcode.txt", ",").ToArray();
            var result = intcodeProcessor.FindInputsThatProduce(19690720, intcodeInput, 12, 2);

            Console.WriteLine($"Inputs That Produce 19690720 as 100 * noun {result.Item1} + verb {result.Item2} " + result.Item3);
            Console.ReadLine();
        }
    }
}
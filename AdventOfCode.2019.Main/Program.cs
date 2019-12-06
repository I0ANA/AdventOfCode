using System;
using System.IO;
using System.Linq;
using AdventOfCode.Core;
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
                .AddSingleton<IFileImporter, FileImporter>()
                .AddSingleton<IFileProvider>(physicalProvider)
                .BuildServiceProvider();

            //do the actual work here
            var fileImporter = serviceProvider.GetService<IFileImporter>();
            var modulesMasses = fileImporter.ReadFile("AdventOfCode2019_Day1.txt");

            var moduleEngine = serviceProvider.GetService<IFuelCalculator>();

            var fuelRequiredForModuleMasses = moduleEngine.GetRequiredFuelForModulesMasses(modulesMasses.ToArray());

            var fuelRequiredForFuelMasses = moduleEngine.GetRequiredFuelForFuelMasses(modulesMasses.ToArray());


            Console.WriteLine("fuelRequiredForModuleMasses " + fuelRequiredForModuleMasses);
            Console.WriteLine("fuelRequiredForFuelMasses " + fuelRequiredForFuelMasses);

            Console.ReadLine();
        }
    }
}
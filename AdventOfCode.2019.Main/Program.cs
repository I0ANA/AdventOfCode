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
                .AddSingleton< IModuleEngine, ModuleEngine>()
                .AddSingleton<IFileImporter, FileImporter>()
                .AddSingleton<IFileProvider>(physicalProvider)
                .BuildServiceProvider();

            //do the actual work here
            var fileImporter = serviceProvider.GetService<IFileImporter>();
            var modulesMasses = fileImporter.ReadFile("AdventOfCode2019_Day1.txt");

            var moduleEngine = serviceProvider.GetService<IModuleEngine>();

            var totalFuelRequirement = moduleEngine.ProcessMasses(modulesMasses.ToArray());

            Console.WriteLine("totalFuelRequirement " + totalFuelRequirement);
            Console.ReadLine();
        }
    }
}

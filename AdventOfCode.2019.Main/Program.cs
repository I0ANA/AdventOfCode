using System;
using System.IO;
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
                .AddSingleton<IFileProvider>(physicalProvider)
                .BuildServiceProvider();

            //do the actual work here
            var fileImporter = serviceProvider.GetService<IFileImporter>();
            var frequencies = fileImporter.ReadFile("AdventOfCode2019_Day1.txt");

            Console.WriteLine("Hello World!");
        }
    }
}

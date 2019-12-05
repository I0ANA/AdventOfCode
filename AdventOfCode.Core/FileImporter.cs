using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace AdventOfCode.Core
{
    public class FileImporter : IFileImporter
    {
        private readonly IFileProvider _fileProvider;

        public FileImporter(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
        }

        public IEnumerable<int> ReadFile(string path)
        {
            var list = new List<int>();

            using (var stream = _fileProvider.GetFileInfo(path).CreateReadStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        list.Add(int.Parse(line));
                    }
                }
            };

            return list;
        }
    }
}

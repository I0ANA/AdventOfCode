namespace AdventOfCode.Core.Interfaces
{
    public interface IFileImporter
    {
        System.Collections.Generic.IEnumerable<int> ReadFile(string path);
        System.Collections.Generic.IEnumerable<int> ReadFile(string path, string separator);
    }
}
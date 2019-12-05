namespace AdventOfCode.Core
{
    public interface IFileImporter
    {
        System.Collections.Generic.IEnumerable<int> ReadFile(string path);
    }
}
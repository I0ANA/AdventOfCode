namespace AdventOfCode2018
{
    public interface IFileImporter
    {
        System.Collections.Generic.IEnumerable<int> ReadFile(string path);
    }
}
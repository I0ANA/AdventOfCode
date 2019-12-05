namespace AdventOfCode2019.Main
{
    public interface IModuleEngine
    {
        int GetRequiredFuel(int moduleMass);
        int ProcessMasses(params int[] masses);
    }
}
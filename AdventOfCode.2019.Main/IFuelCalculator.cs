namespace AdventOfCode2019.Main
{
    public interface IFuelCalculator
    {
        int GetRequiredFuel(int moduleMass);
        int ProcessMasses(params int[] masses);
    }
}
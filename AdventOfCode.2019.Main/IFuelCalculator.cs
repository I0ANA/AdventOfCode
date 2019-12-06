namespace AdventOfCode2019.Main
{
    public interface IFuelCalculator
    {
        int GetRequiredFuelForModuleMass(int moduleMass);
        int GetRequiredFuelForModulesMasses(params int[] masses);
        int GetRequiredFuelForFuelMass(int fuelMass);
        int GetRequiredFuelForFuelMasses(params int[] fuelMassed);
    }
}
using System;

namespace AdventOfCode2019.Main
{
    public interface IIntcodeProcessor
    {
        Tuple<int, int, int> FindInputsThatProduce(int lookupValue, int[] programInputs, int startAtNoun, int startAtVerb);
        int[] ProcessOpcodes(int[] source);
    }
}
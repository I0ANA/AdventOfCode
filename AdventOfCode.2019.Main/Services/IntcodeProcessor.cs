namespace AdventOfCode2019.Main.Services
{
    public partial class IntcodeProcessor : IIntcodeProcessor
    {
        public int[] ProcessOpcodes(int[] source)
        {
            for (var i = 0; i < source.Length - 1; i += 4)
            {
                if (i + 4 > source.Length -1)
                    return source;

                var opcode = source[i];
                if (opcode == (int)OpcodeEnum.Stop)
                    return source;

                var item1Index = source[i + 1];
                var item2Index = source[i + 2];
                var resultPosition = source[i + 3];
                var resultValue = 0;
                if (opcode == (int)OpcodeEnum.Sum)
                    resultValue = source[item1Index] + source[item2Index];
                else if (opcode == (int)OpcodeEnum.Multiply)
                    resultValue = source[item1Index] * source[item2Index];
                else 
                    throw new System.Exception("Something went wrong. Unexpected opcode");

                source[resultPosition] = resultValue;
            }

            return source;
        }
    }
}
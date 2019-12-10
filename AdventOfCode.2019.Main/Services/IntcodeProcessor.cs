using System;

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
                int resultValue;
                if (opcode == (int)OpcodeEnum.Sum)
                    resultValue = source[item1Index] + source[item2Index];
                else if (opcode == (int)OpcodeEnum.Multiply)
                    resultValue = source[item1Index] * source[item2Index];
                else 
                    throw new Exception("Something went wrong. Unexpected opcode");

                source[resultPosition] = resultValue;
            }

            return source;
        }

        public Tuple<int, int, int> FindInputsThatProduce(int lookupValue, int[] programInputs, int startAtNoun, int startAtVerb)
        {
            //const int looupValue = 19690720;

            var noun = startAtNoun;
            var defaultVerb = startAtVerb;
            var currentResult = 0;
            while (noun < programInputs.Length - 1)
            {
                noun++;
                var verb = defaultVerb;
                while (currentResult <= lookupValue && verb < programInputs.Length)
                {
                    //replace parameters
                    var source = ReplaceParametersInSource(programInputs, noun, verb);

                    //call process
                    var processedIntCode = ProcessOpcodes(source);
                    currentResult = processedIntCode[0];

                    if (currentResult == lookupValue)
                        return new Tuple<int, int, int> (noun, verb, 100 * noun + verb);

                    verb++;
                }
            }

            throw new Exception("Should not get here");
        }

        private int[] ReplaceParametersInSource(int[] source, int parameterPositionOne, int parameterPositionTwo)
        {

            var newSource = new int[source.Length];
            source.CopyTo(newSource, 0);

            newSource[1] = parameterPositionOne;
            newSource[2] = parameterPositionTwo;

            return newSource;
        }
    }
}
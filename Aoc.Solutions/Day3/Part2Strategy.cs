using System.Text.RegularExpressions;
using Aoc.Shared;

namespace Aoc.Solutions.Day3;

public class Part2Strategy: IDayStrategy<int>
{
    public int Execute(string input)
    {
        var mulOpMatches = Day3.MulOpRegex().Matches(input);
        var mulOpMap = new Dictionary<int, int>();
        
        foreach (Match match in mulOpMatches)
        {
            var leftOperand = Convert.ToInt32(match.Groups[1].Value);
            var rightOperand = Convert.ToInt32(match.Groups[2].Value);
            var product = leftOperand * rightOperand;
            mulOpMap.Add(match.Index, product);
        }

        var doOpIndices = Day3
            .DoOpRegex()
            .Matches(input)
            .Select(m => m.Index)
            .ToArray();

        var dontOpIndices = Day3
            .DontOpRegex()
            .Matches(input)
            .Select(m => m.Index)
            .ToArray();
        
        var disabledRanges = new List<DontDoRange>();
        
        foreach (var dontOpIndex in dontOpIndices)
        {
            var conjugateDoOpIndex = doOpIndices.FirstOrDefault(i => i > dontOpIndex);
            if (conjugateDoOpIndex is default(int)) conjugateDoOpIndex = int.MaxValue;
            if (conjugateDoOpIndex == disabledRanges.LastOrDefault()?.DoOpIndex) continue;
            disabledRanges.Add(new DontDoRange(dontOpIndex, conjugateDoOpIndex));
        }

        return mulOpMap
            .Where(mulOpKv => !disabledRanges.Any(r => r.IsInRange(mulOpKv.Key)))
            .Sum(mulOpKv => mulOpKv.Value);
    }
}
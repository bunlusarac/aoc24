using System.Text.RegularExpressions;
using Aoc.Shared;

namespace Aoc.Solutions.Day3;

public class Part1Strategy: IDayStrategy<int>
{
    public int Execute(string input)
    {
        var result = 0;
        var matches = Day3.MulOpRegex().Matches(input);
        foreach (Match match in matches)
        {
            var leftOperand = Convert.ToInt32(match.Groups[1].Value);
            var rightOperand = Convert.ToInt32(match.Groups[2].Value);
            result += leftOperand * rightOperand;
        }
        
        return result;
    }
}
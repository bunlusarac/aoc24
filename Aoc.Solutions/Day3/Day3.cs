using System.Text.RegularExpressions;
using Aoc.Shared;

namespace Aoc.Solutions.Day3;

public partial class Day3: Day<int>
{
    private const string MulOpPattern = @"mul\((\d+),(\d+)\)";
    private const string DoOpPattern = @"do\(\)";
    private const string DontOpPattern = @"don't\(\)";
    
    [GeneratedRegex(MulOpPattern)]
    protected internal static partial Regex MulOpRegex();
    
    [GeneratedRegex(DoOpPattern)]
    protected internal static partial Regex DoOpRegex();
    
    [GeneratedRegex(DontOpPattern)]
    protected internal static partial Regex DontOpRegex();
}
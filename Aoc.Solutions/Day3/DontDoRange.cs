namespace Aoc.Solutions.Day3;

public class DontDoRange(int dontOpIndex, int doOpIndex)
{
    public int DontOpIndex { get; set; } = dontOpIndex;
    public int DoOpIndex { get; set; } = doOpIndex;
        
    public bool IsInRange(int value) => value >= DontOpIndex && value <= DoOpIndex;
}
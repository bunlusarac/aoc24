namespace Aoc.Shared;

public class Day<TResult>: IDay<TResult>
{
    public TResult Execute(string input, IDayStrategy<TResult> strategy)
    {
        return strategy.Execute(input);
    }
}
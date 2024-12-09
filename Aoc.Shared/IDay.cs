namespace Aoc.Shared;

public interface IDay<TResult>
{
    public TResult Execute(string input, IDayStrategy<TResult> strategy);
}
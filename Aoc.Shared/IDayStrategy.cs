namespace Aoc.Shared;

public interface IDayStrategy<out TResult>
{
    public TResult Execute(string input);   
}
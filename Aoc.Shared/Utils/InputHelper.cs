namespace Aoc.Shared.Utils;

public static class InputHelper
{
    public static string ReadAllInput(string path = "input.txt")
    {
        using var reader = new StreamReader(path);
        return reader.ReadToEnd();
    }

    public static bool InputNotReachedEol(string path)
    {
        using var reader = new StreamReader(path);
        return !reader.EndOfStream;
    }
    
    public static string ReadInputLine(string path = "input.txt")
    {
        using var reader = new StreamReader(path);
        var line = reader.ReadLine();
        if (string.IsNullOrEmpty(line)) throw new EndOfStreamException();
        return line;
    }
}
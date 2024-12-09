// See https://aka.ms/new-console-template for more information

using Aoc.Shared.Utils;
using Aoc.Solutions.Day3;

var day = new Day3();
var result = day.Execute(InputHelper.ReadAllInput(), new Part2Strategy());
Console.WriteLine(result);
// See https://aka.ms/new-console-template for more information

//68467

using System.Reflection;
using AdventOfCode.Common;

var path = FileHelper.GetPathOfDataFile("elves.txt");

Console.WriteLine($"Loading the elf file from: {path}");

var lines = File.ReadAllLines(path);  

var elfTotals = new List<int>();
var currentTotal = 0;
foreach (var line in lines)
{
    if (string.IsNullOrWhiteSpace(line))
    {
        elfTotals.Add(currentTotal);
        currentTotal = 0;
    }
    else
    {
        var canAdd = int.TryParse(line, out var elfValue);
        if (canAdd)
        {
            currentTotal += elfValue;
        }
    }
}

var max = elfTotals.Max();

Console.WriteLine($"The largest amount is {max}");
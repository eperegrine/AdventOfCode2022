using System.Reflection;

namespace AdventOfCode.Common;

public static class FileHelper
{
    public static string GetPathOfDataFile(string fileName)
    {
        return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, 
            Path.Combine("Data", fileName));
    }
}
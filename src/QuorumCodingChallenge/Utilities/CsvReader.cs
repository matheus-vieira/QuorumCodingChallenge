namespace QuorumCodingChallenge.Utilities;

public static class CsvReader
{
    public static List<T> ReadCsv<T>(this string filePath, Func<string[], T> mapFunction)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"The file at {filePath} was not found.");

        var lines = File.ReadAllLines(filePath);

        if (lines.Length < 2)
            throw new InvalidOperationException("The CSV file is empty or does not contain a header row.");

        // Skip the header row and parse the remaining lines
        return [.. lines
            .Skip(1)
            .Select(line => line.Split(','))
            .Select(mapFunction)];
    }
}

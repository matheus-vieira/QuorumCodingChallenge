namespace QuorumCodingChallenge.Utilities;

public static class CsvWriter
{

    public static void WriteToCsv(this List<string> data, string filePath, string header)
    {
        using var writer = new StreamWriter(filePath);
        writer.WriteLine(header);

        foreach (var row in data)
            writer.WriteLine(row);
    }

    public static void WriteBills(
        string filePath,
        List<(int BillId, string Title, int SupporterCount, int OpposerCount, string PrimarySponsor)> data)
    {
        using var writer = new StreamWriter(filePath);
        writer.WriteLine("id,title,supporter_count,opposer_count,primary_sponsor");

        foreach (var (BillId, Title, SupporterCount, OpposerCount, PrimarySponsor) in data)
        {
            writer.WriteLine($"{BillId},{Title},{SupporterCount},{OpposerCount},{PrimarySponsor}");
        }
    }
}
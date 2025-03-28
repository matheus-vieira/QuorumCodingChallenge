namespace QuorumCodingChallenge.Parsers;


public static class Parser
{
    public static List<Models.Person> ToPerson(this string filePath)
        => Utilities.CsvReader.ReadCsv<Models.Person>(filePath, fields => fields);

    public static List<Models.Vote> ToVote(this string filePath)
        => Utilities.CsvReader.ReadCsv<Models.Vote>(filePath, fields => fields);

    public static List<Models.VoteResult> ToVoteResult(this string filePath)
        => Utilities.CsvReader.ReadCsv<Models.VoteResult>(filePath, fields => fields);

    public static List<Models.Bill> ToBill(this string filePath)
        => Utilities.CsvReader.ReadCsv<Models.Bill>(filePath, fields => fields);
}
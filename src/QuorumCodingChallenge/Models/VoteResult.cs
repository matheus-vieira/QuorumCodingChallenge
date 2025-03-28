namespace QuorumCodingChallenge.Models;

public class VoteResult
{
    public int Id { get; set; }
    public int LegislatorId { get; set; }
    public int VoteId { get; set; }
    public int VoteType { get; set; } // 1 for Yea, 2 for Nay

    public static implicit operator VoteResult(string[] fields)
    {
        if (fields.Length < 4)
            throw new ArgumentException("The input fields array does not contain the required number of elements.");

        return new()
        {
            Id = int.Parse(fields[0]),
            LegislatorId = int.Parse(fields[1]),
            VoteId = int.Parse(fields[2]),
            VoteType = int.Parse(fields[3])
        };
    }
}
namespace QuorumCodingChallenge.Models;

public class Vote
{
    public int Id { get; set; }
    public int BillId { get; set; }

    public static implicit operator Vote(string[] fields)
    {
        if (fields.Length < 2)
            throw new ArgumentException("The input fields array does not contain the required number of elements.");

        return new()
        {
            Id = int.Parse(fields[0]),
            BillId = int.Parse(fields[1])
        };
    }
}
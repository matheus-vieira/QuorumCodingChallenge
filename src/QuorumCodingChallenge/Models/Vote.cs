namespace QuorumCodingChallenge.Models;

public class Vote
{
    public int Id { get; set; }
    public int BillId { get; set; }

    public static implicit operator Vote(string[] fields)
    {
        if (fields.Length < 2)
            throw new ArgumentException("The input fields array does not contain the required number of elements.");

        _ = int.TryParse(fields[0], out int id);
        _ = int.TryParse(fields[1], out int billId);

        return new()
        {
            Id = id,
            BillId = billId
        };
    }
}
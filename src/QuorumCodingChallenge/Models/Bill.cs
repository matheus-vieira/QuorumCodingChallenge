namespace QuorumCodingChallenge.Models;

public class Bill
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int PrimarySponsorId { get; set; }

    public static implicit operator Bill(string[] fields)
    {
        if (fields.Length < 3)
            throw new ArgumentException("The input fields array does not contain the required number of elements.");

        return new()
        {
            Id = int.Parse(fields[0]),
            Title = fields[1],
            PrimarySponsorId = int.Parse(fields[2]),
        };
    }
}
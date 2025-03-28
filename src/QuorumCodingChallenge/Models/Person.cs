namespace QuorumCodingChallenge.Models;

/// <summary>
/// An individual legislator elected to government
// This includes everyone from President Joe Biden to Representative. David McKinley from West Virginia.
/// </summary>
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public static implicit operator Person(string[] fields)
    {
        if (fields.Length < 2)
            throw new ArgumentException("The input fields array does not contain the required number of elements.");

        return new()
        {
            Id = int.Parse(fields[0]),
            Name = fields[1]
        };
    }
}
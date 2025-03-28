using QuorumCodingChallenge.Models;
using QuorumCodingChallenge.Utilities;

namespace QuorumCodingChallenge.Services;

public class LegislatorService
{
    public static void CalculateSupportAndOpposition(
        string outputPath,
        List<Person> legislators,
        List<VoteResult> voteResults)
    {
        var results =  legislators.Select(legislator =>
        {
            var legislatorVotes = voteResults.Where(vr => vr.LegislatorId == legislator.Id);

            int supportedBills = legislatorVotes.Count(vr => vr.VoteType == 1); // Yea
            int opposedBills = legislatorVotes.Count(vr => vr.VoteType == 2);   // Nay

            return (legislator.Id, legislator.Name, supportedBills, opposedBills);
        });

        var legislatorData = results.Select(result => $"{result.Id},{result.Name},{result.supportedBills},{result.opposedBills}").ToList();

        var csvHeader = @"id,name,num_supported_bills,num_opposed_bills";

        legislatorData.WriteToCsv($"{outputPath}/legislators-support-oppose-count.csv", csvHeader);
    }
}
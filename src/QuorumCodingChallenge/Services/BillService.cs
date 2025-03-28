using QuorumCodingChallenge.Models;
using QuorumCodingChallenge.Utilities;

namespace QuorumCodingChallenge.Services;

public class BillService
{
    public static void CalculateBillStatistics(
        string outputPath,
        List<Bill> bills,
        List<VoteResult> voteResults,
        List<Vote> votes,
        List<Person> legislators)
    {
        var results = bills.Select(bill =>
        {
            var billVotes = votes.Where(v => v.BillId == bill.Id).Select(v => v.Id);
            var billVoteResults = voteResults.Where(vr => billVotes.Contains(vr.VoteId));

            int supporterCount = billVoteResults.Count(vr => vr.VoteType == 1); // Yea
            int opposerCount = billVoteResults.Count(vr => vr.VoteType == 2);   // Nay

            var primarySponsor = legislators.FirstOrDefault(l => l.Id == bill.PrimarySponsorId)?.Name ?? "Unknown";

            return (bill.Id, bill.Title, supporterCount, opposerCount, primarySponsor);
        });

        var billData = results.Select(result => 
            $"{result.Id},{result.Title},{result.supporterCount},{result.opposerCount},{result.primarySponsor}"
        ).ToList();

        var csvHeader = @"id,title,supporter_count,opposer_count,primary_sponsor";

        billData.WriteToCsv($"{outputPath}/bills.csv", csvHeader);
    }
}
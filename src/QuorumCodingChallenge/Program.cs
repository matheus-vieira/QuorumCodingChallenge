// See https://aka.ms/new-console-template for more information


using QuorumCodingChallenge.Parsers;

string inputPath = @"D:\github\matheus-vieira\QuorumCodingChallenge\input-files";
string fileExtension = "*.csv"; // Change to your desired extension
string outputPath = @"D:\github\matheus-vieira\QuorumCodingChallenge\output-files";

string[] files = Directory.GetFiles(inputPath, fileExtension);

var legislators = new List<QuorumCodingChallenge.Models.Person>();
var votes = new List<QuorumCodingChallenge.Models.Vote>();
var votesResult = new List<QuorumCodingChallenge.Models.VoteResult>();
var bills = new List<QuorumCodingChallenge.Models.Bill>();

foreach (string file in files)
{
    if (file.EndsWith("legislators.csv"))
        legislators = file.ToPerson();
    else if (file.EndsWith("votes.csv"))
        votes = file.ToVote();
    else if (file.EndsWith("vote_results.csv"))
        votesResult = file.ToVoteResult();
    else if (file.EndsWith("bills.csv"))
        bills = file.ToBill();
}

QuorumCodingChallenge.Services.LegislatorService.CalculateSupportAndOpposition(outputPath, legislators, votesResult);
QuorumCodingChallenge.Services.BillService.CalculateBillStatistics(outputPath, bills, votesResult, votes, legislators);
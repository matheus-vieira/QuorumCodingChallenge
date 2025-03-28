// See https://aka.ms/new-console-template for more information


using QuorumCodingChallenge.Parsers;
using System.Linq;

string directoryPath = @"D:\tests\quorum\Quorum_Coding_Challenge\Quorum Coding Challenge - Candidate Folder";
string fileExtension = "*.csv"; // Change to your desired extension

string[] files = Directory.GetFiles(directoryPath, fileExtension);


foreach (string file in files)
{
    Console.WriteLine(file);
    Console.WriteLine();

    if (file.EndsWith("legislators.csv"))
        Console.WriteLine(string.Join(Environment.NewLine, file.ToPerson()[..1]));
    else if (file.EndsWith("votes.csv"))
        Console.WriteLine(string.Join(Environment.NewLine, file.ToVote()[..1]));
    else if (file.EndsWith("vote_results.csv"))
        Console.WriteLine(string.Join(Environment.NewLine, file.ToVoteResult()[..1]));
    else
        Console.WriteLine("Invalid file");

    Console.WriteLine();
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine();
}


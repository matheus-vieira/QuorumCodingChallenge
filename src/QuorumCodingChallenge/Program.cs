using QuorumCodingChallenge.Parsers;
using QuorumCodingChallenge.Services;

Console.WriteLine("Welcome to the Quorum Coding Challenge!");
Console.WriteLine("This program processes legislative data and generates reports based on legislators' votes and bills.");
Console.WriteLine();

// Ask for input folder path
string inputPath = AskForValidPath("Enter the folder path containing the input CSV files:");

// List files in the folder
string[] files = Directory.GetFiles(inputPath, "*.csv");
if (files.Length == 0)
{
    Console.WriteLine("No CSV files found in the specified folder. Exiting...");
    return;
}

Console.WriteLine("\nThe following CSV files were found:");
for (int i = 0; i < files.Length; i++)
    Console.WriteLine($"{i + 1}. {Path.GetFileName(files[i])}");

// Ask the user to select files for each model
string legislatorsFile = files[AskForFileIndex("Select the file for legislators:", files.Length) - 1];
string votesFile = files[AskForFileIndex("Select the file for votes:", files.Length) - 1];
string voteResultsFile = files[AskForFileIndex("Select the file for vote results:", files.Length) - 1];
string billsFile = files[AskForFileIndex("Select the file for bills:", files.Length) - 1];

// Ask for output folder path
string outputPath = AskForValidPath("Enter the folder path where the output files should be saved:");

// Parse the files
var legislators = legislatorsFile.ToPerson();
var votes = votesFile.ToVote();
var voteResults = voteResultsFile.ToVoteResult();
var bills = billsFile.ToBill();

// Process the data
LegislatorService.CalculateSupportAndOpposition(outputPath, legislators, voteResults);

BillService.CalculateBillStatistics(outputPath, bills, voteResults, votes, legislators);

Console.WriteLine("\nProcessing complete! The output files have been saved to the specified folder.");


static string AskForValidPath(string prompt)
    => ConsoleAsk(prompt, path => Directory.Exists(path), "Invalid path. Please try again.");

static int AskForFileIndex(string prompt, int maxIndex)
{
    var answer = ConsoleAsk(prompt, path => int.TryParse(path, out _), $"Invalid input. Please enter a number between 1 and {maxIndex}.");
    return int.Parse(answer);
}

static string ConsoleAsk(string prompt, Func<string, bool> validateAnswer, string errorMsg)
{
    while (true)
    {
        Console.WriteLine(prompt);
        var answer = Console.ReadLine()!;
        if (validateAnswer(answer))
            return answer;

        Console.WriteLine(errorMsg);
    }
}

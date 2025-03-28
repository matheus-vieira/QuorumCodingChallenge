# Quorum Coding Challenge

## Project Description

This project processes legislative data to generate reports based on legislators' votes and bills. It takes input CSV files containing information about legislators, bills, votes, and vote results, processes the data, and outputs CSV reports summarizing the results.

The application is designed to:

- Calculate the number of bills supported and opposed by each legislator.
- Calculate the number of legislators supporting and opposing each bill, along with identifying the primary sponsor of each bill.

## Instructions to Run the Application

### Prerequisites

- .NET 9 SDK installed on your machine.
- Input CSV files for `legislators`, `bills`, `votes`, and `vote_results`.

### Steps to Run

1. Clone the repository:

    ```bash
    git clone https://github.com/matheus-vieira/QuorumCodingChallenge.git
    cd QuorumCodingChallenge
    ```

2. Build the project:

    ```bash
    dotnet build
    ```

3. Run the application

    ```bash
    dotnet run --project src/QuorumCodingChallenge
    ```

4. Follow the interactive prompts:
   - Provide the folder path containing the input CSV files.
   - Select the appropriate files for legislators, bills, votes, and vote_results.
   - Specify the folder path where the output files should be saved.

5. Check the output folder for the generated CSV files:

- `legislators-support-oppose-count.csv`
- `bills.csv`

## Implementation explanation

As required in the challenge there's [Solution file](/docs/solution.md) that answer the challenge questions:

1. Discuss your solution’s time complexity. What tradeoffs did you make?
2. How would you change your solution to account for future columns that might be requested, such as “Bill Voted On Date” or “Co-Sponsors”?
3. How would you change your solution if instead of receiving CSVs of data, you were given a list of legislators or bills that you should generate a CSV for?
4. How long did you spend working on the assignment?

To better handle the development I added a [tasks file](/docs/README.md).

This tasks file was the start point to organize the development of the challenge.

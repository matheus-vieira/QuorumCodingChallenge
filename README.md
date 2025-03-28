# Quorum Coding Challenge

## Overview

This project processes legislative data to generate insights about legislators and bills. It outputs two CSV files:

1. `legislators-support-oppose-count.csv`: Contains the number of bills supported and opposed by each legislator.
2. `bills.csv`: Contains the number of legislators supporting and opposing each bill, along with the primary sponsor.

## Prerequisites

- .NET 9 SDK installed.

## How to Run

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/QuorumCodingChallenge.git
   cd QuorumCodingChallenge/src/QuorumCodingChallenge
   ```

2. Build the project:

   ```bash
    dotnet build
    ```

3. Run the application:

    ```bash
    dotnet run
    ```

4. Interact with the application to have the input files processed.

    ```bash
    Welcome to the Quorum Coding Challenge!
    This program processes legislative data and generates reports based on legislators' votes and bills.

    Enter the folder path containing the input CSV files:
    > D:\input-files

    The following CSV files were found:
    1. legislators.csv
    2. votes.csv
    3. vote_results.csv
    4. bills.csv

    Select the file for legislators:
    > 1
    Select the file for votes:
    > 2
    Select the file for vote results:
    > 3
    Select the file for bills:
    > 4

    Enter the folder path where the output files should be saved:
    > D:\output-files

    Processing complete! The output files have been saved to the specified folder.
    ```

### Folder Structure

- src/: Contains the source code.
- docs/: Contains documentation.
- output/: Contains generated CSV files.
- data/: Contains sample input files.

### Documentation

See the [docs/README.md](docs/README.md) file for detailed answers to the challenge questions.

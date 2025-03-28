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
    dotnet run -- <path-to-bills.csv> <path-to-legislators.csv> <path-to-votes.csv> <path-to-vote_results.csv>
    ```

4. The output files will be generated in the output/ folder.

### Folder Structure

- src/: Contains the source code.
- docs/: Contains documentation.
- output/: Contains generated CSV files.
- data/: Contains sample input files.

### Documentation

See the [docs/README.md](docs/README.md) file for detailed answers to the challenge questions.

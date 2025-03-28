# Solution Documentation

## Time Complexity Analysis

### CSV Parsing

- **What it does**: Reads the input CSV files and converts each row into objects (e.g., `Person`, `Bill`, etc.).
- **How fast it is**: It processes each row one by one, so the time it takes depends on the number of rows in the file.
- **Time Complexity**: O(n), where `n` is the number of rows in the file.

### Legislator Support and Opposition Calculation

- **What it does**: Counts how many bills each legislator supported or opposed.
- **How fast it is**: For each legislator, it checks all the vote results. If there are many legislators or votes, this can take longer.
- **Time Complexity**: O(m * n), where `m` is the number of legislators and `n` is the number of vote results.

### Bill Statistics Calculation

- **What it does**: Counts how many legislators supported or opposed each bill and finds the primary sponsor.
- **How fast it is**: For each bill, it checks all the vote results. If there are many bills or votes, this can take longer.
- **Time Complexity**: O(b * n), where `b` is the number of bills and `n` is the number of vote results.

### Writing Output CSV Files

- **What it does**: Saves the results to CSV files.
- **How fast it is**: Writes each row one by one, so the time depends on the number of rows in the output.
- **Time Complexity**: O(r), where `r` is the number of rows written.

### Overall Complexity

- **Combined Speed**: The total time depends on the size of the input files and the number of legislators, bills, and votes. The largest factor is usually the number of vote results.

---

## Future-Proofing the Solution

1. **Making it Faster**:
   - Use tools like parallel processing to handle large datasets more quickly.
   - Use dictionaries to speed up searches.

2. **Making it Flexible**:
   - Add support for new types of reports or data formats (e.g., JSON or databases).
   - Keep the code modular so new features can be added easily.

3. **Handling Errors**:
   - Add checks for missing or incorrect data in the input files.
   - Log errors to a file so they can be reviewed later.

4. **Improving Performance**:
   - Use streaming to process large files without loading everything into memory.
   - Save intermediate results to avoid repeating calculations.

5. **Testing**:
   - Make sure that individual parts of code are working applying unit test for each code file.
   - Also some tests to check end to end of the application.

6. **Advance system to process data**:
   - I can be configurable to add source data, that could be files, databases, or external systems.
   - The source data can configure data layouts, transformations, etc.

---

## Handling Alternative Input Formats

1. **Possible files to work on**:
   1. **JSON Files**
   2. **XML Files**
   3. **Excel Files**
   4. **Fixed length Files**
   - Each file can have it own parses for better maintenance.

2. **Databases**:
   - Replace CSV files with a database (e.g., SQL Server or PostgreSQL).
   - Use a library like Entity Framework Core to query the data.

3. **APIs**:
   - Fetch data from an API instead of files.
   - Use `HttpClient` to get the data and convert it into objects.

---

## Time Spent on the Challenge

Here’s how we spent our time today (from 9:00 AM to 12:30 PM):

1. **Understanding the Requirements**: ~30 minutes
   - Read the challenge description and planned the tasks.

2. **Implementing Models**: ~30 minutes
   - Created the `Person`, `Bill`, `Vote`, and `VoteResult` classes.

3. **CSV Parsing**: ~45 minutes
   - Built the `CsvParser` class to read and parse the input files.

4. **Business Logic**: ~1 hour
   - Implemented the `LegislatorService` and `BillService` classes.

5. **Interactive CLI**: ~30 minutes
   - Made the program interactive by asking the user for input paths and file selections.

6. **Output Generation**: ~15 minutes
   - Wrote the results to CSV files using the `CsvWriter` class.

7. **Documentation**: ~30 minutes
   - Wrote this documentation and updated the README file.

**Total Time**: ~3 hours and 30 minutes

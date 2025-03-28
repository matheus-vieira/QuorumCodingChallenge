# Task Plan for the Quorum Coding Challenge

Below is a structured task plan to implement the solution using .NET 9. The tasks are divided into logical steps to ensure clarity and efficiency.

---

## Task 1: Set Up the GitHub Repository

**Summary**: Create a GitHub repository to organize the project files and documentation.

### **Steps:**

1. Create a new GitHub repository named QuorumCodingChallenge.
2. Add the following folder structure:

* src/: For source code.
* docs/: For documentation.
* output/: For generated CSV files.

3. Add a README.md file in the root directory with instructions on how to run the application.

---

## Task 2: Define the Data Models

**Summary**: Create C# classes to represent the data models (Person, Bill, Vote, VoteResult).

### **Task 2 - Steps:**

1. Create a new project in the src/ folder using the .NET CLI:

```bash
dotnet new console -n QuorumCodingChallenge
```

2. Define the following classes in a Models folder:

* Person: Represents a legislator.
* Bill: Represents a piece of legislation.
* Vote: Represents a vote on a bill.
* VoteResult: Represents a legislator's vote on a bill.

---

## Task 3: Implement CSV Parsing

**Summary**: Write utility methods to parse the provided CSV files into the data models.

### **Task 3 - Steps:**

1. Create a Utilities folder in the project.
2. Add a CsvParser class to ## Task 3: Implement CSV Parsing

**Summary**: Write utility methods to parse the provided CSV files into the data models.

### **Task 3 - Steps:**

1. Create a Utilities folder in the project.
2. Add a CsvParser class to handle reading and parsing CSV files.
3. Use System.IO and System.Linq to parse the CSV files into lists of objects.handle reading and parsing CSV files.
3. Use System.IO and System.Linq to parse the CSV files into lists of objects.

---

## Task 4: Implement Business Logic

**Summary**: Write methods to calculate the required outputs for legislators and bills.

### **Task 4 - Steps:**

1. Create a Services folder in the project.
2. Add a LegislatorService class to calculate:
* Number of bills supported and opposed by each legislator.
3. Add a BillService class to calculate:
* Number of legislators supporting and opposing each bill.
* Primary sponsor of each bill.

---

## Task 5: Generate Output CSV Files

**Summary**: Write the results of the calculations to CSV files.

### **Task 5 - Steps:**

1. Create a CsvWriter class in the Utilities folder.
2. Write methods to generate:
* legislators-support-oppose-count.csv
* bills.csv

---

## Task 6: Add Command-Line Interface

**Summary**: Create a simple CLI to run the application and generate the output files.

### **Task 6 - Steps:**

1. Modify the Program.cs file to:
* Accept input file paths as arguments.
* Call the appropriate services to process the data and generate output files.

--- 

## Task 7: Write Documentation

**Summary**: Add documentation to explain how to run the application and the structure of the project.

## **Task 7 - Steps:**

1. Update the README.md file with:

* Project description.
* Instructions to run the application.
* Example commands.

2. Add a docs/solution.md file to answer the questions in the challenge:

* Time complexity analysis.
* Future-proofing the solution.
* Handling alternative input formats.
* Time spent on the challenge.

## Task 8: Test the Application

**Summary**: Verify the correctness of the application using sample data.

## **Task 8 - Steps:**

1. Add sample CSV files to a data/ folder.
2. Run the application and verify the output matches the expected results.
3. Fix any bugs or issues found during testing.

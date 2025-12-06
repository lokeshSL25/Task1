using System;

class TransactionAnalyzer
{
    static void Main()
    {
        string transactionId = "TRX123AB89YZ"; // 12-character alphanumeric
        decimal amount = 1000000.75m; // financial amount
        bool isInternational = true; // domestic/international
        decimal customerRating = 4.75m; // rating (2 decimal)
        DateTime transactionTimestamp = DateTime.Now; // date & time
        int rewardPoints = 1250000; // whole number

        Console.WriteLine("Transaction Analyzer Running...");
        Console.WriteLine($"ID: {transactionId}");
        Console.WriteLine($"Amount: ₹{amount}");
        Console.WriteLine($"International: {isInternational}");
        Console.WriteLine($"Rating: {customerRating}");
        Console.WriteLine($"Timestamp: {transactionTimestamp}");
        Console.WriteLine($"Reward Points: {rewardPoints}");
    }
}

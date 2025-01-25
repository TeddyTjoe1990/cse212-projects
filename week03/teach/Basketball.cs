using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        try
        {
            // Check if the file exists
            const string filePath = @"C:\Users\ASUS\Git\cse212\cse212-projects\week03\teach\basketball.csv";
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Error: File '{filePath}' not found.");
                return;
            }

            // Read the CSV file
            using var reader = new TextFieldParser(filePath);
            reader.TextFieldType = FieldType.Delimited;
            reader.SetDelimiters(",");
            reader.ReadFields(); // Skip the header row

            while (!reader.EndOfData)
            {
                var fields = reader.ReadFields();
                if (fields == null || fields.Length < 9)
                {
                    Console.WriteLine("Skipping malformed row.");
                    continue;
                }

                var playerId = fields[0];
                if (!int.TryParse(fields[8], out var points))
                {
                    Console.WriteLine($"Invalid points value for Player ID {playerId}, skipping row.");
                    continue;
                }

                // Aggregate points for each player
                if (players.ContainsKey(playerId))
                    players[playerId] += points;
                else
                    players[playerId] = points;
            }

            // Sort players by total points in descending order
            var topPlayers = players.OrderByDescending(p => p.Value).Take(10).ToArray();

            // Display the top 10 players
            Console.WriteLine("\nTop 10 Players by Career Points:");
            for (var i = 0; i < topPlayers.Length; ++i)
            {
                Console.WriteLine($"#{i + 1}: Player ID {topPlayers[i].Key}, Total Points {topPlayers[i].Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

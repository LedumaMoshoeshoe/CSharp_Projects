using System;

public class PasswordGenerator
{
    public static void Main()
    {
        // Ask the user how many items they would like to create
        Console.Write("Enter the number of items to create: ");
        int itemCount = int.Parse(Console.ReadLine());

        // Process each item
        for (int i = 0; i < itemCount; i++)
        {
            Console.Write("Enter the full name: ");
            string fullName = Console.ReadLine();

            // Generate the password for the current full name
            string password = GeneratePassword(fullName);

            Console.WriteLine("Password: " + password);
        }
    }

    public static string GeneratePassword(string fullName)
    {
        // Convert the full name to uppercase for consistent processing
        fullName = fullName.ToUpper();

        string password = "";
        int letterEliminatedCount = 0;

        foreach (char c in fullName)
        {
            if (c == 'A' || c == 'E' || c == 'T')
            {
                // Eliminate letters 'A', 'E', and 'T'
                letterEliminatedCount++;
            }
            else if (c == ' ')
            {
                // Replace space with 'S&?'
                password += "S&?";
            }
            else if ("AEIOU".Contains(c))
            {
                // Add each vowel (except 'A' and 'E') twice
                password += c.ToString() + c.ToString();
            }
            else
            {
                // Keep all other characters unchanged
                password += c.ToString();
            }
        }

        // Append the number of letters eliminated at the end of the password
        password += letterEliminatedCount;

        return password;
    }
}

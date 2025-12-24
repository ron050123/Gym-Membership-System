using GymMembershipSystem;
using System;
using System.IO;
using System.Linq;

public class UserManagement : IUserManagement
{
    private string userFile = "users.txt";

    // Method to add a new user
    public void AddUser(string name, string email, string password, string membershipType)
    {
        // Check if user already exists
        if (UserExists(email))
        {
            throw new Exception("User with this email already exists.");
        }

        // Generate a new user ID
        int newUserId = File.Exists(userFile) ? File.ReadAllLines(userFile).Length + 1 : 1;

        // Format user data
        string newUser = $"{newUserId}, {name}, {email}, {password}, {membershipType}";

        // Append user data to the file
        File.AppendAllText(userFile, newUser + Environment.NewLine);
    }

    // Method to check if a user already exists by email
    public bool UserExists(string email)
    {
        if (!File.Exists(userFile)) return false;

        string[] users = File.ReadAllLines(userFile);
        return users.Any(user => user.Split(',')[2].Trim() == email);
    }

    // Method to change the user's membership type
    public void ChangeMembership(string userId, string newMembershipType)
    {
        if (!File.Exists(userFile)) throw new FileNotFoundException("User data file not found.");

        // Read all user data into an array
        string[] users = File.ReadAllLines(userFile);

        for (int i = 0; i < users.Length; i++)
        {
            string[] userData = users[i].Split(',');

            // Check if userId matches
            if (userData[0].Trim() == userId)
            {
                // Update the membership type in the file
                users[i] = $"{userData[0]}, {userData[1]}, {userData[2]}, {userData[3]}, {newMembershipType}";
                File.WriteAllLines(userFile, users);  // Write the updated data back to the file
                break;
            }
        }
    }

    // Method to get the current membership type of the user
    public string GetMembershipType(string userId)
    {
        if (!File.Exists(userFile)) throw new FileNotFoundException("User data file not found.");

        // Read user data and find the user's membership type
        string[] users = File.ReadAllLines(userFile);

        foreach (var user in users)
        {
            string[] userData = user.Split(',');

            if (userData[0].Trim() == userId)
            {
                return userData[4].Trim();  // Assuming membership type is at index 4
            }
        }

        throw new Exception("User not found.");
    }
}

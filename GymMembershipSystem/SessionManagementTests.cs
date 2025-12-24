using NUnit.Framework;
using System.IO;
using System.Linq;

namespace GymMembershipSystem.Tests
{
    [TestFixture]
    public class SessionManagementTests
    {
        [Test]
        public void TestSessionExistsInFile()
        {
            // Arrange
            var sessionManagement = new SessionManagement();
            string newSessionId = "2";
            string userId = "1"; 
            string trainer = "Tony";
            string sessionType = "Yoga"; 
            string date = "2024-10-27"; 
            string time = "10:00 AM";

            // Act
            bool sessionExists = SessionExistsInFile(newSessionId, userId, trainer, sessionType, date, time);

            // Assert
            Assert.That(sessionExists, "The session does not exist with the given details.");
        }

        private bool SessionExistsInFile(string newSessionId, string userId, string trainer, string sessionType, string date, string time)
        {
            // Check if the sessions file exists
            if (!File.Exists("sessions.txt")) return false;

            // Read all lines from the sessions file
            string[] sessions = File.ReadAllLines("sessions.txt");

            // Check if any session in the file matches all the provided details
            return sessions.Any(session =>
            {
                string[] sessionDetails = session.Split(',');
                return sessionDetails.Length >= 6 &&
                       sessionDetails[0] == newSessionId &&
                       sessionDetails[1].Trim() == userId &&
                       sessionDetails[2].Trim() == trainer &&
                       sessionDetails[3].Trim() == sessionType &&
                       sessionDetails[4].Trim() == date &&
                       sessionDetails[5].Trim() == time;
            });
        }
    }
}

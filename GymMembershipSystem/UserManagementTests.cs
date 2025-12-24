using NUnit.Framework;
using System.IO;
using System.Linq;

namespace GymMembershipSystem.Tests
{
    [TestFixture]
    public class UserManagementFileTests
    {
        private string userFile = "users.txt";

        [Test]
        public void TestMembershipTypeMatchesUserId()
        {
            // Arrange
            var userId = "1";
            var expectedMembership = "Basic"; // Expected membership type from the file

            if (!File.Exists(userFile)) Assert.Fail("User data file not found.");

            var userManagement = new UserManagement();

            // Act
            var actualMembership = userManagement.GetMembershipType(userId);

            // Assert
            Assert.That(actualMembership, Is.EqualTo(expectedMembership), $"User ID {userId} should have {expectedMembership} membership.");
        }
    }
}
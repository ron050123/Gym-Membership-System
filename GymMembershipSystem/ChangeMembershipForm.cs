using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GymMembershipSystem
{
    public partial class ChangeMembershipForm : Form
    {
        private string userId;
        private IUserManagement userManagement;
        private string currentMembershipType;  // Store the user's current membership

        public ChangeMembershipForm(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            userManagement = new UserManagement();

            // Set combo box to be unchangeable (dropdown only)
            cmbCurrentMembershipType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNewMembershipType.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadCurrentMembership();  // Load the current membership details for this user

            // Populate ComboBox with membership options
            cmbCurrentMembershipType.Items.AddRange(new object[] {
                "Standard - $20",
                "Premium - $50",
                "Basic - $10"
            });
            cmbNewMembershipType.Items.AddRange(new object[] {
                "Standard - $20",
                "Premium - $50",
                "Basic - $10"
            });
        }

        private void LoadCurrentMembership()
        {
            string[] users = File.ReadAllLines("users.txt");
            foreach (string user in users)
            {
                string[] userData = user.Split(',');
                if (userData[0].Trim() == userId)
                {
                    currentMembershipType = userData[4].Trim();  // Assuming membership type is in index 4
                    break;
                }
            }
            //string[] users = File.ReadAllLines("users.txt");
            //foreach (string user in users)
            //{
            //    string[] userData = user.Split(',');
            //    if (userData[0].Trim() == userId)
            //    {
            //        currentMembershipType = userData.Length > 4 ? userData[4].Trim() : null;  // Ensure we have the membership type
            //        break;
            //    }
            //}

            //if (currentMembershipType == null)
            //{
            //    MessageBox.Show("Could not find the current membership for this user.");
            //    return;
            //}

            //cmbCurrentMembershipType.SelectedItem = cmbCurrentMembershipType.Items
            //    .Cast<string>()
            //    .FirstOrDefault(item => item.Contains(currentMembershipType));
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string selectedCurrentMembership = cmbCurrentMembershipType.SelectedItem?.ToString();
            string selectedNewMembership = cmbNewMembershipType.SelectedItem?.ToString();

            // Validate user input
            if (string.IsNullOrEmpty(selectedCurrentMembership) || string.IsNullOrEmpty(selectedNewMembership))
            {
                MessageBox.Show("Please select both current and new membership types.");
                return;
            }

            // Check if currentMembershipType is still null
            if (currentMembershipType == null)
            {
                MessageBox.Show("Current membership is not loaded correctly.");
                return;
            }

            // Check if the selected current membership matches the user's current membership in the file
            if (!selectedCurrentMembership.Contains(currentMembershipType))
            {
                MessageBox.Show("Your current membership does not match the selected membership. Please try again.");
                return;
            }

            // Check if the user is trying to change to the same membership
            if (selectedCurrentMembership == selectedNewMembership)
            {
                MessageBox.Show("You cannot change to the same membership plan. Please select a different plan.");
                return;
            }

            // Update membership in the users.txt file
            //string[] users = File.ReadAllLines("users.txt");
            //for (int i = 0; i < users.Length; i++)
            //{
            //    string[] userData = users[i].Split(',');
            //    if (userData[0].Trim() == userId)
            //    {
            //        // Update the membership type
            //        users[i] = $"{userData[0]}, {userData[1]}, {userData[2]}, {userData[3]}, {selectedNewMembership}";
            //        File.WriteAllLines("users.txt", users);
            //        MessageBox.Show("Membership updated successfully!");
            //        this.Close();
            //        break;
            //    }
            //}
            userManagement.ChangeMembership(userId, selectedNewMembership.Split('-')[0].Trim());
            MessageBox.Show("Membership changed successfully!");
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

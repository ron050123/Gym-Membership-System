using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GymMembershipSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();

            // Set initial placeholder text for the name, password, and email fields
            txtName.Text = "Name";
            txtName.ForeColor = Color.Gray;

            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.PasswordChar = '\0';  // Remove masking initially

            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Gray;

            // Attach events for placeholders
            txtName.GotFocus += RemoveNamePlaceholder;
            txtName.LostFocus += SetNamePlaceholder;

            txtPassword.GotFocus += RemovePasswordPlaceholder;
            txtPassword.LostFocus += SetPasswordPlaceholder;

            txtEmail.GotFocus += RemoveEmailPlaceholder;
            txtEmail.LostFocus += SetEmailPlaceholder;

            // Set the ComboBox to behave like a dropdown where the user cannot type text
            cmbMembershipType.DropDownStyle = ComboBoxStyle.DropDownList;

            // Populate membership types with prices
            PopulateMembershipTypes();
        }

        // Placeholder for the Name field
        private void SetNamePlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.Gray;
            }
        }

        private void RemoveNamePlaceholder(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        // Placeholder for the Password field
        private void SetPasswordPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.PasswordChar = '\0';  // Remove masking to show "Password"
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void RemovePasswordPlaceholder(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';  // Set the PasswordChar when user types
            }
        }

        // Placeholder for the Email field
        private void SetEmailPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void RemoveEmailPlaceholder(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();  // Get the password from the password TextBox
            string selectedMembership = cmbMembershipType.SelectedItem?.ToString();

            // Validate Name
            if (string.IsNullOrEmpty(name) || name == "Name")
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }

            // Validate Email
            if (string.IsNullOrEmpty(email) || email == "Email")
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Check if email already exists in the users.txt file
            if (File.Exists("users.txt"))
            {
                string[] users = File.ReadAllLines("users.txt");
                foreach (string user in users)
                {
                    // Split user data to check for email
                    string[] userData = user.Split(',');

                    // Validate if userData array has at least 3 elements
                    if (userData.Length >= 3 && userData[2].Trim() == email)
                    {
                        MessageBox.Show("Email already exists, please try again.");
                        return;  // Exit the method if the email exists
                    }
                }
            }

            // Validate Password
            if (string.IsNullOrEmpty(password) || password == "Password")
            {
                MessageBox.Show("Please enter a valid password.");
                return;
            }

            // Validate Membership Type
            if (selectedMembership == null || selectedMembership == "Membership Type")
            {
                MessageBox.Show("Please select a valid membership type.");
                return;
            }

            // Extract only the membership type without the price
            string membershipType = selectedMembership.Split('-')[0].Trim();

            // Generate a new user ID
            int newUserId = File.ReadAllLines("users.txt").Length + 1;

            // Store the user with the password in users.txt
            string newUser = $"{newUserId}, {name}, {email}, {password}, {membershipType}";
            File.AppendAllText("users.txt", newUser + Environment.NewLine);

            MessageBox.Show("Sign-up successful!");
            this.Close();  // Close the form after submission
        }

        // Handle the Back button click
        private void back_button_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Populate the ComboBox with membership types
        private void PopulateMembershipTypes()
        {
            cmbMembershipType.Items.Clear();  // Clear previous items
            // Placeholder for the first item
            cmbMembershipType.Items.Add("Membership Type");

            // Add membership types with prices
            cmbMembershipType.Items.Add("Standard - $20");
            cmbMembershipType.Items.Add("Premium - $50");
            cmbMembershipType.Items.Add("Basic - $10");

            // Set default selected index to 0
            cmbMembershipType.SelectedIndex = 0;
        }

        // Automatically drop down the ComboBox on click
        private void cmbMembershipType_Click(object sender, EventArgs e)
        {
            if (cmbMembershipType.SelectedIndex == 0)
            {
                cmbMembershipType.DroppedDown = true;  // Show the dropdown options
            }
        }
    }
}

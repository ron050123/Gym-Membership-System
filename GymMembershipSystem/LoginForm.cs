using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace GymMembershipSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Set initial placeholder text for the password field
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.PasswordChar = '\0';  // Remove masking initially

            txtEmail.Text = "Email";
            txtEmail.ForeColor = Color.Gray;
            // Attach events
            txtPassword.GotFocus += RemovePasswordEncryption;
            txtPassword.LostFocus += SetPasswordEncryption;

            txtEmail.GotFocus += RemoveEmailEncryption;
            txtEmail.LostFocus += SetEmailEncyption;
        }

        private void SetPasswordEncryption(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.PasswordChar = '\0';  // Remove masking to show "Password"
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void RemovePasswordEncryption(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';  // Set the PasswordChar when user types
            }
        }

        private void SetEmailEncyption(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.PasswordChar = '\0';  // Remove masking to show "Password"
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void RemoveEmailEncryption(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;  // Get the password from the password TextBox
            bool userFound = false;

            if (password == "Password")  // Check if the user didn't change the placeholder
            {
                MessageBox.Show("Please enter a valid password.");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password == "Password")
            {
                MessageBox.Show("Please enter a valid password.");
                return;
            }

            //// Read all users from the users.txt file
            //string[] users = File.ReadAllLines("users.txt");
            //foreach (var user in users)
            //{
            //    string[] userData = user.Split(',');
            //    if (userData[2].Trim() == email && userData[3].Trim() == password)  // Check both email and password
            //    {
            //        userFound = true;
            //        MessageBox.Show($"Welcome {userData[1]}!");
            //        var dashboardForm = new DashboardForm(userData[0]);  // Pass user ID to dashboard
            //        dashboardForm.ShowDialog();
            //        this.Close();
            //    }
            //}

            //if (!userFound)
            //{
            //    MessageBox.Show("Incorrect email or password. Try again.");
            //}

            // Read all users from the users.txt file
            string[] users = File.ReadAllLines("users.txt");
            foreach (var user in users)
            {
                string[] userData = user.Split(',');

                // Check if the userData array has at least 4 elements (ID, Name, Email, Password)
                if (userData.Length >= 4)
                {
                    if (userData[2].Trim() == email && userData[3].Trim() == password)  // Check both email and password
                    {
                        userFound = true;
                        MessageBox.Show($"Welcome {userData[1]}!");
                        var dashboardForm = new DashboardForm(userData[0]);  // Pass user ID to dashboard
                        dashboardForm.ShowDialog();
                        this.Close();
                        break; // Break the loop once user is found
                    }
                }
                else
                {
                    // Handle the case where the line is malformed or missing data
                    MessageBox.Show($"Invalid user data found in users.txt: {user}");
                }
            }

            if (!userFound)
            {
                MessageBox.Show("Incorrect email or password. Try again.");
            }

        }

        private void back_buton_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
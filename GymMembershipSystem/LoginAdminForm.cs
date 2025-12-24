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
    public partial class LoginAdminForm : Form
    {
        public LoginAdminForm()
        {
            InitializeComponent();

            // Set initial placeholder text for the password field
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.PasswordChar = '\0';  // Remove masking initially

            txtID.Text = "Enter ID";
            txtID.ForeColor = Color.Gray;
            // Attach events
            txtPassword.GotFocus += RemovePasswordEncryption;
            txtPassword.LostFocus += SetPasswordEncryption;

            txtID.GotFocus += RemoveIDEncryption;
            txtID.LostFocus += SetIDEncyption;
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

        private void SetIDEncyption(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.PasswordChar = '\0';  // Remove masking to show "Password"
                txtID.Text = "Enter ID";
                txtID.ForeColor = Color.Gray;
            }
        }

        private void RemoveIDEncryption(object sender, EventArgs e)
        {
            if (txtID.Text == "Enter ID")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string userID = txtID.Text;
            string password = txtPassword.Text;  // Get the password from the password TextBox
            bool userFound = false;

            if (password == "Password")  // Check if the user didn't change the placeholder
            {
                MessageBox.Show("Please enter a valid password.");
                return;
            }

            if (string.IsNullOrWhiteSpace(userID))
            {
                MessageBox.Show("ID cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password == "Password")
            {
                MessageBox.Show("Please enter a valid password.");
                return;
            }

            // Read all users from the admins.txt file
            string[] admins = File.ReadAllLines("admins.txt");
            foreach (var admin in admins)
            {
                string[] userData = admin.Split(',');
                if (userData[0].Trim() == userID && userData[2].Trim() == password)  // Check both id and password
                {
                    userFound = true;
                    MessageBox.Show($"Welcome {userData[1]}!");
                    var adminForm = new AdminForm(userData[0]);  // Pass user ID to dashboard
                    adminForm.ShowDialog();
                    this.Close();
                }
            }

            if (!userFound)
            {
                MessageBox.Show("Incorrect ID or password. Try again.");
            }
        }

        private void back_buton_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
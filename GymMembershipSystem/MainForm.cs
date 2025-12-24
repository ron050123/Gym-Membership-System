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

namespace GymMembershipSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var signUpForm = new SignUpForm();
            signUpForm.ShowDialog();  // Open the sign-up form
        }

        private void btnLoginAsMember_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();  // Open the login form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Exit the application
        }


        private void btnLoginAsAdmin_Click(object sender, EventArgs e)
        {
            var loginAdminForm = new LoginAdminForm();
            loginAdminForm.ShowDialog();  // Open the login form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class DashboardForm : Form
    {
        private string userId;
        public DashboardForm(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnBookSession_Click(object sender, EventArgs e)
        {
            var bookSessionForm = new BookSessionForm(userId);
            bookSessionForm.ShowDialog();
        }

        private void btnViewSession_Click(object sender, EventArgs e)
        {
            var viewSessionForm = new ViewSessionForm(userId);
            viewSessionForm.ShowDialog();
        }

        private void btnChangeMembership_Click(object sender, EventArgs e)
        {
            var changeMembershipForm = new ChangeMembershipForm(userId);
            changeMembershipForm.ShowDialog();
        }

        private void btnViewProgress_Click(object sender, EventArgs e)
        {
            var progressForm = new ProgressForm(userId);
            progressForm.ShowDialog();
        }
        private void logout_button_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

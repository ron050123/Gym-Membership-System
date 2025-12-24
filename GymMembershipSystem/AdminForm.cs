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
    public partial class AdminForm : Form
    {
        private string trainersFile = "trainers.txt";
        private string userFile = "users.txt";
        private string userId;

        private IUserManagement userManagement;
        private ISessionManagement sessionManagement;

        public AdminForm(string userId)
        {
            InitializeComponent();
            userManagement = new UserManagement();
            sessionManagement = new SessionManagement();
            this.userId = userId;
            LoadTrainerDetails();
            LoadMemberDetails();
        }

        // Load Trainer Details into DataGridView
        private void LoadTrainerDetails()
        {
            // Clear existing rows and columns
            dataGridViewTrainers.Rows.Clear();
            dataGridViewTrainers.Columns.Clear();

            // Define columns for trainers (adjust according to your data)
            dataGridViewTrainers.Columns.Add("TrainerID", "ID");
            dataGridViewTrainers.Columns.Add("TrainerName", "Name");

            //if (File.Exists(trainersFile))
            //{
            //    string[] lines = File.ReadAllLines(trainersFile);
            //    foreach (string line in lines)
            //    {
            //        string[] trainerDetails = line.Split(',');
            //        dataGridViewTrainers.Rows.Add(trainerDetails);
            //    }
            //}
            string[] trainers = File.ReadAllLines("trainers.txt");
            dataGridViewTrainers.Rows.Clear();
            foreach (var trainer in trainers)
            {
                dataGridViewTrainers.Rows.Add(trainer.Split(','));
            }
        }


        // Load Member Details into DataGridView
        private void LoadMemberDetails()
        {
            // Clear existing rows and columns
            dataGridViewMembers.Rows.Clear();
            dataGridViewMembers.Columns.Clear();

            // Define columns for members (adjust according to your data)
            dataGridViewMembers.Columns.Add("UserID", "ID");
            dataGridViewMembers.Columns.Add("UserName", "Name");
            dataGridViewMembers.Columns.Add("UserEmail", "Email");
            dataGridViewMembers.Columns.Add("Password", "Password");
            dataGridViewMembers.Columns.Add("Type", "Membership Type");

            //if (File.Exists(userFile))
            //{
            //    string[] lines = File.ReadAllLines(userFile);
            //    foreach (string line in lines)
            //    {
            //        string[] userDetails = line.Split(',');
            //        dataGridViewMembers.Rows.Add(userDetails);
            //    }
            //}
            string[] members = File.ReadAllLines("users.txt");
            dataGridViewMembers.Rows.Clear();
            foreach (var member in members)
            {
                dataGridViewMembers.Rows.Add(member.Split(','));
            }
        }

        // Add Member Button Click Event
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            var signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            LoadMemberDetails();
        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            var addTrainerForm = new AddTrainersForm();
            addTrainerForm.ShowDialog(); 
            LoadTrainerDetails();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

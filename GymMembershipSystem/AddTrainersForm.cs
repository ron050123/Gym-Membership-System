using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GymMembershipSystem
{
    public partial class AddTrainersForm : Form
    {
        private string trainersFile = "trainers.txt";  // File to store trainer data

        public AddTrainersForm()
        {
            InitializeComponent();

            // Set initial placeholder text for the name and ID fields
            txtId.Text = "ID";
            txtId.ForeColor = Color.Gray;

            txtTrainerName.Text = "Trainer Name";
            txtTrainerName.ForeColor = Color.Gray;

            // Attach events for placeholders
            txtId.GotFocus += RemoveIDPlaceholder;
            txtId.LostFocus += SetIDPlaceholder;

            txtTrainerName.GotFocus += RemoveNamePlaceholder;
            txtTrainerName.LostFocus += SetNamePlaceholder;
        }

        // Placeholder for the ID field
        private void SetIDPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                txtId.Text = "ID";
                txtId.ForeColor = Color.Gray;
            }
        }

        private void RemoveIDPlaceholder(object sender, EventArgs e)
        {
            if (txtId.Text == "ID")
            {
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
            }
        }

        // Placeholder for the Trainer Name field
        private void SetNamePlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrainerName.Text))
            {
                txtTrainerName.Text = "Trainer Name";
                txtTrainerName.ForeColor = Color.Gray;
            }
        }

        private void RemoveNamePlaceholder(object sender, EventArgs e)
        {
            if (txtTrainerName.Text == "Trainer Name")
            {
                txtTrainerName.Text = "";
                txtTrainerName.ForeColor = Color.Black;
            }
        }

        // Event handler for the Submit button to add a trainer
        private void submit_button_Click(object sender, EventArgs e)
        {
            string trainerId = txtId.Text.Trim();  // Input for Trainer ID
            string trainerName = txtTrainerName.Text.Trim();  // Input for Trainer Name

            // Validate that the user entered both ID and Name
            if (string.IsNullOrEmpty(trainerId) || trainerId == "ID")
            {
                MessageBox.Show("Please enter a valid Trainer ID.");
                return;
            }

            if (string.IsNullOrEmpty(trainerName) || trainerName == "Trainer Name")
            {
                MessageBox.Show("Please enter a valid Trainer Name.");
                return;
            }

            // Check if the trainer ID already exists
            if (TrainerExists(trainerId))
            {
                MessageBox.Show("Trainer ID already exists. Please enter a different ID.");
                return;
            }

            // Save the trainer details to trainers.txt
            string newTrainer = $"{trainerId},{trainerName}";
            File.AppendAllText(trainersFile, newTrainer + Environment.NewLine);
            MessageBox.Show("Trainer added successfully!");

            // Optionally clear the form after successful submission
            ClearForm();
        }

        // Check if trainer ID already exists
        private bool TrainerExists(string trainerId)
        {
            if (File.Exists(trainersFile))
            {
                string[] trainers = File.ReadAllLines(trainersFile);
                foreach (var trainer in trainers)
                {
                    string[] trainerDetails = trainer.Split(',');
                    if (trainerDetails.Length > 1 && trainerDetails[0].Trim() == trainerId)
                    {
                        return true;  // Trainer ID already exists
                    }
                }
            }
            return false;
        }

        // Clear the input fields after a successful addition
        private void ClearForm()
        {
            txtId.Text = "ID";  // Reset to placeholder
            txtId.ForeColor = Color.Gray;

            txtTrainerName.Text = "Trainer Name";  // Reset to placeholder
            txtTrainerName.ForeColor = Color.Gray;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the form if the user clicks Cancel
        }
    }
}

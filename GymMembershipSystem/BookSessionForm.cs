using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Collections.Specialized.BitVector32;

namespace GymMembershipSystem
{
    public partial class BookSessionForm : Form
    {
        private ISessionManagement sessionManagement;
        private string userId;

        public BookSessionForm(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            sessionManagement = new SessionManagement();

            // Set the ComboBox styles to DropDownList to prevent typing
            cmbTrainers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGymSessions.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTimeSlots.DropDownStyle = ComboBoxStyle.DropDownList;  // ComboBox for available time slots

            // Add placeholder text for ComboBoxes
            cmbTrainers.Items.Add("Select Trainer");  // Placeholder for Trainers ComboBox
            cmbGymSessions.Items.Add("Select Training Session");  // Placeholder for GymSessions ComboBox
            cmbTimeSlots.Items.Add("Select Time Slot");  // Placeholder for Time Slot ComboBox

            LoadTrainers();
            LoadGymSessions();
            LoadTimeSlots();  // Populate time slots

            // Set default selected index to 0 for the placeholder
            cmbTrainers.SelectedIndex = 0;
            cmbGymSessions.SelectedIndex = 0;
            cmbTimeSlots.SelectedIndex = 0;
        }

        // Load available trainers from a file or a predefined list
        private void LoadTrainers()
        {
            if (File.Exists("trainers.txt"))
            {
                string[] trainers = File.ReadAllLines("trainers.txt");
                foreach (var trainer in trainers)
                {
                    string[] trainerData = trainer.Split(',');

                    // Ensure the trainer data has at least two parts
                    if (trainerData.Length > 1)
                    {
                        cmbTrainers.Items.Add(trainerData[1]);  // Add trainer name to ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Invalid data format in trainers.txt. Each line should contain both ID and name separated by a comma.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Trainer data file not found.");
            }
        }

        // Load available gym sessions from a file or a predefined list
        private void LoadGymSessions()
        {
            if (File.Exists("gym_sessions.txt"))
            {
                string[] gym_sessions = File.ReadAllLines("gym_sessions.txt");
                foreach (var gym_session in gym_sessions)
                {
                    string[] gymSessionData = gym_session.Split(',');
                    cmbGymSessions.Items.Add(gymSessionData[0]);
                }
            }
            else
            {
                MessageBox.Show("Gym Session data file not found.");
            }
        }

        // Load available time slots from 9 AM to 6 PM into the ComboBox
        private void LoadTimeSlots()
        {
            string[] timeSlots = {
                "09:00 AM", "10:00 AM", "11:00 AM", "12:00 PM",
                "01:00 PM", "02:00 PM", "03:00 PM", "04:00 PM",
                "05:00 PM", "06:00 PM"
            };

            cmbTimeSlots.Items.AddRange(timeSlots);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            // Check if the user has selected valid options (not the placeholder)
            if (cmbTrainers.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid trainer.");
                return;
            }

            if (cmbGymSessions.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid gym session.");
                return;
            }

            if (cmbTimeSlots.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid time slot.");
                return;
            }

            string selectedTrainer = cmbTrainers.SelectedItem.ToString();  // Get selected trainer
            string selectedSession = cmbGymSessions.SelectedItem.ToString();  // Get selected session
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string selectedTimeSlot = cmbTimeSlots.SelectedItem.ToString();  // Get selected time slot

            // Generate new session ID
            int newSessionId = File.Exists("sessions.txt") ? File.ReadAllLines("sessions.txt").Length + 1 : 1;

            // Save the session details including the trainer, gym session, date, and time
            string newSession = $"{newSessionId}, {userId}, {selectedTrainer}, {selectedSession}, {date}, {selectedTimeSlot}";
            File.AppendAllText("sessions.txt", newSession + Environment.NewLine);
            MessageBox.Show("Session booked successfully!");

            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

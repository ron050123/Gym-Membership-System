using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GymMembershipSystem
{
    public partial class ViewSessionForm : Form
    {
        private string userId;

        public ViewSessionForm(string userId)
        {
            InitializeComponent();
            this.userId = userId;

            dgvSessions = new DataGridView();
            dgvSessions.Location = new System.Drawing.Point(12, 12);  // Set position
            dgvSessions.Size = new System.Drawing.Size(400, 200);  // Set size
            dgvSessions.ColumnCount = 4;  // Define 4 columns

            dgvSessions.ReadOnly = true;  // Make it read-only
            dgvSessions.AllowUserToAddRows = false;  // Disable adding rows

            // Add the DataGridView to the form's controls
            this.Controls.Add(dgvSessions);

            // Initialize DataGridView columns
            InitializeDataGridView();

            // Automatically load sessions when the form opens
            LoadUserSessions();
        }

        private void InitializeDataGridView()
        {
            // Setup columns for the DataGridView
            dgvSessions.ColumnCount = 4;
            dgvSessions.Columns[0].Name = "Trainer Name";
            dgvSessions.Columns[1].Name = "Session";
            dgvSessions.Columns[2].Name = "Date";
            dgvSessions.Columns[3].Name = "Time";

            // Set the DataGridView to read-only
            dgvSessions.ReadOnly = true;
            dgvSessions.AllowUserToAddRows = false;  // Disallow the user from adding rows
        }

        private void btnViewSessions_Click(object sender, EventArgs e)
        {
            LoadUserSessions();  // Call to load sessions when the button is clicked
        }

        private void LoadUserSessions()
        {
            // Clear existing rows before loading new sessions
            dgvSessions.Rows.Clear();

            if (File.Exists("sessions.txt"))
            {
                // Read all sessions from the file
                string[] sessions = File.ReadAllLines("sessions.txt");

                // Iterate over each session and filter by userId
                foreach (var session in sessions)
                {
                    string[] sessionData = session.Split(',');

                    // Assuming session format: sessionId, userId, trainer, session, date, time, status
                    if (sessionData.Length >= 6 && sessionData[1].Trim() == userId)  // Check if userId matches
                    {
                        // Format the session details to display
                        string trainer = sessionData[2].Trim();
                        string sessionType = sessionData[3].Trim();
                        string sessionDate = sessionData[4].Trim();
                        string sessionTime = sessionData[5].Trim();

                        // Add the session details to the DataGridView
                        dgvSessions.Rows.Add(trainer, sessionType, sessionDate, sessionTime);
                    }
                }

                // If no sessions were found for the user, display a message
                if (dgvSessions.Rows.Count == 0)
                {
                    MessageBox.Show("No sessions booked yet.");
                }
            }
            else
            {
                MessageBox.Show("No session data found.");
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the form to return to the previous screen
        }

        private DataGridView dgvSessions;
    }
}

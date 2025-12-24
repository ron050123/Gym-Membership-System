using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GymMembershipSystem
{
    public partial class ProgressForm : Form
    {
        private string userId;
        private int totalSessions = 20;  // Define the target number of sessions for full progress
        //private ISessionManagement sessionManagement;

        public ProgressForm(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            //sessionManagement = new SessionManagement();
            DisplayProgress();
        }

        private void DisplayProgress()
        {
            //var sessions = sessionManagement.GetUserSessions(userId);
            int bookedSessionsCount = CountBookedSessions();  // Calculate how many sessions the user has booked
            float progressPercentage = (float)bookedSessionsCount / totalSessions * 100;  // Calculate progress percentage

            // Update the progress bar by drawing the circle based on progressPercentage
            DrawCircularProgress(progressPercentage);

            // Update the session count label and grey out the text
            lblProgress.ForeColor = Color.Gray;  // Make the label grey
            lblProgress.Text = $"Sessions Completed: {bookedSessionsCount}/{totalSessions}";

            // Make the label untouchable
            lblProgress.Enabled = false;

            // Set the label font size and style
            lblProgress.Font = new Font(lblProgress.Font.FontFamily, 7, FontStyle.Bold);  // Increase font size to 14 and make it bold

            // Manually set the size of the label
            lblProgress.Size = new Size(150, 40);  // Set width to 300 and height to 40
            // Ensure the label auto-sizes to fit the full text
            lblProgress.AutoSize = true;
        }


        // Count the number of sessions the user has booked from the sessions.txt file
        private int CountBookedSessions()
        {
            if (!File.Exists("sessions.txt")) return 0;

            string[] sessions = File.ReadAllLines("sessions.txt");
            int count = 0;

            foreach (var session in sessions)
            {
                // Skip empty or malformed lines
                if (string.IsNullOrWhiteSpace(session))
                    continue;

                // Split the line by commas
                string[] sessionData = session.Split(',');

                // Ensure the line has at least 2 elements (e.g., sessionId and userId)
                if (sessionData.Length < 2)
                    continue;

                // Check if the userId matches
                if (sessionData[1].Trim() == userId)
                {
                    count++;  // Increment the count of sessions for this user
                }

                // Ensure the line has the user ID and session details
                //if (sessionData.Length >= 6 && sessionData[1].Trim() == userId)
                //{
                //    count++;
                //}
            }

            return count;
        }

        // Draw the circular progress bar on a Panel or PictureBox
        private void DrawCircularProgress(float percentage)
        {
            // Assuming you have a PictureBox named "pictureBoxProgress"
            int radius = 75;  // Adjusted to make the circle smaller
            int thickness = 10;  // Reduced thickness for a cleaner look

            // Create a Bitmap to draw on
            Bitmap bitmap = new Bitmap(pictureBoxProgress.Width, pictureBoxProgress.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Draw the background circle (grey) representing the uncompleted portion
                using (Pen backgroundPen = new Pen(Color.LightGray, thickness))
                {
                    g.DrawArc(backgroundPen, new Rectangle(thickness, thickness, radius * 2, radius * 2), 0, 360);
                }

                // Draw the progress circle (green) representing the completed portion
                using (Pen progressPen = new Pen(Color.Green, thickness))
                {
                    float sweepAngle = percentage * 360 / 100;  // Calculate the angle based on the percentage
                    g.DrawArc(progressPen, new Rectangle(thickness, thickness, radius * 2, radius * 2), -90, sweepAngle);  // Starts from top center
                }
            }

            // Set the PictureBox image to the bitmap we drew on
            pictureBoxProgress.Image = bitmap;
        }

        private void back_button_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

namespace GymMembershipSystem
{
    partial class BookSessionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTrainers = new System.Windows.Forms.ComboBox();
            this.cmbGymSessions = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTimeSlots = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTrainers
            // 
            this.cmbTrainers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTrainers.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrainers.FormattingEnabled = true;
            this.cmbTrainers.Location = new System.Drawing.Point(120, 34);
            this.cmbTrainers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTrainers.Name = "cmbTrainers";
            this.cmbTrainers.Size = new System.Drawing.Size(295, 33);
            this.cmbTrainers.TabIndex = 0;
            this.cmbTrainers.Text = "Available Trainers";
            // 
            // cmbGymSessions
            // 
            this.cmbGymSessions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGymSessions.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGymSessions.FormattingEnabled = true;
            this.cmbGymSessions.Location = new System.Drawing.Point(120, 87);
            this.cmbGymSessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGymSessions.Name = "cmbGymSessions";
            this.cmbGymSessions.Size = new System.Drawing.Size(295, 33);
            this.cmbGymSessions.TabIndex = 1;
            this.cmbGymSessions.Text = "Gym Session Types";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(63, 144);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(388, 38);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.Value = new System.DateTime(2024, 10, 14, 19, 2, 0, 0);
            // 
            // btnBook
            // 
            this.btnBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBook.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(155, 269);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(203, 33);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back_button.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(15, 599);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(125, 33);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 81);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book A Session";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 76);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.cmbTimeSlots);
            this.panel2.Controls.Add(this.cmbTrainers);
            this.panel2.Controls.Add(this.cmbGymSessions);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.btnBook);
            this.panel2.Location = new System.Drawing.Point(271, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 347);
            this.panel2.TabIndex = 8;
            // 
            // cmbTimeSlots
            // 
            this.cmbTimeSlots.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeSlots.FormattingEnabled = true;
            this.cmbTimeSlots.Location = new System.Drawing.Point(120, 205);
            this.cmbTimeSlots.Name = "cmbTimeSlots";
            this.cmbTimeSlots.Size = new System.Drawing.Size(295, 31);
            this.cmbTimeSlots.TabIndex = 5;
            this.cmbTimeSlots.Text = "Select Time Slot";
            // 
            // BookSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymMembershipSystem.Properties.Resources._360_F_317724775_qHtWjnT8YbRdFNIuq5PWsSYypRhOmalS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookSessionForm";
            this.Text = "Book Session";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTrainers;
        private System.Windows.Forms.ComboBox cmbGymSessions;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbTimeSlots;
    }
}
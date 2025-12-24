namespace GymMembershipSystem
{
    partial class DashboardForm
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
            this.btnBookSession = new System.Windows.Forms.Button();
            this.btnChangeMembership = new System.Windows.Forms.Button();
            this.btnViewProgress = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewSession = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookSession
            // 
            this.btnBookSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBookSession.AutoSize = true;
            this.btnBookSession.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSession.Location = new System.Drawing.Point(11, 164);
            this.btnBookSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBookSession.Name = "btnBookSession";
            this.btnBookSession.Size = new System.Drawing.Size(170, 30);
            this.btnBookSession.TabIndex = 0;
            this.btnBookSession.Text = "Book Session";
            this.btnBookSession.UseVisualStyleBackColor = true;
            this.btnBookSession.Click += new System.EventHandler(this.btnBookSession_Click);
            // 
            // btnChangeMembership
            // 
            this.btnChangeMembership.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeMembership.AutoSize = true;
            this.btnChangeMembership.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMembership.Location = new System.Drawing.Point(11, 225);
            this.btnChangeMembership.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeMembership.Name = "btnChangeMembership";
            this.btnChangeMembership.Size = new System.Drawing.Size(170, 30);
            this.btnChangeMembership.TabIndex = 1;
            this.btnChangeMembership.Text = "Change Membership";
            this.btnChangeMembership.UseVisualStyleBackColor = true;
            this.btnChangeMembership.Click += new System.EventHandler(this.btnChangeMembership_Click);
            // 
            // btnViewProgress
            // 
            this.btnViewProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewProgress.AutoSize = true;
            this.btnViewProgress.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProgress.Location = new System.Drawing.Point(11, 195);
            this.btnViewProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewProgress.Name = "btnViewProgress";
            this.btnViewProgress.Size = new System.Drawing.Size(170, 30);
            this.btnViewProgress.TabIndex = 2;
            this.btnViewProgress.Text = "View Progress";
            this.btnViewProgress.UseVisualStyleBackColor = true;
            this.btnViewProgress.Click += new System.EventHandler(this.btnViewProgress_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // btnViewSession
            // 
            this.btnViewSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewSession.AutoSize = true;
            this.btnViewSession.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSession.Location = new System.Drawing.Point(11, 256);
            this.btnViewSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewSession.Name = "btnViewSession";
            this.btnViewSession.Size = new System.Drawing.Size(170, 30);
            this.btnViewSession.TabIndex = 7;
            this.btnViewSession.Text = "View Session";
            this.btnViewSession.UseVisualStyleBackColor = true;
            this.btnViewSession.Click += new System.EventHandler(this.btnViewSession_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(338, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 65);
            this.label1.TabIndex = 8;
            this.label1.Text = "DASHBOARD";
            // 
            // logout_button
            // 
            this.logout_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logout_button.AutoSize = true;
            this.logout_button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.Location = new System.Drawing.Point(0, 441);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(100, 30);
            this.logout_button.TabIndex = 9;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 74);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnBookSession);
            this.panel2.Controls.Add(this.btnChangeMembership);
            this.panel2.Controls.Add(this.logout_button);
            this.panel2.Controls.Add(this.btnViewProgress);
            this.panel2.Controls.Add(this.btnViewSession);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 473);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(11, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 69);
            this.panel3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "GymRatz";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymMembershipSystem.Properties.Resources.man_2604149_1280;
            this.ClientSize = new System.Drawing.Size(1014, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookSession;
        private System.Windows.Forms.Button btnChangeMembership;
        private System.Windows.Forms.Button btnViewProgress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button btnViewSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}
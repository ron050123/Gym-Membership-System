namespace GymMembershipSystem
{
    partial class MainForm
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLoginAsMember = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoginAsAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(258, 222);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(143, 30);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLoginAsMember
            // 
            this.btnLoginAsMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoginAsMember.AutoSize = true;
            this.btnLoginAsMember.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAsMember.Location = new System.Drawing.Point(258, 191);
            this.btnLoginAsMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoginAsMember.Name = "btnLoginAsMember";
            this.btnLoginAsMember.Size = new System.Drawing.Size(143, 30);
            this.btnLoginAsMember.TabIndex = 0;
            this.btnLoginAsMember.Text = "Login As Member";
            this.btnLoginAsMember.UseVisualStyleBackColor = true;
            this.btnLoginAsMember.Click += new System.EventHandler(this.btnLoginAsMember_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(258, 255);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoginAsAdmin
            // 
            this.btnLoginAsAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoginAsAdmin.AutoSize = true;
            this.btnLoginAsAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAsAdmin.Location = new System.Drawing.Point(258, 158);
            this.btnLoginAsAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoginAsAdmin.Name = "btnLoginAsAdmin";
            this.btnLoginAsAdmin.Size = new System.Drawing.Size(143, 30);
            this.btnLoginAsAdmin.TabIndex = 1;
            this.btnLoginAsAdmin.Text = "Login As Admin";
            this.btnLoginAsAdmin.UseVisualStyleBackColor = true;
            this.btnLoginAsAdmin.Click += new System.EventHandler(this.btnLoginAsAdmin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to GymRatz!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 100);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(657, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoginAsMember);
            this.Controls.Add(this.btnLoginAsAdmin);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Welcome!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoginAsMember;
        private System.Windows.Forms.Button btnLoginAsAdmin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace GymMembershipSystem
{
    partial class LoginAdminForm
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
            this.submit_button = new System.Windows.Forms.Button();
            this.back_buton_Click = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submit_button
            // 
            this.submit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit_button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(286, 218);
            this.submit_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(77, 31);
            this.submit_button.TabIndex = 0;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // back_buton_Click
            // 
            this.back_buton_Click.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_buton_Click.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_buton_Click.Location = new System.Drawing.Point(205, 218);
            this.back_buton_Click.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_buton_Click.Name = "back_buton_Click";
            this.back_buton_Click.Size = new System.Drawing.Size(77, 31);
            this.back_buton_Click.TabIndex = 1;
            this.back_buton_Click.Text = "Back";
            this.back_buton_Click.UseVisualStyleBackColor = true;
            this.back_buton_Click.Click += new System.EventHandler(this.back_buton_Click_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(225, 146);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 27);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "Enter ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(225, 177);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(120, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 88);
            this.panel1.TabIndex = 5;
            // 
            // LoginAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.back_buton_Click);
            this.Controls.Add(this.submit_button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginAdminForm";
            this.Text = "Admin Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button back_buton_Click;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace GymMembershipSystem
{
    partial class LoginForm
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.back_buton_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(232, 128);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 27);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(232, 159);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            // 
            // submit_button
            // 
            this.submit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit_button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(292, 200);
            this.submit_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(85, 29);
            this.submit_button.TabIndex = 2;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // back_buton_Click
            // 
            this.back_buton_Click.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_buton_Click.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_buton_Click.Location = new System.Drawing.Point(203, 200);
            this.back_buton_Click.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_buton_Click.Name = "back_buton_Click";
            this.back_buton_Click.Size = new System.Drawing.Size(85, 29);
            this.back_buton_Click.TabIndex = 3;
            this.back_buton_Click.Text = "Back";
            this.back_buton_Click.UseVisualStyleBackColor = true;
            this.back_buton_Click.Click += new System.EventHandler(this.back_buton_Click_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Member Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 79);
            this.panel1.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_buton_Click);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Member Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button back_buton_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
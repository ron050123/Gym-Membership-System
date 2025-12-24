namespace GymMembershipSystem
{
    partial class ChangeMembershipForm
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
            this.cmbCurrentMembershipType = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNewMembershipType = new System.Windows.Forms.ComboBox();
            this.back_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCurrentMembershipType
            // 
            this.cmbCurrentMembershipType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCurrentMembershipType.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurrentMembershipType.FormattingEnabled = true;
            this.cmbCurrentMembershipType.Location = new System.Drawing.Point(408, 129);
            this.cmbCurrentMembershipType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCurrentMembershipType.Name = "cmbCurrentMembershipType";
            this.cmbCurrentMembershipType.Size = new System.Drawing.Size(180, 24);
            this.cmbCurrentMembershipType.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChange.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(503, 207);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(104, 42);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "CONFIRM";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHANGE MEMBERSHIP";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(47, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose your current membership type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(47, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose your new membership type";
            // 
            // cmbNewMembershipType
            // 
            this.cmbNewMembershipType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNewMembershipType.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNewMembershipType.FormattingEnabled = true;
            this.cmbNewMembershipType.Location = new System.Drawing.Point(408, 171);
            this.cmbNewMembershipType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbNewMembershipType.Name = "cmbNewMembershipType";
            this.cmbNewMembershipType.Size = new System.Drawing.Size(180, 24);
            this.cmbNewMembershipType.TabIndex = 5;
            // 
            // back_button
            // 
            this.back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(392, 207);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(104, 42);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 80);
            this.panel1.TabIndex = 8;
            // 
            // ChangeMembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(760, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.cmbNewMembershipType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.cmbCurrentMembershipType);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeMembershipForm";
            this.Text = "Change Membership";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCurrentMembershipType;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNewMembershipType;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Panel panel1;
    }
}
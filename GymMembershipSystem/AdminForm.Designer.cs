namespace GymMembershipSystem
{
    partial class AdminForm
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
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnAddTrainer = new System.Windows.Forms.Button();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTrainers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddMember.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(201, 524);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(186, 46);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "Add Members";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTrainer.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrainer.Location = new System.Drawing.Point(830, 524);
            this.btnAddTrainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTrainer.Name = "btnAddTrainer";
            this.btnAddTrainer.Size = new System.Drawing.Size(186, 46);
            this.btnAddTrainer.TabIndex = 1;
            this.btnAddTrainer.Text = "Add Trainers";
            this.btnAddTrainer.UseVisualStyleBackColor = true;
            this.btnAddTrainer.Click += new System.EventHandler(this.btnAddTrainer_Click);
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(11, 83);
            this.dataGridViewMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.RowHeadersWidth = 51;
            this.dataGridViewMembers.RowTemplate.Height = 24;
            this.dataGridViewMembers.Size = new System.Drawing.Size(599, 437);
            this.dataGridViewMembers.TabIndex = 2;
            // 
            // dataGridViewTrainers
            // 
            this.dataGridViewTrainers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainers.Location = new System.Drawing.Point(614, 83);
            this.dataGridViewTrainers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTrainers.Name = "dataGridViewTrainers";
            this.dataGridViewTrainers.RowHeadersWidth = 51;
            this.dataGridViewTrainers.RowTemplate.Height = 24;
            this.dataGridViewTrainers.Size = new System.Drawing.Size(582, 437);
            this.dataGridViewTrainers.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Member Details";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trainer Details";
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back_button.AutoSize = true;
            this.back_button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(11, 568);
            this.back_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(68, 36);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 66);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Plum;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(616, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 66);
            this.panel2.TabIndex = 8;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1207, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dataGridViewTrainers);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.btnAddTrainer);
            this.Controls.Add(this.btnAddMember);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "Admin Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnAddTrainer;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.DataGridView dataGridViewTrainers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace GymMembershipSystem
{
    partial class AddTrainersForm
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
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrainerName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainerName.Location = new System.Drawing.Point(221, 175);
            this.txtTrainerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(146, 27);
            this.txtTrainerName.TabIndex = 0;
            this.txtTrainerName.Text = "Trainer Name";
            // 
            // submit_button
            // 
            this.submit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit_button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(296, 224);
            this.submit_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(82, 29);
            this.submit_button.TabIndex = 2;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(221, 144);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(146, 27);
            this.txtId.TabIndex = 3;
            this.txtId.Text = "ID";
            // 
            // back_button
            // 
            this.back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(210, 224);
            this.back_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(82, 29);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add a Trainer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 89);
            this.panel1.TabIndex = 6;
            // 
            // AddTrainersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.txtTrainerName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddTrainersForm";
            this.Text = "Add Trainers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
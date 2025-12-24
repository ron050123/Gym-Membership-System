namespace GymMembershipSystem
{
    partial class ProgressForm
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
            this.pictureBoxProgress = new System.Windows.Forms.PictureBox();
            this.lblProgress = new System.Windows.Forms.TextBox();
            this.back_button_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProgress
            // 
            this.pictureBoxProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxProgress.Location = new System.Drawing.Point(240, 50);
            this.pictureBoxProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProgress.Name = "pictureBoxProgress";
            this.pictureBoxProgress.Size = new System.Drawing.Size(220, 220);
            this.pictureBoxProgress.TabIndex = 0;
            this.pictureBoxProgress.TabStop = false;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProgress.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(223, 276);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(280, 38);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "Sessions Completed: 0/20";
            // 
            // back_button_Click
            // 
            this.back_button_Click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back_button_Click.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button_Click.Location = new System.Drawing.Point(16, 359);
            this.back_button_Click.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_button_Click.Name = "back_button_Click";
            this.back_button_Click.Size = new System.Drawing.Size(100, 34);
            this.back_button_Click.TabIndex = 2;
            this.back_button_Click.Text = "Back";
            this.back_button_Click.UseVisualStyleBackColor = true;
            this.back_button_Click.Click += new System.EventHandler(this.back_button_Click_Click);
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(697, 409);
            this.Controls.Add(this.back_button_Click);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pictureBoxProgress);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProgressForm";
            this.Text = "Progress Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProgress;
        private System.Windows.Forms.TextBox lblProgress;
        private System.Windows.Forms.Button back_button_Click;
    }
}
namespace FootballManager.Presentation.INSERT.Forms
{
    partial class InsertTeams
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textInsertTeamName = new System.Windows.Forms.TextBox();
            this.textInsertTeamClubID = new System.Windows.Forms.TextBox();
            this.InsertTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ClubID";
            // 
            // textInsertTeamName
            // 
            this.textInsertTeamName.Location = new System.Drawing.Point(181, 140);
            this.textInsertTeamName.Name = "textInsertTeamName";
            this.textInsertTeamName.Size = new System.Drawing.Size(141, 20);
            this.textInsertTeamName.TabIndex = 2;
            // 
            // textInsertTeamClubID
            // 
            this.textInsertTeamClubID.Location = new System.Drawing.Point(181, 186);
            this.textInsertTeamClubID.Name = "textInsertTeamClubID";
            this.textInsertTeamClubID.Size = new System.Drawing.Size(141, 20);
            this.textInsertTeamClubID.TabIndex = 3;
            // 
            // InsertTeam
            // 
            this.InsertTeam.Location = new System.Drawing.Point(213, 212);
            this.InsertTeam.Name = "InsertTeam";
            this.InsertTeam.Size = new System.Drawing.Size(75, 23);
            this.InsertTeam.TabIndex = 4;
            this.InsertTeam.Text = "Insert";
            this.InsertTeam.UseVisualStyleBackColor = true;
            this.InsertTeam.Click += new System.EventHandler(this.InsertTeam_Click);
            // 
            // InsertTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertTeam);
            this.Controls.Add(this.textInsertTeamClubID);
            this.Controls.Add(this.textInsertTeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertTeams";
            this.Text = "InsertTeams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textInsertTeamName;
        private System.Windows.Forms.TextBox textInsertTeamClubID;
        private System.Windows.Forms.Button InsertTeam;
    }
}
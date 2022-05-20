namespace FootballManager.Presentation.INSERT.Forms
{
    partial class InsertCoaches
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textInsertCoachTeamID = new System.Windows.Forms.TextBox();
            this.textInsertCoachLastName = new System.Windows.Forms.TextBox();
            this.textInsertCoachName = new System.Windows.Forms.TextBox();
            this.textInsertCoachBirthdate = new System.Windows.Forms.TextBox();
            this.textInsertCoachType = new System.Windows.Forms.TextBox();
            this.InsertCoach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TeamID";
            // 
            // textInsertCoachTeamID
            // 
            this.textInsertCoachTeamID.Location = new System.Drawing.Point(203, 227);
            this.textInsertCoachTeamID.Name = "textInsertCoachTeamID";
            this.textInsertCoachTeamID.Size = new System.Drawing.Size(148, 20);
            this.textInsertCoachTeamID.TabIndex = 5;
            // 
            // textInsertCoachLastName
            // 
            this.textInsertCoachLastName.Location = new System.Drawing.Point(203, 135);
            this.textInsertCoachLastName.Name = "textInsertCoachLastName";
            this.textInsertCoachLastName.Size = new System.Drawing.Size(148, 20);
            this.textInsertCoachLastName.TabIndex = 6;
            // 
            // textInsertCoachName
            // 
            this.textInsertCoachName.Location = new System.Drawing.Point(203, 104);
            this.textInsertCoachName.Name = "textInsertCoachName";
            this.textInsertCoachName.Size = new System.Drawing.Size(148, 20);
            this.textInsertCoachName.TabIndex = 7;
            // 
            // textInsertCoachBirthdate
            // 
            this.textInsertCoachBirthdate.Location = new System.Drawing.Point(203, 196);
            this.textInsertCoachBirthdate.Name = "textInsertCoachBirthdate";
            this.textInsertCoachBirthdate.Size = new System.Drawing.Size(148, 20);
            this.textInsertCoachBirthdate.TabIndex = 8;
            // 
            // textInsertCoachType
            // 
            this.textInsertCoachType.Location = new System.Drawing.Point(203, 167);
            this.textInsertCoachType.Name = "textInsertCoachType";
            this.textInsertCoachType.Size = new System.Drawing.Size(148, 20);
            this.textInsertCoachType.TabIndex = 9;
            // 
            // InsertCoach
            // 
            this.InsertCoach.Location = new System.Drawing.Point(237, 262);
            this.InsertCoach.Name = "InsertCoach";
            this.InsertCoach.Size = new System.Drawing.Size(75, 23);
            this.InsertCoach.TabIndex = 10;
            this.InsertCoach.Text = "Insert";
            this.InsertCoach.UseVisualStyleBackColor = true;
            this.InsertCoach.Click += new System.EventHandler(this.InsertCoach_Click);
            // 
            // InsertCoaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertCoach);
            this.Controls.Add(this.textInsertCoachType);
            this.Controls.Add(this.textInsertCoachBirthdate);
            this.Controls.Add(this.textInsertCoachName);
            this.Controls.Add(this.textInsertCoachLastName);
            this.Controls.Add(this.textInsertCoachTeamID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertCoaches";
            this.Text = "InsertCoaches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textInsertCoachTeamID;
        private System.Windows.Forms.TextBox textInsertCoachLastName;
        private System.Windows.Forms.TextBox textInsertCoachName;
        private System.Windows.Forms.TextBox textInsertCoachBirthdate;
        private System.Windows.Forms.TextBox textInsertCoachType;
        private System.Windows.Forms.Button InsertCoach;
    }
}
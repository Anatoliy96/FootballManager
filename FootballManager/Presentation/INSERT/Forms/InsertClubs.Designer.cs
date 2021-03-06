namespace FootballManager.Presentation.INSERT.Forms
{
    partial class InsertClubs
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
            this.textInsertClubName = new System.Windows.Forms.TextBox();
            this.textInsertClubOwner = new System.Windows.Forms.TextBox();
            this.dateTimePickerInsertFounded = new System.Windows.Forms.DateTimePicker();
            this.buttonInsertClub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Founded";
            // 
            // textInsertClubName
            // 
            this.textInsertClubName.Location = new System.Drawing.Point(199, 110);
            this.textInsertClubName.Name = "textInsertClubName";
            this.textInsertClubName.Size = new System.Drawing.Size(158, 20);
            this.textInsertClubName.TabIndex = 3;
            // 
            // textInsertClubOwner
            // 
            this.textInsertClubOwner.Location = new System.Drawing.Point(199, 163);
            this.textInsertClubOwner.Name = "textInsertClubOwner";
            this.textInsertClubOwner.Size = new System.Drawing.Size(158, 20);
            this.textInsertClubOwner.TabIndex = 4;
            // 
            // dateTimePickerInsertFounded
            // 
            this.dateTimePickerInsertFounded.Location = new System.Drawing.Point(199, 213);
            this.dateTimePickerInsertFounded.Name = "dateTimePickerInsertFounded";
            this.dateTimePickerInsertFounded.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerInsertFounded.TabIndex = 5;
            // 
            // buttonInsertClub
            // 
            this.buttonInsertClub.Location = new System.Drawing.Point(237, 239);
            this.buttonInsertClub.Name = "buttonInsertClub";
            this.buttonInsertClub.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertClub.TabIndex = 6;
            this.buttonInsertClub.Text = "Insert";
            this.buttonInsertClub.UseVisualStyleBackColor = true;
            this.buttonInsertClub.Click += new System.EventHandler(this.buttonInsertClub_Click);
            // 
            // InsertClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInsertClub);
            this.Controls.Add(this.dateTimePickerInsertFounded);
            this.Controls.Add(this.textInsertClubOwner);
            this.Controls.Add(this.textInsertClubName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertClubs";
            this.Text = "InsertClubs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textInsertClubName;
        private System.Windows.Forms.TextBox textInsertClubOwner;
        private System.Windows.Forms.DateTimePicker dateTimePickerInsertFounded;
        private System.Windows.Forms.Button buttonInsertClub;
    }
}
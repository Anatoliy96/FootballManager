namespace FootballManager.Presentation.INSERT.Forms
{
    partial class InsertRatings
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
            this.textInsertRatingsTeamID = new System.Windows.Forms.TextBox();
            this.textInsertRatingsBookMakerID = new System.Windows.Forms.TextBox();
            this.textRatingsDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertRatings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textInsertRatingsTeamID
            // 
            this.textInsertRatingsTeamID.Location = new System.Drawing.Point(200, 170);
            this.textInsertRatingsTeamID.Name = "textInsertRatingsTeamID";
            this.textInsertRatingsTeamID.Size = new System.Drawing.Size(162, 20);
            this.textInsertRatingsTeamID.TabIndex = 0;
            // 
            // textInsertRatingsBookMakerID
            // 
            this.textInsertRatingsBookMakerID.Location = new System.Drawing.Point(200, 139);
            this.textInsertRatingsBookMakerID.Name = "textInsertRatingsBookMakerID";
            this.textInsertRatingsBookMakerID.Size = new System.Drawing.Size(162, 20);
            this.textInsertRatingsBookMakerID.TabIndex = 1;
            // 
            // textRatingsDate
            // 
            this.textRatingsDate.Location = new System.Drawing.Point(200, 200);
            this.textRatingsDate.Name = "textRatingsDate";
            this.textRatingsDate.Size = new System.Drawing.Size(162, 20);
            this.textRatingsDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BookMakerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TeamID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // btnInsertRatings
            // 
            this.btnInsertRatings.Location = new System.Drawing.Point(243, 226);
            this.btnInsertRatings.Name = "btnInsertRatings";
            this.btnInsertRatings.Size = new System.Drawing.Size(75, 23);
            this.btnInsertRatings.TabIndex = 6;
            this.btnInsertRatings.Text = "Insert";
            this.btnInsertRatings.UseVisualStyleBackColor = true;
            // 
            // InsertRatings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertRatings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRatingsDate);
            this.Controls.Add(this.textInsertRatingsBookMakerID);
            this.Controls.Add(this.textInsertRatingsTeamID);
            this.Name = "InsertRatings";
            this.Text = "InsertRatings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInsertRatingsTeamID;
        private System.Windows.Forms.TextBox textInsertRatingsBookMakerID;
        private System.Windows.Forms.TextBox textRatingsDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertRatings;
    }
}
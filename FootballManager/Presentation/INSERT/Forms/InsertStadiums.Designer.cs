namespace FootballManager.Presentation.INSERT.Forms
{
    partial class InsertStadiums
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
            this.textInsertStadiumClubID = new System.Windows.Forms.TextBox();
            this.textInsertStadiumSeats = new System.Windows.Forms.TextBox();
            this.textInsertStadiumName = new System.Windows.Forms.TextBox();
            this.textInsertStadiumCapacity = new System.Windows.Forms.TextBox();
            this.InsertStadium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ClubID";
            // 
            // textInsertStadiumClubID
            // 
            this.textInsertStadiumClubID.Location = new System.Drawing.Point(195, 249);
            this.textInsertStadiumClubID.Name = "textInsertStadiumClubID";
            this.textInsertStadiumClubID.Size = new System.Drawing.Size(158, 20);
            this.textInsertStadiumClubID.TabIndex = 4;
            // 
            // textInsertStadiumSeats
            // 
            this.textInsertStadiumSeats.Location = new System.Drawing.Point(195, 220);
            this.textInsertStadiumSeats.Name = "textInsertStadiumSeats";
            this.textInsertStadiumSeats.Size = new System.Drawing.Size(158, 20);
            this.textInsertStadiumSeats.TabIndex = 5;
            // 
            // textInsertStadiumName
            // 
            this.textInsertStadiumName.Location = new System.Drawing.Point(195, 159);
            this.textInsertStadiumName.Name = "textInsertStadiumName";
            this.textInsertStadiumName.Size = new System.Drawing.Size(158, 20);
            this.textInsertStadiumName.TabIndex = 6;
            // 
            // textInsertStadiumCapacity
            // 
            this.textInsertStadiumCapacity.Location = new System.Drawing.Point(195, 190);
            this.textInsertStadiumCapacity.Name = "textInsertStadiumCapacity";
            this.textInsertStadiumCapacity.Size = new System.Drawing.Size(158, 20);
            this.textInsertStadiumCapacity.TabIndex = 7;
            // 
            // InsertStadium
            // 
            this.InsertStadium.Location = new System.Drawing.Point(234, 275);
            this.InsertStadium.Name = "InsertStadium";
            this.InsertStadium.Size = new System.Drawing.Size(75, 23);
            this.InsertStadium.TabIndex = 8;
            this.InsertStadium.Text = "Insert";
            this.InsertStadium.UseVisualStyleBackColor = true;
            // 
            // InsertStadiums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertStadium);
            this.Controls.Add(this.textInsertStadiumCapacity);
            this.Controls.Add(this.textInsertStadiumName);
            this.Controls.Add(this.textInsertStadiumSeats);
            this.Controls.Add(this.textInsertStadiumClubID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertStadiums";
            this.Text = "InsertStadiums";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textInsertStadiumClubID;
        private System.Windows.Forms.TextBox textInsertStadiumSeats;
        private System.Windows.Forms.TextBox textInsertStadiumName;
        private System.Windows.Forms.TextBox textInsertStadiumCapacity;
        private System.Windows.Forms.Button InsertStadium;
    }
}
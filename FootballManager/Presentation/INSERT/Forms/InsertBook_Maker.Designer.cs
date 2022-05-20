namespace FootballManager.Presentation.INSERT.Forms
{
    partial class InsertBook_Maker
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
            this.textInsertBookMakerName = new System.Windows.Forms.TextBox();
            this.textInsertBookMakerTeamID = new System.Windows.Forms.TextBox();
            this.textInsertBookMakerCoefficient = new System.Windows.Forms.TextBox();
            this.InsertBookMaker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coefficient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TeamID";
            // 
            // textInsertBookMakerName
            // 
            this.textInsertBookMakerName.Location = new System.Drawing.Point(206, 150);
            this.textInsertBookMakerName.Name = "textInsertBookMakerName";
            this.textInsertBookMakerName.Size = new System.Drawing.Size(149, 20);
            this.textInsertBookMakerName.TabIndex = 3;
            // 
            // textInsertBookMakerTeamID
            // 
            this.textInsertBookMakerTeamID.Location = new System.Drawing.Point(206, 216);
            this.textInsertBookMakerTeamID.Name = "textInsertBookMakerTeamID";
            this.textInsertBookMakerTeamID.Size = new System.Drawing.Size(149, 20);
            this.textInsertBookMakerTeamID.TabIndex = 4;
            // 
            // textInsertBookMakerCoefficient
            // 
            this.textInsertBookMakerCoefficient.Location = new System.Drawing.Point(206, 182);
            this.textInsertBookMakerCoefficient.Name = "textInsertBookMakerCoefficient";
            this.textInsertBookMakerCoefficient.Size = new System.Drawing.Size(149, 20);
            this.textInsertBookMakerCoefficient.TabIndex = 5;
            // 
            // InsertBookMaker
            // 
            this.InsertBookMaker.Location = new System.Drawing.Point(239, 242);
            this.InsertBookMaker.Name = "InsertBookMaker";
            this.InsertBookMaker.Size = new System.Drawing.Size(75, 23);
            this.InsertBookMaker.TabIndex = 6;
            this.InsertBookMaker.Text = "Insert";
            this.InsertBookMaker.UseVisualStyleBackColor = true;
            // 
            // InsertBook_Maker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertBookMaker);
            this.Controls.Add(this.textInsertBookMakerCoefficient);
            this.Controls.Add(this.textInsertBookMakerTeamID);
            this.Controls.Add(this.textInsertBookMakerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertBook_Maker";
            this.Text = "InsertBook_Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textInsertBookMakerName;
        private System.Windows.Forms.TextBox textInsertBookMakerTeamID;
        private System.Windows.Forms.TextBox textInsertBookMakerCoefficient;
        private System.Windows.Forms.Button InsertBookMaker;
    }
}
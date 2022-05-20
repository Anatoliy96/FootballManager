namespace FootballManager
{
    partial class ListKluboveForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewClubs = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteClubToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // DeleteClubToolStripMenuItem
            // 
            this.DeleteClubToolStripMenuItem.Name = "DeleteClubToolStripMenuItem";
            this.DeleteClubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteClubToolStripMenuItem.Text = "Detele Club";
            this.DeleteClubToolStripMenuItem.Click += new System.EventHandler(this.DeleteClubToolStripMenuItem_Click);
            // 
            // dataGridViewClubs
            // 
            this.dataGridViewClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClubs.Location = new System.Drawing.Point(0, 41);
            this.dataGridViewClubs.Name = "dataGridViewClubs";
            this.dataGridViewClubs.Size = new System.Drawing.Size(461, 383);
            this.dataGridViewClubs.TabIndex = 4;
            // 
            // ListKluboveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.dataGridViewClubs);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ListKluboveForm";
            this.Text = "ListKluboveForm";
            this.Load += new System.EventHandler(this.ListKluboveForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteClubToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewClubs;
    }
}
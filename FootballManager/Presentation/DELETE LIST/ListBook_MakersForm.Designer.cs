namespace FootballManager
{
    partial class ListBook_MakersForm
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
            this.dataGridViewBook_Makers = new System.Windows.Forms.DataGridView();
            this.deleteBookMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook_Makers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBookMakerToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // dataGridViewBook_Makers
            // 
            this.dataGridViewBook_Makers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook_Makers.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewBook_Makers.Name = "dataGridViewBook_Makers";
            this.dataGridViewBook_Makers.Size = new System.Drawing.Size(776, 345);
            this.dataGridViewBook_Makers.TabIndex = 9;
            // 
            // deleteBookMakerToolStripMenuItem
            // 
            this.deleteBookMakerToolStripMenuItem.Name = "deleteBookMakerToolStripMenuItem";
            this.deleteBookMakerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteBookMakerToolStripMenuItem.Text = "Delete Book_Maker";
            this.deleteBookMakerToolStripMenuItem.Click += new System.EventHandler(this.deleteBookMakerToolStripMenuItem_Click);
            // 
            // ListBook_MakersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewBook_Makers);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ListBook_MakersForm";
            this.Text = "ListBook_MakersForm";
            this.Load += new System.EventHandler(this.ListBook_MakersForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook_Makers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewBook_Makers;
        private System.Windows.Forms.ToolStripMenuItem deleteBookMakerToolStripMenuItem;
    }
}
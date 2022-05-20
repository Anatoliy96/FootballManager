namespace FootballManager
{
    partial class LIstStadiumsForm
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
            this.dataGridViewStadiums = new System.Windows.Forms.DataGridView();
            this.deleteStadiumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStadiums)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteStadiumToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // dataGridViewStadiums
            // 
            this.dataGridViewStadiums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStadiums.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewStadiums.Name = "dataGridViewStadiums";
            this.dataGridViewStadiums.Size = new System.Drawing.Size(776, 345);
            this.dataGridViewStadiums.TabIndex = 7;
            // 
            // deleteStadiumToolStripMenuItem
            // 
            this.deleteStadiumToolStripMenuItem.Name = "deleteStadiumToolStripMenuItem";
            this.deleteStadiumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteStadiumToolStripMenuItem.Text = "Delete Stadium";
            this.deleteStadiumToolStripMenuItem.Click += new System.EventHandler(this.deleteStadiumToolStripMenuItem_Click);
            // 
            // LIstStadiumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewStadiums);
            this.Controls.Add(this.menuStrip1);
            this.Name = "LIstStadiumsForm";
            this.Text = "LIstStadiumsForm";
            this.Load += new System.EventHandler(this.LIstStadiumsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStadiums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStadiumToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewStadiums;
    }
}
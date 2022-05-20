namespace FootballManager
{
    partial class ListCoachesForm
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
            this.deteleCoachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewCoaches = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoaches)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deteleCoachToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deteleCoachToolStripMenuItem
            // 
            this.deteleCoachToolStripMenuItem.Name = "deteleCoachToolStripMenuItem";
            this.deteleCoachToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deteleCoachToolStripMenuItem.Text = "Detele Coach";
            this.deteleCoachToolStripMenuItem.Click += new System.EventHandler(this.deteleCoachToolStripMenuItem_Click);
            // 
            // dataGridViewCoaches
            // 
            this.dataGridViewCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoaches.Location = new System.Drawing.Point(0, 68);
            this.dataGridViewCoaches.Name = "dataGridViewCoaches";
            this.dataGridViewCoaches.Size = new System.Drawing.Size(687, 355);
            this.dataGridViewCoaches.TabIndex = 5;
            // 
            // ListCoachesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.dataGridViewCoaches);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ListCoachesForm";
            this.Text = "ListCoachesForm";
            this.Load += new System.EventHandler(this.ListCoachesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoaches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewCoaches;
        private System.Windows.Forms.ToolStripMenuItem deteleCoachToolStripMenuItem;
    }
}
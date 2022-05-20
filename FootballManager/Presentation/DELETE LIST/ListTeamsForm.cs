using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FootballManager.DataAccess;


namespace FootballManager
{
    public partial class ListTeamsForm : Form
    {
        MySqlConnection con;
        public ListTeamsForm()
        {
            InitializeComponent();
            con = ConnectionSingleton.GetConnection();
        }

        private void ListTeamsForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
               BusinessLayer.TeamsBLL teambll = new BusinessLayer.TeamsBLL();

                dataGridViewTeams.DataSource = teambll.GetTeams();

                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.TeamsBLL teamsBLL = new BusinessLayer.TeamsBLL();
                Model.Response.Response response = teamsBLL.DeleteTeam(Convert.ToInt32(dataGridViewTeams.SelectedRows[0].Cells[0].Value));
                
                dataGridViewTeams.Rows.RemoveAt(dataGridViewTeams.SelectedRows[0].Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

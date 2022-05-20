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

namespace FootballManager
{
    public partial class ListIgrachiForm : Form
    {
        MySqlConnection con;
        public ListIgrachiForm()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=uefabet;Uid=root;Pwd=root;");
            
        }

        private void ListIgrachiForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter("select * from players", con);
                
                DataTable DT = new DataTable();

                DA.Fill(DT);

                dataGridView1.DataSource = DT.DefaultView;

                DA.SelectCommand.ExecuteNonQuery();

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               BusinessLayer.PlayersBLL players = new BusinessLayer.PlayersBLL();
               Model.Response.Response response = players.DeletePlayer(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));

               dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

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
    public partial class ListCoachesForm : Form
    {
        MySqlConnection con;
        public ListCoachesForm()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=uefabet;Uid=root;Pwd=root;");
        }

        private void ListCoachesForm_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter DA = new MySqlDataAdapter("select * from coaches", con);

                ConnectionSingleton.GetConnection().Open();
                DataTable DT = new DataTable();

                DA.Fill(DT);

                dataGridViewCoaches.DataSource = DT.DefaultView;

                DA.SelectCommand.ExecuteNonQuery();

                ConnectionSingleton.GetConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deteleCoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand command = new MySqlCommand("", DataAccess.ConnectionSingleton.GetConnection());

                command.CommandText = "delete from coaches where coachid = " + dataGridViewCoaches.SelectedRows[0].Cells[0].Value.ToString();

                command.ExecuteNonQuery();
                dataGridViewCoaches.Rows.RemoveAt(dataGridViewCoaches.SelectedRows[0].Index);

                ConnectionSingleton.GetConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

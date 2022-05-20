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
    public partial class ListRatingsForm : Form
    {
        MySqlConnection con;
        public ListRatingsForm()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=uefabet;Uid=root;Pwd=root;");
        }

        private void ListRatingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter("select * from ratings", con);

                DataTable DT = new DataTable();

                DA.Fill(DT);

                dataGridViewRatings.DataSource = DT.DefaultView;

                DA.SelectCommand.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deteleRatingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand("", con);

                command.CommandText = "delete from ratings where ratingsid = " + dataGridViewRatings.SelectedRows[0].Cells[0].Value.ToString();

                command.ExecuteNonQuery();
                dataGridViewRatings.Rows.RemoveAt(dataGridViewRatings.SelectedRows[0].Index);

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

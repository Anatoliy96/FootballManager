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
    public partial class LIstStadiumsForm : Form
    {
        MySqlConnection con;
        public LIstStadiumsForm()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=uefabet;Uid=root;Pwd=root;");
        }

        private void LIstStadiumsForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter("select * from stadiums", con);

                DataTable DT = new DataTable();

                DA.Fill(DT);

                dataGridViewStadiums.DataSource = DT.DefaultView;

                DA.SelectCommand.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteStadiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand("", con);

                command.CommandText = "delete from stadiums where stadiumsid = " + dataGridViewStadiums.SelectedRows[0].Cells[0].Value.ToString();

                command.ExecuteNonQuery();
                dataGridViewStadiums.Rows.RemoveAt(dataGridViewStadiums.SelectedRows[0].Index);

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

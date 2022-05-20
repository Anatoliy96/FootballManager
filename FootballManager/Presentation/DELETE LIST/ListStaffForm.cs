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
    public partial class ListStaffForm : Form
    {
        MySqlConnection con;
        public ListStaffForm()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=uefabet;Uid=root;Pwd=root;");
        }

        private void ListStaffForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter("select * from staff", con);

                DataTable DT = new DataTable();

                DA.Fill(DT);

                dataGridViewStaff.DataSource = DT.DefaultView;

                DA.SelectCommand.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deteleStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand("", con);

                command.CommandText = "delete from staff where staffid = " + dataGridViewStaff.SelectedRows[0].Cells[0].Value.ToString();

                command.ExecuteNonQuery();
                dataGridViewStaff.Rows.RemoveAt(dataGridViewStaff.SelectedRows[0].Index);

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

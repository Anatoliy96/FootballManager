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
    public partial class ListBook_MakersForm : Form
    {
        MySqlConnection con;
        public ListBook_MakersForm()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=uefabet;Uid=root;Pwd=root;");
        }

        private void ListBook_MakersForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter("select * from book_makers", con);

                DataTable DT = new DataTable();

                DA.Fill(DT);

                dataGridViewBook_Makers.DataSource = DT.DefaultView;

                DA.SelectCommand.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBookMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand("", con);

                command.CommandText = "delete from book_makers where book_makersid = " + dataGridViewBook_Makers.SelectedRows[0].Cells[0].Value.ToString();

                command.ExecuteNonQuery();
                dataGridViewBook_Makers.Rows.RemoveAt(dataGridViewBook_Makers.SelectedRows[0].Index);

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

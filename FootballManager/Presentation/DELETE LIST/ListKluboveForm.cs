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
    public partial class ListKluboveForm : Form
    {
        MySqlConnection con;
        public ListKluboveForm()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=uefabet;Uid=root;Pwd=root;");
        }

        private void ListKluboveForm_Load(object sender, EventArgs e)
        {
            try
            {
               BusinessLayer.ClubBLL business = new BusinessLayer.ClubBLL();

                dataGridViewClubs.DataSource = business.GetClubs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.ClubBLL clubBLL = new BusinessLayer.ClubBLL();
                Model.Response.Response response = clubBLL.DeleteClub(Convert.ToInt32(dataGridViewClubs.SelectedRows[0].Cells[0].Value));
                dataGridViewClubs.Rows.RemoveAt(dataGridViewClubs.SelectedRows[0].Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

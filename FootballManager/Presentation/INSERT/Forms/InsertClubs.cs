using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballManager.Presentation.INSERT.Forms
{
    public partial class InsertClubs : Form
    {
        public InsertClubs()
        {
            InitializeComponent();
        }

        private void buttonInsertClub_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.ClubBLL clubBLL = new BusinessLayer.ClubBLL();
                Model.Response.Response response = clubBLL.InsertClub(textInsertClubName.Text, textInsertClubOwner.Text, dateTimePickerInsertFounded.Value);

                textInsertClubName.Clear();
                textInsertClubOwner.Clear();

                if (!response.OK)
                {
                    MessageBox.Show(response.ErroMessage);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

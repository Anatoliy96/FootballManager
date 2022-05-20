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
    public partial class InsertTeams : Form
    {
        public InsertTeams()
        {
            InitializeComponent();
        }

        private void InsertTeam_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.TeamsBLL teamsBLL = new BusinessLayer.TeamsBLL();
                Model.Response.Response response = teamsBLL.InsertTeam(textInsertTeamName.Text,
                    Convert.ToInt32(textInsertTeamClubID.Text));

                textInsertTeamName.Clear();
                textInsertTeamClubID.Clear();

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

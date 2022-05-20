using FootballManager.BusinessLayer.Coaches;
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
    public partial class InsertCoaches : Form
    {
        public InsertCoaches()
        {
            InitializeComponent();
        }

        private void InsertCoach_Click(object sender, EventArgs e)
        {
            try
            {
                CoachBLL coachBLL = new CoachBLL();
                Model.Response.Response response = coachBLL.InsertCoaches(textInsertCoachName.Text, textInsertCoachLastName.Text,
                    textInsertCoachType.Text, Convert.ToDateTime(textInsertCoachBirthdate.Text), Convert.ToInt32(textInsertCoachTeamID.Text));

                textInsertCoachName.Clear();
                textInsertCoachLastName.Clear();
                textInsertCoachType.Clear();
                textInsertCoachBirthdate.Clear();
                textInsertCoachTeamID.Clear();

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

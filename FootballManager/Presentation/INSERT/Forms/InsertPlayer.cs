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
    public partial class InsertPlayer : Form
    {
        public InsertPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.PlayersBLL playersBLL = new BusinessLayer.PlayersBLL();
                Model.Response.Response response = playersBLL.InsertPlayers(textInsertPlayerName.Text, textInsertPlayerLastName.Text,
                  Convert.ToDateTime(textInsertPlayerBirthdate.Text), textInsertPlayerPosition.Text, Convert.ToInt32(textInsertPlayerAge.Text),
                  Convert.ToInt32(textInsertPlayerWeight.Text), Convert.ToInt32(textInsertPlayerHeight.Text), Convert.ToInt32(textPlayerTeamID.Text));

                textInsertPlayerName.Clear();
                textInsertPlayerLastName.Clear();
                textInsertPlayerBirthdate.Clear();
                textInsertPlayerPosition.Clear();
                textInsertPlayerAge.Clear();
                textInsertPlayerWeight.Clear();
                textInsertPlayerHeight.Clear();
                textPlayerTeamID.Clear();

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

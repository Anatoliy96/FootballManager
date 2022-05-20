using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballManager.Presentation.INSERT
{
    public partial class InsertMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        public InsertMainMenu()
        {
            InitializeComponent();

            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.Colors.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.Colors.Count);
            }
            tempIndex = index;
            string color = ThemeColor.Colors[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lBlTitle.Text = childForm.Text;
        }

        private void buttonInsertClubs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InsertClubs(), sender);
        }

        private void buttonInsertTeam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InsertTeams(), sender);
        }

        private void buttonInsertPlayer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InsertPlayer(), sender);
        }

        private void buttonInsertCoach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InsertCoaches(), sender);
        }

        private void buttonInsertStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InsertStaff(), sender);
        }

        private void buttonInsertStadium_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InsertStadiums(), sender);
        }

        private void buttonInsertBookMaker_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InsertBook_Maker(), sender);
        }

        private void buttonInsertRatings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InsertRatings(), sender);
        }
    }
}

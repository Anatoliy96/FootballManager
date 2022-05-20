using FootballManager.Presentation.INSERT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballManager
{
    public partial class MainManu : Form
    {
        public MainManu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertMainMenu insert = new InsertMainMenu();
            insert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDataForm update = new UpdateDataForm();
            update.Show();
        }

        private void buttonSelectPlayers_Click(object sender, EventArgs e)
        {
            ListIgrachiForm igrachi = new ListIgrachiForm();
            igrachi.Show();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            ListKluboveForm klubove = new ListKluboveForm();
            klubove.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListCoachesForm coaches = new ListCoachesForm();
            coaches.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListStaffForm staff = new ListStaffForm();
            staff.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LIstStadiumsForm stadiums = new LIstStadiumsForm();
            stadiums.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ListTeamsForm teams = new ListTeamsForm();
            teams.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ListBook_MakersForm book_makers = new ListBook_MakersForm();
            book_makers.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ListRatingsForm ratings = new ListRatingsForm();
            ratings.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListIgrachiForm igrachi = new ListIgrachiForm();
            igrachi.Show();

            ListKluboveForm klubove = new ListKluboveForm();
            klubove.Show();

            ListCoachesForm coaches = new ListCoachesForm();
            coaches.Show();

            ListStaffForm staff = new ListStaffForm();
            staff.Show();

            LIstStadiumsForm stadiums = new LIstStadiumsForm();
            stadiums.Show();

            ListTeamsForm teams = new ListTeamsForm();
            teams.Show();

            ListBook_MakersForm book_makers = new ListBook_MakersForm();
            book_makers.Show();

            ListRatingsForm ratings = new ListRatingsForm();
            ratings.Show();
        }
    }
}

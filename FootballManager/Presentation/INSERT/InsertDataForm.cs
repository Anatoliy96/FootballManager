using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballManager.BusinessLayer.Clubs;
using FootballManager.BusinessLayer.Coaches;
using MySql.Data.MySqlClient;

namespace FootballManager
{
    public partial class InsertDataForm : Form
    {
        MySqlConnection connection;
        public InsertDataForm()
        {
            InitializeComponent();
            connection = new MySqlConnection("Server = localhost; Database = uefabet;Uid=root;Pwd=root;");
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.ClubBLL clubBLL = new BusinessLayer.ClubBLL();
                Model.Response.Response response = clubBLL.InsertClub(textClub.Text, textBoxOwner.Text, dateTimePicker1.Value);

                textClub.Clear();
                textBoxOwner.Clear();
                
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
        
        private void buttonCoach_Click(object sender, EventArgs e)
        {
            try
            {
                CoachBLL coachBLL = new CoachBLL();
                Model.Response.Response response = coachBLL.InsertCoaches(textFirstName.Text, textLastName.Text,
                    textBoxBithdate.Text,Convert.ToDateTime(textBoxType.Text),Convert.ToInt32(textBoxTeamCoachID.Text));

                textFirstName.Clear();
                textLastName.Clear();
                textBoxBithdate.Clear();
                textBoxType.Clear();
                textBoxTeamCoachID.Clear();

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
        
        
        private void buttonInsertPlayers_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.PlayersBLL playersBLL = new BusinessLayer.PlayersBLL();
                Model.Response.Response response = playersBLL.InsertPlayers(textBoxPlayerName.Text, textBoxPlayerLastName.Text,
                  Convert.ToDateTime(textBoxPlayerBirthDate.Text), textBoxPlayerPosition.Text,Convert.ToInt32(textBoxPlayerAge.Text),
                  Convert.ToInt32(textBoxPlayerWeigth.Text),Convert.ToInt32(textBoxPlayerHeigth.Text),Convert.ToInt32(textTeamID.Text));

                textBoxPlayerName.Clear();
                textBoxPlayerLastName.Clear();
                textBoxPlayerBirthDate.Clear();
                textBoxPlayerPosition.Clear();
                textBoxPlayerAge.Clear();
                textBoxPlayerWeigth.Clear();
                textBoxPlayerHeigth.Clear();
                textTeamID.Clear();

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

        private void InsertStaff_Click(object sender, EventArgs e)
        {

            MySqlCommand command = new MySqlCommand("", connection);

            command.Connection.Open();
            command.CommandText = "insert into staff (FirstName,LastName,Age,Position,clubid) values('" + textBoxStaffName.Text
                + "' , '" + textBoxStaffLast.Text + "','" + textBoxStaffAge.Text + "', '"
                + textBoxStaffPosition.Text + "', '" + textBoxclubid.Text + "')";

            textBoxStaffName.Clear();
            textBoxStaffLast.Clear();
            textBoxStaffAge.Clear();
            textBoxStaffPosition.Clear();
            textBoxclubid.Clear();

            try
            {

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Staff inserted");
                }
                else
                {
                    MessageBox.Show("Staff not inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            command.Connection.Close();
        }

        private void buttonInsertTeams_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.TeamsBLL teamsBLL = new BusinessLayer.TeamsBLL();
                Model.Response.Response response = teamsBLL.InsertTeam(textBoxTeamName.Text,
                    Convert.ToInt32(textBoxclub.Text));

                textBoxTeamName.Clear();
                textBoxclub.Clear();

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

        private void buttonInsertStadiums_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("", connection);

            command.Connection.Open();
            command.CommandText = "insert into stadiums (Name,Capacity,Seats,Clubid) values('" + textboxStadiumName.Text
                + "' , '" + textBoxStadiumCapacity.Text + "','" + textBoxStadiumSeats.Text + "','" + textBoxStadiumID.Text + "')";

            textboxStadiumName.Clear();
            textBoxStadiumCapacity.Clear();
            textBoxStadiumSeats.Clear();
            textBoxStadiumID.Clear();

            try
            {

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Stadium inserted");
                }
                else
                {
                    MessageBox.Show("Stadium not inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            command.Connection.Close();
        }

        private void buttonInsertBookMakers_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("", connection);

            command.Connection.Open();
            command.CommandText = "insert into book_makers (Name,Coefficient,TeamsID) values('" + textBoxbookmakerName.Text
                + "' , '" + textBoxCoefficient.Text + "','" + textBoxTeamsID.Text + "')";

            textBoxbookmakerName.Clear();
            textBoxCoefficient.Clear();
            textBoxTeamsID.Clear();

            try
            {

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("BookMaker inserted");
                }
                else
                {
                    MessageBox.Show("BookMaker not inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            command.Connection.Close();
        }

        private void buttonRatings_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("", connection);

            command.Connection.Open();
            command.CommandText = "insert into ratings (Book_MakersID,TeamsID,Date) values('" + textBoxBookMakersID.Text
                + "' , '" + textBoxteams.Text + "','" + textBoxDate.Text + "')";

            textBoxBookMakersID.Clear();
            textBoxteams.Clear();
            textBoxDate.Clear();

            try
            {

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Ratings inserted");
                }
                else
                {
                    MessageBox.Show("Ratings not inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            command.Connection.Close();
        }
    }
}

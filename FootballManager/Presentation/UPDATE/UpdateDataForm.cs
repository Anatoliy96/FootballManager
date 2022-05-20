using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballManager.BusinessLayer.Coaches;
using MySql.Data.MySqlClient;

namespace FootballManager
{
    public partial class UpdateDataForm : Form
    {
        MySqlConnection con;

        public UpdateDataForm()
        {
            InitializeComponent();

            con = new MySqlConnection("Server=localhost;Database=uefabet;Uid=root;Pwd=root;");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateDataForm_Load(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "select name from clubs ";

                com.Connection.Open();

                MySqlDataReader DR = com.ExecuteReader();

                while (DR.Read())
                {
                    comboClubs.Items.Add((string)DR["name"]);
                }

                DR.Close();

                com.CommandText = "select firstname from players";
                DR = com.ExecuteReader();

                while (DR.Read())
                {
                    comboPlayers.Items.Add((string)DR["firstname"]);
                }

                DR.Close();

                com.CommandText = "select firstname from coaches";
                DR = com.ExecuteReader();

                while (DR.Read())
                {
                    comboCoaches.Items.Add((string)DR["firstname"]);
                }

                DR.Close();

                com.CommandText = " select firstname from staff";
                DR = com.ExecuteReader();

                while (DR.Read())
                {
                    comboStaff.Items.Add((string)DR["firstname"]);
                }

                DR.Close();

                com.CommandText = " select name from stadiums";
                DR = com.ExecuteReader();

                while (DR.Read())
                {
                    comboStadiums.Items.Add((string)DR["name"]);
                }

                DR.Close();

                com.CommandText = "select name from teams";
                DR = com.ExecuteReader();

                while (DR.Read())
                {
                    comboTeams.Items.Add((string)DR["name"]);
                }

                DR.Close();

                com.CommandText = "select name from book_makers";
                DR = com.ExecuteReader();

                while (DR.Read())
                {
                    comboBookMakers.Items.Add((string)DR["name"]);
                }

                DR.Close();

                com.CommandText = "select book_makersid from ratings";
                DR = com.ExecuteReader();

                while (DR.Read())
                {
                    comboRatings.Items.Add((Int32)DR["book_makersid"]);
                }
                DR.Close();
                com.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void comboClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "select * from clubs where name = '" + comboClubs.Text + "'";

                com.Connection.Open();

                MySqlDataReader DR = com.ExecuteReader();

                if (DR.Read())
                {
                    textName.Text = (string)DR["name"];
                    textOwner.Text = (string)DR["owner"];
                    dateFounded.Value = (DateTime)DR["founded"];
                }

                DR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.ClubBLL clubBLL = new BusinessLayer.ClubBLL();
                Model.Response.Response response = clubBLL.UpdateClub(textName.Text, textOwner.Text,dateFounded.Value.Date, comboClubs.Text);

                if (!response.OK)
                {
                    MessageBox.Show(response.ErroMessage);
                }

                comboClubs.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "select * from players where firstname = '" + comboPlayers.Text + "'";

                com.Connection.Open();

                MySqlDataReader DR = com.ExecuteReader();

                if (DR.Read())
                {
                    textPlayerName.Text = (string)DR["FirstName"];
                    textPlayerLastName.Text = (string)DR["LastName"];
                    dateTimePlayer.Value = (DateTime)DR["Birthdate"];
                    textPosition.Text = (string)DR["Position"];
                    textAge.Text = Convert.ToString((Int32)DR["Age"]);
                    textWeigth.Text = Convert.ToString((Int32)DR["Weight"]);
                    textHeigth.Text = (string)DR["Height"].ToString();
                    textBoxPlayersTeamID.Text = Convert.ToString((Int32)DR["TeamID"]);
                }
                DR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void buttonChange_Player(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.PlayersBLL playersBLL = new BusinessLayer.PlayersBLL();
                Model.Response.Response response = playersBLL.UpdatePlayer(textPlayerName.Text, textPlayerLastName.Text,
                dateTimePlayer.Value.Date, textPosition.Text,Convert.ToInt32(textAge.Text),Convert.ToInt32(textWeigth.Text), 
                Convert.ToInt32(textHeigth.Text),Convert.ToInt32(textBoxPlayersTeamID.Text),comboPlayers.Text);

                if (!response.OK)
                {
                    MessageBox.Show(response.ErroMessage);
                }

                comboPlayers.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboCoaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "select * from coaches where firstname = '" + comboCoaches.Text + "'";

                com.Connection.Open();

                MySqlDataReader DR = com.ExecuteReader();

                if (DR.Read())
                {
                    textCoachName.Text = (string)DR["firstname"];
                    textBoxCoachLastName.Text = (string)DR["lastname"];
                    dateTimeCoach.Value = (DateTime)DR["Birthdate"];
                    textType.Text = (string)DR["Type"];
                    textUpdateCoachTeamID.Text = Convert.ToString((Int32)DR["TeamID"]);
                }

                DR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void buttonUpdateCoaches_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    CoachBLL coachBLL = new CoachBLL();
            //   // Model.Response.Response response = coachBLL.UpdateCoach(textCoachName.Text, textBoxCoachLastName.Text,
            //       // dateTimeCoach.Text,Convert.ToString(textType.Text),Convert.ToInt32(textUpdateCoachTeamID.Text),
            //         //comboCoaches.Text);

            //    if (!response.OK)
            //    {
            //        MessageBox.Show(response.ErroMessage);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void comboStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "select * from staff where firstname = '" + comboStaff.Text + "'";

                com.Connection.Open();

                MySqlDataReader DR = com.ExecuteReader();

                if (DR.Read())
                {
                    textStaffName.Text = (string)DR["firstname"];
                    textStaffLastName.Text = (string)DR["lastname"];
                    textStaffAge.Text = Convert.ToString((Int32)DR["Age"]);
                    textStaffPostion.Text = (string)DR["position"];
                    textUpdateStaffClubID.Text = Convert.ToString((Int32)DR["clubid"]);
                }
                DR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "update staff set " +
                    "firstname = '" + textStaffName.Text + "', " +
                    "lastname = '" + textStaffLastName.Text + "', " +
                    "age = '" + textStaffAge.Text + "', " +
                    "position = '" + textStaffPostion.Text + "', " +
                    "clubid = '" + textUpdateStaffClubID.Text + "' " +
                    "where firstname = '" + comboStaff.Text + "'";

                com.Connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Staff updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void comboStadiums_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "select * from stadiums where name = '" + comboStadiums.Text + "'";

                com.Connection.Open();

                MySqlDataReader DR = com.ExecuteReader();

                if (DR.Read())
                {
                    textStadiumName.Text = (string)DR["name"];
                    textStadiumCapacity.Text = Convert.ToString((Int32)DR["capacity"]);
                    textStadiumSeats.Text = Convert.ToString((Int32)DR["seats"]);
                    textUpdateStadiumsClubID.Text = Convert.ToString((Int32)DR["clubid"]);
                }

                DR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void buttonStadiums_Click(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "update stadiums set " +
                    "name = '" + textStadiumName.Text + "', " +
                    "capacity = '" + textStadiumCapacity.Text + "', " +
                    "seats = '" + textStadiumSeats.Text + "', " +
                    "clubid = '" + textUpdateStadiumsClubID.Text + "' " +
                    "where name = '" + comboStadiums.Text + "'";

                com.Connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Stadium updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void comboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "select * from teams where name = '" + comboTeams.Text + "'";

                com.Connection.Open();

                MySqlDataReader DR = com.ExecuteReader();

                if (DR.Read())
                {
                    textTeamName.Text = (string)DR["name"];
                    //textUpdateTeamsClubID.Text = Convert.ToString((Int32)DR["clubid"]);
                }

                DR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void buttonTeam_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.TeamsBLL teamsBLL = new BusinessLayer.TeamsBLL();
                Model.Response.Response response = teamsBLL.UpdateTeam(textTeamName.Text, comboTeams.Text);

                if (!response.OK)
                {
                    MessageBox.Show(response.ErroMessage);
                }
                comboTeams.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBookMakers_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "select * from book_makers where name = '" + comboBookMakers.Text + "'";

                com.Connection.Open();

                MySqlDataReader DR = com.ExecuteReader();

                if (DR.Read())
                {
                    textBookMakersName.Text = (string)DR["name"];
                    textCoefficient.Text = Convert.ToString((Double)DR["coefficient"]);
                    textTeamsID.Text = Convert.ToString((Int32)DR["teamsid"]);
                }

                DR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void buttonBookMakers_Click(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "update book_makers set " +
                    "name = '" + textBookMakersName.Text + "', " +
                    "Coefficient = '" + textCoefficient.Text + "', " +
                    "teamsid = '" + textTeamsID.Text + "' " +
                    "where name = '" + comboBookMakers.Text + "'";

                com.Connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Book Makers updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void comboRatings_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "select * from ratings where book_makersid = '" + comboRatings.Text + "'";

                com.Connection.Open();

                MySqlDataReader DR = com.ExecuteReader();

                if (DR.Read())
                {
                    textbookmakersID.Text = Convert.ToString((Int32)DR["book_makersid"]);
                    textTeamID.Text = Convert.ToString((Int32)DR["teamsid"]);
                    dateTimeRatingsDate.Value = (DateTime)DR["date"];
                }

                DR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }

        private void buttonRatings_Click(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("", con);
            try
            {
                com.CommandText = "update ratings set " +
                    "book_makersid = '" + textbookmakersID.Text + "', " +
                    "teamsid = '" + textTeamID.Text + "', " +
                    "date = '" + dateTimeRatingsDate.Value.ToString("yyyy-MM-dd") + "' " +
                    "where book_makersid = '" + comboRatings.Text + "'";

                com.Connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Ratings updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                com.Connection.Close();
            }
        }
    }
}

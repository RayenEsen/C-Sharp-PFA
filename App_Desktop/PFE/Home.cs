using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace PFE
{
    public partial class Home : Form
    {
        MySqlConnection connection;
        public Home()
        {
            InitializeComponent();
        }



        private void Login_Click(object sender, EventArgs e)
        {
            //This code Will return me to the home page whenever I click in Login again
            if (Login_thing.Visible == true)
            {
                Login_thing.Visible = false;
                userControl11.Show();
                userControl11.BringToFront();
            }
            else
            {
                //Hide other User_Controls
                userControl11.Hide();
                userControl31.Hide();
                userControl41.Hide();
                userControl61.Hide();
                userControl71.Hide();
                Register_thing.Visible = false;
                Students_thing.Visible = false;
                Moyen_thing.Visible = false;
                Remove_thing.Visible = false;
                //Open Login User_Controls
                userControl21.Show();
                userControl21.BringToFront();
                Login_thing.Visible = true;
                Register_thing.Visible = false;
            }

        }

        private void Register_Click(object sender, EventArgs e)
        {
            //This code Will return me to the home page whenever I click in Register again
            if (!(Variables.password == ""))
            {
                MessageBox.Show("Your need to logout from your acount first");
            }
            else if (Register_thing.Visible == true)
            {
                Register_thing.Visible = false;
                userControl11.Show();
                userControl11.BringToFront();
            }
            else
            {
                //Hide other User_Controls
                userControl11.Hide();
                userControl21.Hide();
                userControl41.Hide();
                userControl61.Hide();
                userControl71.Hide();
                Login_thing.Visible = false;
                Students_thing.Visible = false;
                Moyen_thing.Visible = false;
                Remove_thing.Visible = false;
                //Open Login User_Controls
                userControl31.Show();
                userControl31.BringToFront();
                Register_thing.Visible = true;
            }
        }

        private void Products_Click(object sender, EventArgs e)
        {
            if (Variables.password == "")
            {
                MessageBox.Show("Pls login to your acount first");
            }
            //This code Will return me to the home page whenever I click in Etudiants again
            else if (Students_thing.Visible == true)
            {
                    Students_thing.Visible = false;
                    userControl11.Show();
                    userControl11.BringToFront();
            }
            else 
            {
                userControl11.Hide();
                userControl21.Hide();
                userControl31.Hide();
                userControl41.Hide();
                userControl61.Hide();
                userControl71.Hide();
                Register_thing.Visible = false;
                Login_thing.Visible = false;
                Moyen_thing.Visible = false;
                Remove_thing.Visible = false;
                //Open Login User_Controls
                userControl51.Show();
                userControl51.BringToFront();
                Students_thing.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            this.connection = new MySqlConnection();
            this.connection.ConnectionString = "server = localhost ; uid = root ; pwd =;database = pfe";
            try
            {
                this.connection.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Connexion Error", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Profile_thing_Paint(object sender, PaintEventArgs e)
        {

        }


        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This code Will return me to the home page whenever I click in Remove again
            if (Moyen_thing.Visible == true)
            {
                Moyen_thing.Visible = false;
                userControl11.Show();
                userControl11.BringToFront();
            }
            else
            {
                //Hide other User_Controls
                userControl11.Hide();
                userControl31.Hide();
                userControl41.Hide();
                userControl51.Hide();
                userControl71.Hide();
                Register_thing.Visible = false;
                Students_thing.Visible = false;
                Login_thing.Visible = false;
                Remove_thing.Visible = false;
                //Open Moyen User_Controls
                userControl61.Show();
                userControl61.BringToFront();
                Moyen_thing.Visible = true;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string sql = "SELECT POSITION FROM professor WHERE PWD = '" + Variables.password + "'";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                //This code Will return me to the home page whenever I click in Moyen again
                if (Remove_thing.Visible == true)
                {
                    Remove_thing.Visible = false;
                    userControl11.Show();
                    userControl11.BringToFront();
                }
                else
                {
                    //Hide other User_Controls
                    userControl11.Hide();
                    userControl31.Hide();
                    userControl41.Hide();
                    userControl51.Hide();
                    userControl61.Hide();
                    Register_thing.Visible = false;
                    Students_thing.Visible = false;
                    Login_thing.Visible = false;
                    Moyen_thing.Visible = false;
                    //Open Remove User_Controls
                    userControl71.Show();
                    userControl71.BringToFront();
                    Remove_thing.Visible = true;
                }
            }
            else
            {
                reader.Close();
                MessageBox.Show("You must be a teatcher to access this tab");
            }
        }
    }
}

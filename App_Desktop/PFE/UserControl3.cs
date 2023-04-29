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
using MySqlX.XDevAPI;

namespace PFE
{
    public partial class UserControl3 : UserControl
    {
        MySqlConnection connection;
        public UserControl3()
        {
            InitializeComponent();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Home home = (Home)FindForm();
            home.Close();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            this.connection = new MySqlConnection();
            this.connection.ConnectionString = "server = localhost ; uid = root ; pwd =;database = pfe";
            try
            {
                this.connection.Open();
            }catch (MySqlException)
            {
                MessageBox.Show("Connexion Error","Attention",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            if(Password.UseSystemPasswordChar)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            if (FULL.Text.Trim() == "")
            {
                Error1.Visible = true;
                FULL.Focus();
            }
            else Error1.Visible = false;

            if (EMAIL.Text.Trim() == "")
            {
                Error2.Visible = true;
                EMAIL.Focus();
            }
            else Error2.Visible = false;

            if (Password.Text.Trim() == "")
            {
                Error3.Visible = true;
                Password.Focus();
            }
            else Error3.Visible = false;

            if (ID.Text.Trim() == "")
            {
                Error4.Visible = true;
                Password.Focus();
            }
            else Error4.Visible = false;

            if (!Error1.Visible && !Error2.Visible && !Error3.Visible && !Error4.Visible)
            {
                string sql2 = "SELECT ID_PROF FROM admins_ids WHERE ID_PROF = '" + ID.Text.Trim() + "'";
                MySqlCommand command2 = new MySqlCommand(sql2, this.connection);
                MySqlDataReader reader = command2.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    //This user is a teacher
                    string sql3 = "INSERT INTO professor (ID_PROF, FIRST, EMAIL, PWD) VALUES ('" + ID.Text.Trim() + "','" + FULL.Text.Trim() + "','" + EMAIL.Text.Trim() + "','" + Variables.cryptage(Password.Text.Trim()) + "')";
                    MySqlCommand command3 = new MySqlCommand(sql3, this.connection);
                    try
                    {
                        command3.ExecuteNonQuery();
                        Error1.Text = "Your account has been created professor";
                        Error1.Visible = true;
                    }
                    catch (MySqlException exce) { MessageBox.Show(exce.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    reader.Close();
                    //This user is a student
                    string sql = "INSERT INTO Etudiant (ID, FIRST, EMAIL, PWD) VALUES ('" + ID.Text.Trim() + "','" + FULL.Text.Trim() + "','" + EMAIL.Text.Trim() + "','" + Variables.cryptage(Password.Text.Trim()) + "')";
                    MySqlCommand command = new MySqlCommand(sql, this.connection);
                    try
                    {
                        command.ExecuteNonQuery();
                        Error1.Text = "Your account has been created";
                        Error1.Visible = true;
                    }
                    catch (MySqlException exce) { MessageBox.Show(exce.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }


        private void FULL_TextChanged(object sender, EventArgs e)
        {

        }

        private void FULL_Enter(object sender, EventArgs e)
        {
            FULL.Text = "";
        }

        private void EMAIL_Enter(object sender, EventArgs e)
        {
            EMAIL.Text = "";
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            Password.Text = "";
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Enter(object sender, EventArgs e)
        {
            ID.Text = "";
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Error2_Click(object sender, EventArgs e)
        {

        }

        private void Error3_Click(object sender, EventArgs e)
        {

        }

        private void Error4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

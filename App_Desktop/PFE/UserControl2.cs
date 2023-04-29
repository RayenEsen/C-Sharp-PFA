using System;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PFE
{

    public partial class UserControl2 : UserControl
    {
        MySqlConnection connection;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Home home = (Home)FindForm();
            home.Close();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
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
            LOGOUT.Visible= false;
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void PWD_Enter(object sender, EventArgs e)
        {
            PWD.Text = "";
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            Variables.password = Variables.cryptage(PWD.Text);
            if (EMAIL.Text.Trim() == "")
            {
                Error1.Visible = true;
                EMAIL.Focus();
            }
            else Error1.Visible = false;

            if (PWD.Text.Trim() == "")
            {
                Error2.Visible = true;
                PWD.Focus();
            }
            else Error2.Visible = false;

            if (!Error1.Visible && !Error2.Visible)
            {
                string sql = "SELECT EMAIL, PWD FROM Etudiant WHERE EMAIL = '" + EMAIL.Text.Trim() + "' AND PWD = '" + Variables.cryptage(PWD.Text.Trim()) + "'";
                MySqlCommand command = new MySqlCommand(sql, this.connection);
                try
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        userControl41.Visible = true;
                        LOGOUT.Visible = true;
                    }
                    else
                    {
                        // Close the first data reader before executing the second query
                        reader.Close();

                        string sql2 = "SELECT EMAIL, PWD FROM professor WHERE EMAIL = '" + EMAIL.Text.Trim() + "' AND PWD = '" + Variables.cryptage(PWD.Text.Trim()) + "'";
                        MySqlCommand command2 = new MySqlCommand(sql2, this.connection);
                        MySqlDataReader reader2 = command2.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            reader2.Close();
                            userControl41.Visible = true;
                            LOGOUT.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("User Doesn't exist", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            reader2.Close();
                            Variables.password = "";
                        }
                    }
                }
                catch (MySqlException exe)
                {
                    MessageBox.Show(exe.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void EMAIL_Enter(object sender, EventArgs e)
        {
            EMAIL.Text = "";
        }

        private void EMAIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void PWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            if (PWD.UseSystemPasswordChar)
            {
                PWD.UseSystemPasswordChar = false;
            }
            else
            {
                PWD.UseSystemPasswordChar = true;
            }
        }

        private void userControl41_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void LOGOUT_Click_1(object sender, EventArgs e)
        {
            Variables.password = "";
            LOGOUT.BringToFront();
            userControl41.Hide();
            LOGOUT.Visible = false;
        }
    }
}
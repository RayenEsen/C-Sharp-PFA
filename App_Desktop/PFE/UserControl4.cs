using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FontAwesome.Sharp;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace PFE
{

    public partial class UserControl4 : UserControl
    {
        MySqlConnection connection;
        public UserControl4()
        {
            InitializeComponent();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Home home = (Home)FindForm();
            home.Close();
        }


        private void UserControl4_Load(object sender, EventArgs e)
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
            string sql = "SELECT FIRST FROM ETUDIANT WHERE PWD = '" + Variables.password + "'";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read() && reader.HasRows)
                {
                    string temp = "Welcome " + reader["FIRST"].ToString();
                    NAME.Text = temp;
                    reader.Close();
                }
                else
                {
                    reader.Close(); 
                    string sql3 = "SELECT FIRST FROM professor WHERE PWD = '" + Variables.password + "'";
                    MySqlCommand command3 = new MySqlCommand(sql3, this.connection);
                    MySqlDataReader reader3 = command3.ExecuteReader();
                    if (reader3.Read() && reader3.HasRows)
                    {
                        string temp = "Welcome Mr " + reader3["FIRST"].ToString();
                        NAME.Text = temp;
                    }
                    reader3.Close(); 
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string sql2 = "SELECT EMAIL,PHONE,ABOUT,POSITION,BIRTHDAY,GENDER,PFP FROM ETUDIANT WHERE PWD = '" + Variables.password + "'";
            MySqlCommand command2 = new MySqlCommand(sql2, this.connection);
            try
            {
                MySqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.Read() && reader2.HasRows)
                {
                    FULL.Text = reader2["EMAIL"].ToString();
                    PHONE.Text = reader2["PHONE"].ToString();
                    ABOUT.Text = reader2["ABOUT"].ToString();
                    POS2.Text = reader2["POSITION"].ToString();
                    GENDER.Text = reader2["GENDER"].ToString();
                    DateTime birthday = reader2.GetDateTime("BIRTHDAY");
                    DATE_TEXT.Text = birthday.ToString();
                    /*
                    //getting the picture from the database if its not null and transforming it from binary to an image
                    if (!reader2.IsDBNull(reader2.GetOrdinal("PFP")))
                    {
                        byte[] images = (byte[])reader2["PFP"];
                        MemoryStream memory = new MemoryStream(images);
                        try
                        {
                            Image image = Image.FromStream(memory);
                            pictureBox1.Image = image;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to load image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        }
                    */
                    reader2.Close();
                }
                else
                {
                    reader2.Close();

                    string sql4 = "SELECT EMAIL,PHONE,ABOUT,POSITION,BIRTHDAY,GENDER,PFP FROM professor WHERE PWD = '" + Variables.password + "'";
                    MySqlCommand command4 = new MySqlCommand(sql4, this.connection);
                    MySqlDataReader reader4 = command4.ExecuteReader(); 
                    if (reader4.Read() && reader4.HasRows)
                    {
                        FULL.Text = reader4["EMAIL"].ToString();
                        PHONE.Text = reader4["PHONE"].ToString();
                        ABOUT.Text = reader4["ABOUT"].ToString();
                        POS2.Text = reader4["POSITION"].ToString();
                        GENDER.Text = reader4["GENDER"].ToString();
                        DateTime birthday = reader4.GetDateTime("BIRTHDAY");
                        DATE_TEXT.Text = birthday.ToString();
                        reader4.Close();
                    } 
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (iconButton1.Text == "Edit" )
            {
                string sql3 = "SELECT FIRST FROM ETUDIANT WHERE PWD = '" + Variables.password + "'";
                MySqlCommand command3 = new MySqlCommand(sql3, this.connection);
                MySqlDataReader reader3 = command3.ExecuteReader();
                if (reader3.HasRows)
                {
                    reader3.Close();
                    //Its a student
                    PHONE.Enabled = true;
                    PHONE.ReadOnly = false;
                    ABOUT.Enabled = true;
                    ABOUT.ReadOnly = false;
                    MALE.Visible = true;
                    FEMALE.Visible = true;
                    GENDER.Visible = false;
                    DATE_TEXT.Visible = false;
                    DATE.Visible = true;
                    POS1.Visible = true;
                    POS2.Visible = false;
                    pictureBox1.Enabled = true;
                    iconButton1.Text = "Save";
                    string sql2 = "SELECT EMAIL,PHONE,ABOUT,POSITION,BIRTHDAY,GENDER,PFP FROM ETUDIANT WHERE PWD = '" + Variables.password + "'";
                    MySqlCommand command2 = new MySqlCommand(sql2, this.connection);
                    try
                    {
                        MySqlDataReader reader2 = command2.ExecuteReader();
                        if (reader2.Read())
                        {
                            FULL.Text = reader2["EMAIL"].ToString();
                            PHONE.Text = reader2["PHONE"].ToString();
                            ABOUT.Text = reader2["ABOUT"].ToString();
                            POS2.Text = reader2["POSITION"].ToString();
                            GENDER.Text = reader2["GENDER"].ToString();
                            DateTime birthday = reader2.GetDateTime("BIRTHDAY");
                            DATE.Value = birthday;
                        }
                        reader2.Close();
                    }
                    catch (MySqlException exception)
                    {
                        MessageBox.Show("Error: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    reader3.Close();
                    //Its a teatcher
                    PHONE.Enabled = true;
                    PHONE.ReadOnly = false;
                    ABOUT.Enabled = true;
                    ABOUT.ReadOnly = false;
                    MALE.Visible = true;
                    FEMALE.Visible = true;
                    GENDER.Visible = false;
                    DATE_TEXT.Visible = false;
                    DATE.Visible = true;

                    pictureBox1.Enabled = true;
                    iconButton1.Text = "Save";
                    string sql2 = "SELECT EMAIL,PHONE,ABOUT,POSITION,BIRTHDAY,GENDER,PFP FROM professor WHERE PWD = '" + Variables.password + "'";
                    MySqlCommand command2 = new MySqlCommand(sql2, this.connection);
                    try
                    {
                        MySqlDataReader reader2 = command2.ExecuteReader();
                        if (reader2.Read())
                        {
                            FULL.Text = reader2["EMAIL"].ToString();
                            PHONE.Text = reader2["PHONE"].ToString();
                            ABOUT.Text = reader2["ABOUT"].ToString();
                            POS2.Text = reader2["POSITION"].ToString();
                            GENDER.Text = reader2["GENDER"].ToString();
                            DateTime birthday = reader2.GetDateTime("BIRTHDAY");
                            DATE.Value = birthday;
                        }
                        reader2.Close();
                    }
                    catch (MySqlException exception)
                    {
                        MessageBox.Show("Error: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                string sexe;
                if (MALE.Checked)
                {
                    sexe = "MALE";
                }
                else
                {
                    sexe = "FEMALE";
                }
                // Convert the image from PictureBox to byte array

                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
                byte[] imageBytes = stream.ToArray();
                stream.Close();
                string sql3 = "SELECT FIRST FROM ETUDIANT WHERE PWD = '" + Variables.password + "'";
                MySqlCommand command3 = new MySqlCommand(sql3, this.connection);
                MySqlDataReader reader3 = command3.ExecuteReader();
                if (reader3.HasRows)
                {
                    reader3.Close();
                    //Its a student
                    string sql4 = "UPDATE Etudiant SET PHONE = '" + PHONE.Text + "', ABOUT = '" + ABOUT.Text + "', POSITION = '" + POS1.SelectedItem + "', BIRTHDAY = '" + DATE.Value.ToString("yyyy-MM-dd") + "', GENDER = '" + sexe + "', PFP = '" + Convert.ToBase64String(imageBytes) + "' WHERE PWD = '" + Variables.password + "';";
                    MySqlCommand command = new MySqlCommand(sql4, this.connection);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (MySqlException exe)
                    {
                        MessageBox.Show(exe.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    iconButton1.Text = "Edit";
                    PHONE.Enabled = false;
                    PHONE.ReadOnly = true;
                    ABOUT.Enabled = false;
                    ABOUT.ReadOnly = true;
                    MALE.Visible = false;
                    FEMALE.Visible = false;
                    GENDER.Visible = true;
                    DATE_TEXT.Visible = true;
                    DATE.Visible = false;

                    pictureBox1.Enabled = false;
                }
                else
                {
                    reader3.Close();
                    //its a teatcher
                    string sql5 = "UPDATE professor SET PHONE = '" + PHONE.Text + "', ABOUT = '" + ABOUT.Text + "', POSITION = '" + "Teatcher" +
                        "" + "', BIRTHDAY = '" + DATE.Value.ToString("yyyy-MM-dd") + "', GENDER = '" + sexe + "', PFP = '" + Convert.ToBase64String(imageBytes) + "' WHERE PWD = '" + Variables.password + "';";
                    MySqlCommand command = new MySqlCommand(sql5, this.connection);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (MySqlException exe)
                    {
                        MessageBox.Show(exe.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    iconButton1.Text = "Edit";
                    PHONE.Enabled = false;
                    PHONE.ReadOnly = true;
                    ABOUT.Enabled = false;
                    ABOUT.ReadOnly = true;
                    MALE.Visible = false;
                    FEMALE.Visible = false;
                    GENDER.Visible = true;
                    DATE_TEXT.Visible = true;
                    DATE.Visible = false;

                }
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;

                // Load the image from the file
                Image image = Image.FromFile(filePath);

                // Create a circular region for the image
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Region = new Region(path);

                // Set the image to the picture box
                pictureBox1.Image = image;

                // Stretch the image to fit the picture box
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            
        }
    }
}
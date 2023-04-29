using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PFE
{
    public partial class UserControl5 : UserControl
    {
        MySqlConnection connection;
        public UserControl5()
        {
            InitializeComponent();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Home home = (Home)FindForm();
            home.Close();
        }


  

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SEND_Click(object sender, EventArgs e)
        {
            string sql1 = "SELECT ID FROM Etudiant WHERE PWD = '" + Variables.password + "'";
            MySqlCommand command = new MySqlCommand(sql1, this.connection);
            MySqlDataReader reader1 = command.ExecuteReader();
            if (reader1.HasRows)
            {
                //Its a student
                reader1.Close();
                try
                {
                    if (!(MESSAGE.Text == ""))
                    {
                        string sql2 = "INSERT INTO messages (sender_id, message) " +
                                      "VALUES ((SELECT ID FROM Etudiant WHERE PWD = '" + Variables.password + "'), '" + MESSAGE.Text.ToString() + "')";
                        MySqlCommand command5 = new MySqlCommand(sql2, this.connection);
                        if (!(MESSAGE.Text == ""))
                        {
                            command5.ExecuteNonQuery();
                        }
                    }
                }
                catch (MySqlException exce)
                {
                    MessageBox.Show(exce.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Its a teatcher
                reader1.Close();
                try
                {
                    if (!(MESSAGE.Text == ""))
                    {
                        string sql2 = "INSERT INTO messages_prof (sender_prof_id, message) " +
                                      "VALUES ((SELECT ID_PROF  FROM professor WHERE PWD = '" + Variables.password + "'), '" + MESSAGE.Text.ToString() + "')";
                        MySqlCommand command5 = new MySqlCommand(sql2, this.connection);
                        if (!(MESSAGE.Text == ""))
                        {
                            command5.ExecuteNonQuery();
                        }
                    }
                }
                catch (MySqlException exce)
                {
                    MessageBox.Show(exce.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Show the last message that has been inserted in the chat
            string sql4 = "SELECT ID FROM Etudiant WHERE PWD = '" + Variables.password + "'";
            MySqlCommand command4 = new MySqlCommand(sql4, this.connection);
            MySqlDataReader reader4 = command4.ExecuteReader();
            string sql3 = "SELECT message,Message_timestamp,FIRST FROM messages,Etudiant WHERE (Message_timestamp = (SELECT MAX(Message_timestamp) FROM messages)) and (ID=sender_id)";
            if (reader4.HasRows)
            {
                reader4.Close();
                MySqlCommand command2 = new MySqlCommand(sql3, this.connection);
                try
                {
                    MySqlDataReader reader = command2.ExecuteReader();
                    while (reader.Read())
                    {
                        // Putting the messages in the CHAT (Environment.NewLine is similar to /n)
                        if (!(MESSAGE.Text == ""))
                        {
                            CHAT.SelectionColor = CHAT.ForeColor;
                            CHAT.AppendText(reader["FIRST"] + " : " + reader["message"].ToString() + Environment.NewLine);
                            MESSAGE.Clear();
                        }
                    }
                    reader.Close();
                }
                catch (MySqlException exce)
                {
                    MessageBox.Show(exce.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                reader4.Close();
                string sql5 = "SELECT message,Message_timestamp,FIRST FROM messages_prof,professor WHERE (Message_timestamp = (SELECT MAX(Message_timestamp) FROM messages_prof)) and (sender_prof_id = ID_PROF)";
                MySqlCommand command5 = new MySqlCommand(sql5, this.connection);
                try
                {
                    MySqlDataReader reader5 = command5.ExecuteReader();
                    while (reader5.Read())
                    {
                        // Putting the messages in the CHAT (Environment.NewLine is similar to /n)
                        if (!(MESSAGE.Text == ""))
                        {
                            CHAT.SelectionColor = Color.Red;
                            CHAT.AppendText(reader5["FIRST"] + " : " + reader5["message"].ToString() + Environment.NewLine);
                            MESSAGE.Clear();
                        }
                    }
                    reader5.Close();
                }
                catch (MySqlException exce)
                {
                    MessageBox.Show(exce.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl5_Load(object sender, EventArgs e)
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
            //Selecting all messages from both tables and ordering them by the time they were sent
            string sql = "SELECT message, Message_timestamp, FIRST , POSITION FROM messages_prof, professor WHERE sender_prof_id = ID_PROF " +
                         "UNION " +
                         "SELECT message, Message_timestamp, FIRST , POSITION FROM messages, Etudiant WHERE sender_id = ID " +
                         "ORDER BY Message_timestamp";
            MySqlCommand command = new MySqlCommand(sql,this.connection);
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //Checking if the Message is sent buy a teatcher or a student , if its sent by a teatcher its collor become red
                    if (reader["POSITION"].ToString() == "Teatcher")
                    {
                        CHAT.SelectionColor = Color.Red;
                    }
                    else
                    {
                        CHAT.SelectionColor = CHAT.ForeColor;
                    }
                    CHAT.AppendText(reader["FIRST"] + " : " + reader["message"].ToString() + Environment.NewLine);
                }
                reader.Close();
            }
            catch (MySqlException exce)
            {
                MessageBox.Show(exce.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE
{
    public partial class UserControl7 : UserControl
    {
        MySqlConnection connection;
        List<Label> Labels = new List<Label>();

        public UserControl7()
        {
            InitializeComponent();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Home home = (Home)FindForm();
            home.Close();
        }
        private void Search()
        {
            string sql = "SELECT FIRST FROM etudiant";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dt);
            searchResult.DataSource = dt;
        }
        private void UserControl7_Load(object sender, EventArgs e)
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
            string sql = "SELECT FIRST FROM etudiant";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = command.ExecuteReader();

            int x = 80;
            int y = 50;
            int S = 0;
            while (reader.Read())
            {
                S++;
                Label label = new Label();
                label.Text = reader["FIRST"].ToString();
                label.Top = x;
                label.Left = y;
                label.Font = new Font("Microsoft Sans Serif", 16.8f, FontStyle.Regular);
                label.ForeColor = Color.White;
                label.BackColor = Color.FromArgb(22, 66, 127);
                label.Height = 40;
                this.Controls.Add(label);
                Labels.Add(label);
                y += label.Width + 20;
                if (S>3)
                {
                    S = 0;
                    x += 80;
                    y = 50;
                }
            }
            reader.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM etudiant WHERE FIRST = '" + NAME.Text.ToString() + "'";
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            command.ExecuteNonQuery();
            for (int i = Labels.Count - 1; i >= 0; i--)
            {
                if (Labels[i].Text == NAME.Text.ToString()) 
                {
                    this.Controls.Remove(Labels[i]);
                    Labels.RemoveAt(i);
                }
            }
            
          UserControl7_Load(sender, e);
        }

        private void NAME_TextChanged(object sender, EventArgs e)
        {
            if (NAME.Text.ToString().Length >= 1)
            {
                string sql = "SELECT FIRST FROM etudiant ";
                sql += "WHERE FIRST LIKE ?";
                MySqlCommand command = new MySqlCommand(sql, this.connection);
                command.Parameters.AddWithValue("FIRST", NAME.Text.ToString()+"%");
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                da.Fill(dt);
                if(dt!=null && dt.Rows.Count > 0)
                {
                    searchResult.DataSource = dt;
                    searchResult.Height= searchResult.Rows.Count * 30;
                }
                else
                {
                    searchResult.Height = 0;
                }
            }
            else if(NAME.Text.ToString().Length == 0)
            {
                searchResult.Height = 0;
            }
        }



        private void searchResult_MouseClick(object sender, MouseEventArgs e)
        {
            NAME.Text = "";
        }

        private void searchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.searchResult.Rows[e.RowIndex];
            if (row?.Cells["FIRST"]?.Value != null)
            {
                NAME.Text = row.Cells["FIRST"].Value.ToString();
                searchResult.Height = 0;
            }
        }
    }
    }

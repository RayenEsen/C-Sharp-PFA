using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE
{
    public partial class UserControl6 : UserControl
    {
        List<TextBox> textBoxes1 = new List<TextBox>();
        List<TextBox> textBoxes2 = new List<TextBox>();
        List<Label> Label = new List<Label>();

        public UserControl6()
        {
            InitializeComponent();
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {

        }
        int x = 1;
        int y = 1;
        private void iconButton2_Click(object sender, EventArgs e)
        {
            TextBox t1 = new TextBox();
            this.Controls.Add(t1);

            if (x == 1)
            {
                t1.Top = 110;
                t1.Left = 450;
            }
            else
            {
                t1.Top = textBoxes1.Last().Bottom + 30;
                t1.Left = 450;
            }
            x++;
            textBoxes1.Add(t1);
            t1.BackColor = Color.White;
            t1.BorderStyle = BorderStyle.None;
            t1.ForeColor = Color.FromArgb(22, 66, 127);
            t1.Width = 20;
            t1.Height = 100;
            t1.Font = new Font("Microsoft Sans Serif", 15f);
            TextBox t2 = new TextBox();
            this.Controls.Add(t2);
            if (y == 1)
            {
                t2.Top = 110;
                t2.Left = 250;
            }
            else
            {
                t2.Top = textBoxes2.Last().Bottom + 30;
                t2.Left = 250;
            }
            y++;
            textBoxes2.Add(t2);

            t2.BackColor = Color.FromArgb(22, 66, 127);
            t2.BorderStyle = BorderStyle.None;
            t2.ForeColor = Color.White;
            t2.Width = 200;
            t2.Height = 100;
            t2.Font = new Font("Microsoft Sans Serif", 15f);
            Label label2 = new Label();
            label2.Text = "Matier " + (y - 1);
            label2.Top = t2.Top - 20;
            label2.Left = t2.Left;
            label2.ForeColor = Color.FromArgb(22, 66, 127);
            this.Controls.Add(label2);
            Label.Add(label2);
        }


        private double Calculator()
        {
            double  S = 0;
            for (int i = 0; i < textBoxes1.Count; i++)
            {
                double t1 = Convert.ToDouble(textBoxes1[i].Text);
                double t2 = Convert.ToDouble(textBoxes2[i].Text);
                S += t1 * t2;
            }
            return S;
        }



        private void EXIT_Click(object sender, EventArgs e)
        {
            Home home = (Home)this.FindForm();
            home.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            double result = Calculator();
            result /= 15;
            label1.Text = result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //If there still exist textBoxes in the List we  Can still remove more
            if (textBoxes1.Count > 0)
            {
                TextBox t1 = textBoxes1.Last();
                this.Controls.Remove(t1);
                textBoxes1.Remove(t1);
            }
            if (textBoxes2.Count > 0)
            {
                TextBox t2 = textBoxes2.Last();
                this.Controls.Remove(t2);
                textBoxes2.Remove(t2);
            }
            if (Label.Count > 0)
            {
                Label label3 = Label.Last();
                this.Controls.Remove(label3);
                Label.Remove(label3);
            }
            //Decrement both x and y
            x--;
            y--;
        }
    }
}

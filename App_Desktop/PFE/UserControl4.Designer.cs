namespace PFE
{
    partial class UserControl4
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.DATE_TEXT = new System.Windows.Forms.TextBox();
            this.DATE = new System.Windows.Forms.DateTimePicker();
            this.GENDER = new System.Windows.Forms.TextBox();
            this.FEMALE = new System.Windows.Forms.RadioButton();
            this.MALE = new System.Windows.Forms.RadioButton();
            this.ABOUT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.POS2 = new System.Windows.Forms.TextBox();
            this.POS1 = new System.Windows.Forms.ComboBox();
            this.POSITION = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PHONE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FULL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EXIT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 80);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(533, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "PROFILE";
            // 
            // EXIT
            // 
            this.EXIT.Dock = System.Windows.Forms.DockStyle.Left;
            this.EXIT.FlatAppearance.BorderSize = 0;
            this.EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT.Image = ((System.Drawing.Image)(resources.GetObject("EXIT.Image")));
            this.EXIT.Location = new System.Drawing.Point(0, 0);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(150, 80);
            this.EXIT.TabIndex = 1;
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(484, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // NAME
            // 
            this.NAME.BackColor = System.Drawing.SystemColors.Control;
            this.NAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NAME.Enabled = false;
            this.NAME.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.NAME.Location = new System.Drawing.Point(465, 266);
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Size = new System.Drawing.Size(358, 32);
            this.NAME.TabIndex = 35;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(662, 225);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(86, 35);
            this.iconButton1.TabIndex = 36;
            this.iconButton1.Text = "Edit";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // DATE_TEXT
            // 
            this.DATE_TEXT.BackColor = System.Drawing.SystemColors.Control;
            this.DATE_TEXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DATE_TEXT.Enabled = false;
            this.DATE_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_TEXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.DATE_TEXT.Location = new System.Drawing.Point(763, 451);
            this.DATE_TEXT.Name = "DATE_TEXT";
            this.DATE_TEXT.ReadOnly = true;
            this.DATE_TEXT.Size = new System.Drawing.Size(98, 21);
            this.DATE_TEXT.TabIndex = 29;
            // 
            // DATE
            // 
            this.DATE.Location = new System.Drawing.Point(763, 450);
            this.DATE.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(188, 22);
            this.DATE.TabIndex = 27;
            this.DATE.Visible = false;
            // 
            // GENDER
            // 
            this.GENDER.BackColor = System.Drawing.SystemColors.Control;
            this.GENDER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GENDER.Enabled = false;
            this.GENDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENDER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.GENDER.Location = new System.Drawing.Point(763, 496);
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            this.GENDER.Size = new System.Drawing.Size(188, 21);
            this.GENDER.TabIndex = 25;
            // 
            // FEMALE
            // 
            this.FEMALE.AutoSize = true;
            this.FEMALE.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FEMALE.Location = new System.Drawing.Point(815, 498);
            this.FEMALE.Name = "FEMALE";
            this.FEMALE.Size = new System.Drawing.Size(34, 17);
            this.FEMALE.TabIndex = 24;
            this.FEMALE.TabStop = true;
            this.FEMALE.Text = "F";
            this.FEMALE.UseVisualStyleBackColor = true;
            this.FEMALE.Visible = false;
            // 
            // MALE
            // 
            this.MALE.AutoSize = true;
            this.MALE.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MALE.Location = new System.Drawing.Point(753, 498);
            this.MALE.Name = "MALE";
            this.MALE.Size = new System.Drawing.Size(37, 17);
            this.MALE.TabIndex = 23;
            this.MALE.TabStop = true;
            this.MALE.Text = "M";
            this.MALE.UseVisualStyleBackColor = true;
            this.MALE.Visible = false;
            // 
            // ABOUT
            // 
            this.ABOUT.BackColor = System.Drawing.SystemColors.Control;
            this.ABOUT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ABOUT.Enabled = false;
            this.ABOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABOUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.ABOUT.Location = new System.Drawing.Point(763, 540);
            this.ABOUT.Multiline = true;
            this.ABOUT.Name = "ABOUT";
            this.ABOUT.ReadOnly = true;
            this.ABOUT.Size = new System.Drawing.Size(188, 117);
            this.ABOUT.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(182)))));
            this.label5.Location = new System.Drawing.Point(636, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(182)))));
            this.label6.Location = new System.Drawing.Point(637, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "About-me:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(182)))));
            this.label7.Location = new System.Drawing.Point(620, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "General information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(182)))));
            this.label8.Location = new System.Drawing.Point(636, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Birthday:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.DATE_TEXT);
            this.panel2.Controls.Add(this.POS2);
            this.panel2.Controls.Add(this.DATE);
            this.panel2.Controls.Add(this.GENDER);
            this.panel2.Controls.Add(this.POS1);
            this.panel2.Controls.Add(this.FEMALE);
            this.panel2.Controls.Add(this.POSITION);
            this.panel2.Controls.Add(this.MALE);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.ABOUT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.NAME);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.PHONE);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FULL);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-75, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 777);
            this.panel2.TabIndex = 3;
            // 
            // POS2
            // 
            this.POS2.BackColor = System.Drawing.SystemColors.Control;
            this.POS2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.POS2.Enabled = false;
            this.POS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POS2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.POS2.Location = new System.Drawing.Point(343, 541);
            this.POS2.Name = "POS2";
            this.POS2.ReadOnly = true;
            this.POS2.Size = new System.Drawing.Size(164, 21);
            this.POS2.TabIndex = 31;
            // 
            // POS1
            // 
            this.POS1.FormattingEnabled = true;
            this.POS1.Items.AddRange(new object[] {
            "Licence 1",
            "Licence 2",
            "Licence 2 (BIS)",
            "Licence 2 (EBUS)",
            "Licence 2 (BIS)",
            "Licence 3 (BIS)",
            "Licence 3 (EBUS)",
            "Licence 3 (BIS)"});
            this.POS1.Location = new System.Drawing.Point(343, 538);
            this.POS1.Name = "POS1";
            this.POS1.Size = new System.Drawing.Size(164, 24);
            this.POS1.TabIndex = 30;
            this.POS1.Visible = false;
            // 
            // POSITION
            // 
            this.POSITION.BackColor = System.Drawing.SystemColors.Control;
            this.POSITION.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.POSITION.Enabled = false;
            this.POSITION.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSITION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.POSITION.Location = new System.Drawing.Point(343, 541);
            this.POSITION.Name = "POSITION";
            this.POSITION.ReadOnly = true;
            this.POSITION.Size = new System.Drawing.Size(164, 21);
            this.POSITION.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(182)))));
            this.label4.Location = new System.Drawing.Point(238, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone:";
            // 
            // PHONE
            // 
            this.PHONE.BackColor = System.Drawing.SystemColors.Control;
            this.PHONE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PHONE.Enabled = false;
            this.PHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHONE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.PHONE.Location = new System.Drawing.Point(343, 493);
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            this.PHONE.Size = new System.Drawing.Size(164, 21);
            this.PHONE.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(239, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Position: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(205, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = " Contact information";
            // 
            // FULL
            // 
            this.FULL.BackColor = System.Drawing.SystemColors.Control;
            this.FULL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FULL.Enabled = false;
            this.FULL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FULL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.FULL.Location = new System.Drawing.Point(343, 447);
            this.FULL.Name = "FULL";
            this.FULL.ReadOnly = true;
            this.FULL.Size = new System.Drawing.Size(164, 21);
            this.FULL.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(238, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-mail:";
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(1191, 854);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NAME;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox DATE_TEXT;
        private System.Windows.Forms.DateTimePicker DATE;
        private System.Windows.Forms.TextBox GENDER;
        private System.Windows.Forms.RadioButton FEMALE;
        private System.Windows.Forms.RadioButton MALE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ABOUT;
        private System.Windows.Forms.TextBox POS2;
        private System.Windows.Forms.ComboBox POS1;
        private System.Windows.Forms.TextBox POSITION;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PHONE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FULL;
        private System.Windows.Forms.Label label1;
    }
}

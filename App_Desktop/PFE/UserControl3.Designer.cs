namespace PFE
{
    partial class UserControl3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EXIT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FULL = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.REGISTER = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SHOW = new FontAwesome.Sharp.IconButton();
            this.Password = new System.Windows.Forms.TextBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.TextBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.Error1 = new System.Windows.Forms.Label();
            this.Error2 = new System.Windows.Forms.Label();
            this.Error3 = new System.Windows.Forms.Label();
            this.Error4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.EXIT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 80);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(294, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.panel3.Controls.Add(this.FULL);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Location = new System.Drawing.Point(297, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 45);
            this.panel3.TabIndex = 10;
            // 
            // FULL
            // 
            this.FULL.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.FULL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.FULL.Location = new System.Drawing.Point(56, 4);
            this.FULL.Name = "FULL";
            this.FULL.Size = new System.Drawing.Size(315, 38);
            this.FULL.TabIndex = 3;
            this.FULL.Text = "Full name";
            this.FULL.TextChanged += new System.EventHandler(this.FULL_TextChanged);
            this.FULL.Enter += new System.EventHandler(this.FULL_Enter);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(47, 40);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.panel4.Controls.Add(this.EMAIL);
            this.panel4.Controls.Add(this.iconPictureBox2);
            this.panel4.Location = new System.Drawing.Point(297, 412);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(374, 45);
            this.panel4.TabIndex = 11;
            // 
            // EMAIL
            // 
            this.EMAIL.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.EMAIL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.EMAIL.Location = new System.Drawing.Point(56, 3);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(315, 38);
            this.EMAIL.TabIndex = 2;
            this.EMAIL.Text = "Email";
            this.EMAIL.Enter += new System.EventHandler(this.EMAIL_Enter);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.At;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 40;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(47, 40);
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // REGISTER
            // 
            this.REGISTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.REGISTER.FlatAppearance.BorderSize = 0;
            this.REGISTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REGISTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTER.ForeColor = System.Drawing.Color.White;
            this.REGISTER.Location = new System.Drawing.Point(556, 661);
            this.REGISTER.Name = "REGISTER";
            this.REGISTER.Size = new System.Drawing.Size(115, 48);
            this.REGISTER.TabIndex = 14;
            this.REGISTER.Text = "Sign Up";
            this.REGISTER.UseVisualStyleBackColor = false;
            this.REGISTER.Click += new System.EventHandler(this.REGISTER_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.panel2.Controls.Add(this.SHOW);
            this.panel2.Controls.Add(this.Password);
            this.panel2.Controls.Add(this.iconPictureBox3);
            this.panel2.Location = new System.Drawing.Point(297, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 48);
            this.panel2.TabIndex = 15;
            // 
            // SHOW
            // 
            this.SHOW.BackColor = System.Drawing.SystemColors.Window;
            this.SHOW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.SHOW.FlatAppearance.BorderSize = 0;
            this.SHOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SHOW.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.SHOW.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.SHOW.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SHOW.IconSize = 36;
            this.SHOW.Location = new System.Drawing.Point(327, 7);
            this.SHOW.Name = "SHOW";
            this.SHOW.Size = new System.Drawing.Size(44, 34);
            this.SHOW.TabIndex = 18;
            this.SHOW.UseVisualStyleBackColor = false;
            this.SHOW.Click += new System.EventHandler(this.SHOW_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.Password.Location = new System.Drawing.Point(56, 5);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(315, 38);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 40;
            this.iconPictureBox3.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(47, 40);
            this.iconPictureBox3.TabIndex = 0;
            this.iconPictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.panel6.Controls.Add(this.ID);
            this.panel6.Controls.Add(this.iconPictureBox5);
            this.panel6.Location = new System.Drawing.Point(297, 601);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(374, 45);
            this.panel6.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.ID.Location = new System.Drawing.Point(56, 3);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(315, 38);
            this.ID.TabIndex = 2;
            this.ID.Text = "CIN";
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.Enter += new System.EventHandler(this.ID_Enter);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox5.IconColor = System.Drawing.Color.White;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 40;
            this.iconPictureBox5.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(47, 40);
            this.iconPictureBox5.TabIndex = 0;
            this.iconPictureBox5.TabStop = false;
            // 
            // Error1
            // 
            this.Error1.AutoSize = true;
            this.Error1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.Error1.Location = new System.Drawing.Point(297, 370);
            this.Error1.Name = "Error1";
            this.Error1.Size = new System.Drawing.Size(106, 16);
            this.Error1.TabIndex = 18;
            this.Error1.Text = "Name is missing";
            this.Error1.Visible = false;
            // 
            // Error2
            // 
            this.Error2.AutoSize = true;
            this.Error2.BackColor = System.Drawing.Color.Transparent;
            this.Error2.ForeColor = System.Drawing.Color.White;
            this.Error2.Location = new System.Drawing.Point(297, 469);
            this.Error2.Name = "Error2";
            this.Error2.Size = new System.Drawing.Size(103, 16);
            this.Error2.TabIndex = 19;
            this.Error2.Text = "Email is missing";
            this.Error2.Visible = false;
            this.Error2.Click += new System.EventHandler(this.Error2_Click);
            // 
            // Error3
            // 
            this.Error3.AutoSize = true;
            this.Error3.BackColor = System.Drawing.Color.Transparent;
            this.Error3.ForeColor = System.Drawing.Color.White;
            this.Error3.Location = new System.Drawing.Point(297, 565);
            this.Error3.Name = "Error3";
            this.Error3.Size = new System.Drawing.Size(129, 16);
            this.Error3.TabIndex = 20;
            this.Error3.Text = "Password is missing";
            this.Error3.Visible = false;
            this.Error3.Click += new System.EventHandler(this.Error3_Click);
            // 
            // Error4
            // 
            this.Error4.AutoSize = true;
            this.Error4.BackColor = System.Drawing.Color.Transparent;
            this.Error4.ForeColor = System.Drawing.Color.White;
            this.Error4.Location = new System.Drawing.Point(297, 661);
            this.Error4.Name = "Error4";
            this.Error4.Size = new System.Drawing.Size(80, 16);
            this.Error4.TabIndex = 21;
            this.Error4.Text = "Id is missing";
            this.Error4.Visible = false;
            this.Error4.Click += new System.EventHandler(this.Error4_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Error4);
            this.Controls.Add(this.Error3);
            this.Controls.Add(this.Error2);
            this.Controls.Add(this.Error1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.REGISTER);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(794, 856);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox FULL;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox EMAIL;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Button REGISTER;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Password;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox ID;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconButton SHOW;
        private System.Windows.Forms.Label Error1;
        private System.Windows.Forms.Label Error2;
        private System.Windows.Forms.Label Error3;
        private System.Windows.Forms.Label Error4;
    }
}

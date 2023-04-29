namespace PFE
{
    partial class UserControl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EXIT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SHOW = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.PWD = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGIN = new System.Windows.Forms.Button();
            this.Error1 = new System.Windows.Forms.Label();
            this.Error2 = new System.Windows.Forms.Label();
            this.userControl41 = new PFE.UserControl4();
            this.LOGOUT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 80);
            this.panel1.TabIndex = 1;
            // 
            // EXIT
            // 
            this.EXIT.Dock = System.Windows.Forms.DockStyle.Left;
            this.EXIT.FlatAppearance.BorderSize = 0;
            this.EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT.Image = ((System.Drawing.Image)(resources.GetObject("EXIT.Image")));
            this.EXIT.Location = new System.Drawing.Point(0, 0);
            this.EXIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(149, 80);
            this.EXIT.TabIndex = 1;
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(435, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.panel2.Controls.Add(this.EMAIL);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Location = new System.Drawing.Point(313, 386);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 46);
            this.panel2.TabIndex = 3;
            // 
            // EMAIL
            // 
            this.EMAIL.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.EMAIL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.EMAIL.Location = new System.Drawing.Point(56, 4);
            this.EMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(315, 38);
            this.EMAIL.TabIndex = 3;
            this.EMAIL.Text = "Email";
            this.EMAIL.TextChanged += new System.EventHandler(this.EMAIL_TextChanged);
            this.EMAIL.Enter += new System.EventHandler(this.EMAIL_Enter);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.At;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 2);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(47, 39);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.panel3.Controls.Add(this.SHOW);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Controls.Add(this.PWD);
            this.panel3.Location = new System.Drawing.Point(313, 468);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 53);
            this.panel3.TabIndex = 4;
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
            this.SHOW.Location = new System.Drawing.Point(325, 10);
            this.SHOW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SHOW.Name = "SHOW";
            this.SHOW.Size = new System.Drawing.Size(35, 34);
            this.SHOW.TabIndex = 19;
            this.SHOW.UseVisualStyleBackColor = false;
            this.SHOW.Click += new System.EventHandler(this.SHOW_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 39;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 10);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(47, 39);
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // PWD
            // 
            this.PWD.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.PWD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.PWD.Location = new System.Drawing.Point(56, 7);
            this.PWD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PWD.Name = "PWD";
            this.PWD.Size = new System.Drawing.Size(315, 38);
            this.PWD.TabIndex = 2;
            this.PWD.Text = "Password";
            this.PWD.UseSystemPasswordChar = true;
            this.PWD.TextChanged += new System.EventHandler(this.PWD_TextChanged);
            this.PWD.Enter += new System.EventHandler(this.PWD_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(316, 544);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Remmember me";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(523, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Forgot password ?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // LOGIN
            // 
            this.LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.LOGIN.FlatAppearance.BorderSize = 0;
            this.LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.ForeColor = System.Drawing.Color.White;
            this.LOGIN.Location = new System.Drawing.Point(445, 603);
            this.LOGIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(115, 48);
            this.LOGIN.TabIndex = 7;
            this.LOGIN.Text = "Sign In";
            this.LOGIN.UseVisualStyleBackColor = false;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // Error1
            // 
            this.Error1.AutoSize = true;
            this.Error1.BackColor = System.Drawing.Color.Transparent;
            this.Error1.ForeColor = System.Drawing.Color.White;
            this.Error1.Location = new System.Drawing.Point(313, 434);
            this.Error1.Name = "Error1";
            this.Error1.Size = new System.Drawing.Size(90, 16);
            this.Error1.TabIndex = 8;
            this.Error1.Text = "Email Missing";
            this.Error1.Visible = false;
            // 
            // Error2
            // 
            this.Error2.AutoSize = true;
            this.Error2.BackColor = System.Drawing.Color.Transparent;
            this.Error2.ForeColor = System.Drawing.Color.White;
            this.Error2.Location = new System.Drawing.Point(313, 524);
            this.Error2.Name = "Error2";
            this.Error2.Size = new System.Drawing.Size(116, 16);
            this.Error2.TabIndex = 9;
            this.Error2.Text = "Password Missing";
            this.Error2.Visible = false;
            // 
            // userControl41
            // 
            this.userControl41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl41.Location = new System.Drawing.Point(0, 0);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(936, 809);
            this.userControl41.TabIndex = 10;
            this.userControl41.Visible = false;
            // 
            // LOGOUT
            // 
            this.LOGOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(182)))));
            this.LOGOUT.FlatAppearance.BorderSize = 0;
            this.LOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGOUT.Image = ((System.Drawing.Image)(resources.GetObject("LOGOUT.Image")));
            this.LOGOUT.Location = new System.Drawing.Point(841, 34);
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(75, 55);
            this.LOGOUT.TabIndex = 12;
            this.LOGOUT.UseVisualStyleBackColor = false;
            this.LOGOUT.Click += new System.EventHandler(this.LOGOUT_Click_1);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.userControl41);
            this.Controls.Add(this.LOGOUT);
            this.Controls.Add(this.Error2);
            this.Controls.Add(this.Error1);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(936, 809);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.TextBox PWD;
        private System.Windows.Forms.TextBox EMAIL;
        private FontAwesome.Sharp.IconButton SHOW;
        private System.Windows.Forms.Label Error1;
        private System.Windows.Forms.Label Error2;
        private UserControl4 userControl41;
        private System.Windows.Forms.Button LOGOUT;
    }
}

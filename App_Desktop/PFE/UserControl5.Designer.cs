namespace PFE
{
    partial class UserControl5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EXIT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SEND = new FontAwesome.Sharp.IconButton();
            this.MESSAGE = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CHAT = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(876, 65);
            this.panel1.TabIndex = 3;
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
            this.EXIT.Size = new System.Drawing.Size(150, 65);
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
            this.label1.Location = new System.Drawing.Point(405, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHAT";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SEND);
            this.panel4.Controls.Add(this.MESSAGE);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 495);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(676, 38);
            this.panel4.TabIndex = 9;
            // 
            // SEND
            // 
            this.SEND.BackColor = System.Drawing.Color.White;
            this.SEND.FlatAppearance.BorderSize = 0;
            this.SEND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SEND.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.SEND.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.SEND.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SEND.IconSize = 38;
            this.SEND.Location = new System.Drawing.Point(629, 3);
            this.SEND.Name = "SEND";
            this.SEND.Size = new System.Drawing.Size(47, 32);
            this.SEND.TabIndex = 8;
            this.SEND.UseVisualStyleBackColor = false;
            this.SEND.Click += new System.EventHandler(this.SEND_Click);
            // 
            // MESSAGE
            // 
            this.MESSAGE.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F);
            this.MESSAGE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.MESSAGE.Location = new System.Drawing.Point(0, 0);
            this.MESSAGE.Name = "MESSAGE";
            this.MESSAGE.Size = new System.Drawing.Size(676, 38);
            this.MESSAGE.TabIndex = 9;
            this.MESSAGE.Text = "";
            this.MESSAGE.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CHAT);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 533);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // CHAT
            // 
            this.CHAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CHAT.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.CHAT.Location = new System.Drawing.Point(-3, 0);
            this.CHAT.Name = "CHAT";
            this.CHAT.ReadOnly = true;
            this.CHAT.Size = new System.Drawing.Size(676, 495);
            this.CHAT.TabIndex = 10;
            this.CHAT.Text = "";
            this.CHAT.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // UserControl5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(876, 783);
            this.Load += new System.EventHandler(this.UserControl5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton SEND;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox MESSAGE;
        private System.Windows.Forms.RichTextBox CHAT;
    }
}

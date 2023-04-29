namespace PFE
{
    partial class UserControl7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl7));
            this.label1 = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new FontAwesome.Sharp.IconButton();
            this.NAME = new System.Windows.Forms.TextBox();
            this.searchResult = new System.Windows.Forms.DataGridView();
            this.FIRST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(347, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.EXIT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 80);
            this.panel1.TabIndex = 3;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(127)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.Delete.IconColor = System.Drawing.Color.White;
            this.Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Delete.IconSize = 28;
            this.Delete.Location = new System.Drawing.Point(742, 116);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(145, 39);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // NAME
            // 
            this.NAME.BackColor = System.Drawing.SystemColors.Control;
            this.NAME.Location = new System.Drawing.Point(742, 161);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(145, 22);
            this.NAME.TabIndex = 5;
            this.NAME.Text = "Username";
            this.NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NAME.TextChanged += new System.EventHandler(this.NAME_TextChanged);
            // 
            // searchResult
            // 
            this.searchResult.AllowUserToAddRows = false;
            this.searchResult.AllowUserToDeleteRows = false;
            this.searchResult.AllowUserToResizeColumns = false;
            this.searchResult.AllowUserToResizeRows = false;
            this.searchResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.searchResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResult.ColumnHeadersVisible = false;
            this.searchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIRST});
            this.searchResult.Location = new System.Drawing.Point(742, 189);
            this.searchResult.Name = "searchResult";
            this.searchResult.RowHeadersVisible = false;
            this.searchResult.RowHeadersWidth = 51;
            this.searchResult.RowTemplate.Height = 30;
            this.searchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResult.Size = new System.Drawing.Size(145, 0);
            this.searchResult.TabIndex = 6;
            this.searchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResult_CellClick);
            this.searchResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchResult_MouseClick);
            // 
            // FIRST
            // 
            this.FIRST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FIRST.DataPropertyName = "name";
            this.FIRST.HeaderText = "FIRST";
            this.FIRST.MinimumWidth = 6;
            this.FIRST.Name = "FIRST";
            this.FIRST.ReadOnly = true;
            // 
            // UserControl7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl7";
            this.Size = new System.Drawing.Size(900, 686);
            this.Load += new System.EventHandler(this.UserControl7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Delete;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.DataGridView searchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRST;
    }
}

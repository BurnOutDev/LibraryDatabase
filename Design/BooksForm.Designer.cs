namespace Design
{
    partial class BooksForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mGrdBooks = new MetroFramework.Controls.MetroGrid();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRdbGenres = new MetroFramework.Controls.MetroRadioButton();
            this.mRdbAuthors = new MetroFramework.Controls.MetroRadioButton();
            this.mRdbBooks = new MetroFramework.Controls.MetroRadioButton();
            this.mSearchBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGrdBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.splitContainer1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(483, 322);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mGrdBooks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mRdbGenres);
            this.splitContainer1.Panel2.Controls.Add(this.mRdbAuthors);
            this.splitContainer1.Panel2.Controls.Add(this.mRdbBooks);
            this.splitContainer1.Panel2.Controls.Add(this.mSearchBox);
            this.splitContainer1.Size = new System.Drawing.Size(483, 322);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 2;
            // 
            // mGrdBooks
            // 
            this.mGrdBooks.AllowUserToAddRows = false;
            this.mGrdBooks.AllowUserToDeleteRows = false;
            this.mGrdBooks.AllowUserToResizeRows = false;
            this.mGrdBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mGrdBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGrdBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGrdBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGrdBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGrdBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGrdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGrdBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.AuthorID,
            this.GenreID,
            this.BookName,
            this.AuthorName,
            this.GenreName,
            this.BooksQuantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGrdBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGrdBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mGrdBooks.EnableHeadersVisualStyles = false;
            this.mGrdBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGrdBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGrdBooks.Location = new System.Drawing.Point(0, 0);
            this.mGrdBooks.Name = "mGrdBooks";
            this.mGrdBooks.ReadOnly = true;
            this.mGrdBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGrdBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGrdBooks.RowHeadersVisible = false;
            this.mGrdBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGrdBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGrdBooks.Size = new System.Drawing.Size(483, 290);
            this.mGrdBooks.TabIndex = 4;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Visible = false;
            // 
            // AuthorID
            // 
            this.AuthorID.HeaderText = "AuthorID";
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.ReadOnly = true;
            this.AuthorID.Visible = false;
            // 
            // GenreID
            // 
            this.GenreID.HeaderText = "GenreID";
            this.GenreID.Name = "GenreID";
            this.GenreID.ReadOnly = true;
            this.GenreID.Visible = false;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "წიგნი";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // AuthorName
            // 
            this.AuthorName.HeaderText = "ავტორი";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            // 
            // GenreName
            // 
            this.GenreName.HeaderText = "ჟანრი";
            this.GenreName.Name = "GenreName";
            this.GenreName.ReadOnly = true;
            // 
            // BooksQuantity
            // 
            this.BooksQuantity.HeaderText = "რაოდენობა";
            this.BooksQuantity.Name = "BooksQuantity";
            this.BooksQuantity.ReadOnly = true;
            // 
            // mRdbGenres
            // 
            this.mRdbGenres.AutoSize = true;
            this.mRdbGenres.Location = new System.Drawing.Point(353, 6);
            this.mRdbGenres.Name = "mRdbGenres";
            this.mRdbGenres.Size = new System.Drawing.Size(58, 15);
            this.mRdbGenres.TabIndex = 3;
            this.mRdbGenres.Text = "ჟანრი";
            this.mRdbGenres.UseSelectable = true;
            // 
            // mRdbAuthors
            // 
            this.mRdbAuthors.AutoSize = true;
            this.mRdbAuthors.Location = new System.Drawing.Point(277, 6);
            this.mRdbAuthors.Name = "mRdbAuthors";
            this.mRdbAuthors.Size = new System.Drawing.Size(69, 15);
            this.mRdbAuthors.TabIndex = 2;
            this.mRdbAuthors.Text = "ავტორი";
            this.mRdbAuthors.UseSelectable = true;
            // 
            // mRdbBooks
            // 
            this.mRdbBooks.AutoSize = true;
            this.mRdbBooks.Checked = true;
            this.mRdbBooks.Location = new System.Drawing.Point(212, 6);
            this.mRdbBooks.Name = "mRdbBooks";
            this.mRdbBooks.Size = new System.Drawing.Size(59, 15);
            this.mRdbBooks.TabIndex = 1;
            this.mRdbBooks.TabStop = true;
            this.mRdbBooks.Text = "წიგნი";
            this.mRdbBooks.UseSelectable = true;
            // 
            // mSearchBox
            // 
            this.mSearchBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mSearchBox.Lines = new string[] {
        "ძებნა..."};
            this.mSearchBox.Location = new System.Drawing.Point(3, 2);
            this.mSearchBox.MaxLength = 32767;
            this.mSearchBox.Name = "mSearchBox";
            this.mSearchBox.PasswordChar = '\0';
            this.mSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mSearchBox.SelectedText = "";
            this.mSearchBox.Size = new System.Drawing.Size(203, 23);
            this.mSearchBox.TabIndex = 0;
            this.mSearchBox.Text = "ძებნა...";
            this.mSearchBox.UseSelectable = true;
            this.mSearchBox.TextChanged += new System.EventHandler(this.mSearchBox_TextChanged);
            this.mSearchBox.Enter += new System.EventHandler(this.mSearchBox_Enter);
            this.mSearchBox.Leave += new System.EventHandler(this.mSearchBox_Leave);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(268, 31);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(72, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "დამატება";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(346, 31);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(49, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "წაშლა";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton3.Location = new System.Drawing.Point(401, 31);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(99, 23);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "რედაქტირება";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 402);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroPanel1);
            this.MinimumSize = new System.Drawing.Size(469, 402);
            this.Name = "BooksForm";
            this.Text = "წიგნების კატალოგი";
            this.metroPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGrdBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid mGrdBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksQuantity;
        private MetroFramework.Controls.MetroTextBox mSearchBox;
        private MetroFramework.Controls.MetroRadioButton mRdbGenres;
        private MetroFramework.Controls.MetroRadioButton mRdbAuthors;
        private MetroFramework.Controls.MetroRadioButton mRdbBooks;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}
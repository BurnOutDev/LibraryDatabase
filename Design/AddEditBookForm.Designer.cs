namespace Design
{
    partial class AddEditBookForm
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
            this.mCbxAuthor = new MetroFramework.Controls.MetroComboBox();
            this.mTbxBookName = new MetroFramework.Controls.MetroTextBox();
            this.mCbxGenre = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mCbxAuthor
            // 
            this.mCbxAuthor.FormattingEnabled = true;
            this.mCbxAuthor.ItemHeight = 23;
            this.mCbxAuthor.Location = new System.Drawing.Point(23, 98);
            this.mCbxAuthor.Name = "mCbxAuthor";
            this.mCbxAuthor.Size = new System.Drawing.Size(254, 29);
            this.mCbxAuthor.TabIndex = 0;
            this.mCbxAuthor.UseSelectable = true;
            // 
            // mTbxBookName
            // 
            this.mTbxBookName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTbxBookName.Lines = new string[] {
        "წიგნის სახელი..."};
            this.mTbxBookName.Location = new System.Drawing.Point(23, 63);
            this.mTbxBookName.MaxLength = 32767;
            this.mTbxBookName.Name = "mTbxBookName";
            this.mTbxBookName.PasswordChar = '\0';
            this.mTbxBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTbxBookName.SelectedText = "";
            this.mTbxBookName.Size = new System.Drawing.Size(254, 29);
            this.mTbxBookName.TabIndex = 1;
            this.mTbxBookName.Text = "წიგნის სახელი...";
            this.mTbxBookName.UseSelectable = true;
            this.mTbxBookName.TextChanged += new System.EventHandler(this.mTbxBookName_TextChanged);
            this.mTbxBookName.Enter += new System.EventHandler(this.mTbxBookName_Enter);
            this.mTbxBookName.Leave += new System.EventHandler(this.mTbxBookName_Leave);
            // 
            // mCbxGenre
            // 
            this.mCbxGenre.FormattingEnabled = true;
            this.mCbxGenre.ItemHeight = 23;
            this.mCbxGenre.Location = new System.Drawing.Point(23, 133);
            this.mCbxGenre.Name = "mCbxGenre";
            this.mCbxGenre.Size = new System.Drawing.Size(254, 29);
            this.mCbxGenre.TabIndex = 0;
            this.mCbxGenre.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(78, 180);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "დამატება";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(202, 180);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "გაუქმება";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // AddEditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 226);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mTbxBookName);
            this.Controls.Add(this.mCbxGenre);
            this.Controls.Add(this.mCbxAuthor);
            this.Name = "AddEditBookForm";
            this.Text = "წიგნის დამატება";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mCbxAuthor;
        private MetroFramework.Controls.MetroTextBox mTbxBookName;
        private MetroFramework.Controls.MetroComboBox mCbxGenre;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}
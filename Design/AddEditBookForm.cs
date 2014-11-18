using LibraryDatabase;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class AddEditBookForm : MetroForm
    {
        public LibraryDbContext Db { get; set; }
        public int BookId { get; set; }

        public Book Book { get; set; }
        public AddEditBookForm(LibraryDbContext db, int bookId = 0)
        {
            InitializeComponent();
            Db = db;
            BookId = bookId;

            if (bookId > 0)
                this.Text = metroButton1.Text = "რედაქტირება";

        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            FillAllComboboxes();
            if (BookId > 0)
            {
                Book = (from x in Db.Books
                        where x.BookID == BookId
                        select x).FirstOrDefault();

                mTbxBookName.Text = Book.BookName;
                mCbxAuthor.SelectedValue = Book.AuthorID;
                mCbxGenre.SelectedValue = Book.GenreID;
            }
        }

        private void FillAllComboboxes()
        {
            #region Fill Author Combobox
            var resultBooks = from x in Db.Authors
                              select
                              new
                              {
                                  ID = x.AuthorID,
                                  Name = x.AuthorFirstName + " " + x.AuthorLastName
                              };

            FillComboBox(mCbxAuthor, resultBooks);
            #endregion

            #region Fill Genre Combobox
            var resultGenres = from x in Db.Genres
                               select
                               new
                               {
                                   ID = x.GenreID,
                                   Name = x.GenreName
                               };

            FillComboBox(mCbxGenre, resultGenres);
            #endregion
        }


        private void FillComboBox(MetroComboBox cbx, IQueryable<dynamic> dataSource)
        {
            cbx.DataSource = dataSource;
            cbx.DisplayMember = "Name";
            cbx.ValueMember = "ID";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (BookId > 0)
            {
                Book.BookName = mTbxBookName.Text;

                Book.Author = (from x in Db.Authors
                               where x.AuthorID == (int)(mCbxAuthor.SelectedValue)
                               select x).FirstOrDefault();
                Book.Genre = (from x in Db.Genres
                              where x.GenreID == (int)(mCbxAuthor.SelectedValue)
                              select x).FirstOrDefault();
                Db.SubmitChanges();
            }
            else
                Db.AddBook((int)mCbxAuthor.SelectedValue, (int)mCbxGenre.SelectedValue, mTbxBookName.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void mTbxBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void mTbxBookName_Enter(object sender, EventArgs e)
        {
            if (mTbxBookName.Text == "წიგნის სახელი...")
                mTbxBookName.Text = "";
        }

        private void mTbxBookName_Leave(object sender, EventArgs e)
        {
            if (mTbxBookName.Text == "")
                mTbxBookName.Text = "წიგნის სახელი...";
        }
    }
}

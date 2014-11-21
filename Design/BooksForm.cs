using LibraryDatabase;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class BooksForm : MetroForm
    {
        public int RowIndex
        {
            get
            {
                if (mRdbAuthors.Checked)
                    return 4;

                else if (mRdbBooks.Checked)
                    return 3;

                else if (mRdbGenres.Checked)
                    return 5;

                return -1;
            }
        }

        public BooksForm(LibraryDbContext db)
        {
            InitializeComponent();
            Db = db;

            ReFillDatagridview();
        }

        public LibraryDbContext Db { get; set; }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddEditBookForm frmAddBook = new AddEditBookForm(Db);
            if (frmAddBook.ShowDialog() == DialogResult.OK)
                ReFillDatagridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mSearchBox_TextChanged(object sender, EventArgs e)
        {
            FilterGridRows(mGrdBooks, mSearchBox.Text, RowIndex);
        }

        private void mSearchBox_Leave(object sender, EventArgs e)
        {
            if (mSearchBox.Text == "")
                mSearchBox.Text = "ძებნა...";
        }

        private void mSearchBox_Enter(object sender, EventArgs e)
        {
            if (mSearchBox.Text == "ძებნა...")
                mSearchBox.Clear();
        }


        private void FilterGridRows(DataGridView dataGrid, string searchText, int cellIndex)
        {
            if (searchText == "ძებნა...")
                return;

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[RowIndex].Value.ToString().Contains(searchText))
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }

        private void ReFillDatagridview()
        {
            mGrdBooks.Rows.Clear();

            var books = from book in Db.Books
                        select book;

            foreach (var book in books)
                mGrdBooks.Rows.Add(book.BookID, book.AuthorID, book.GenreID, book.BookName, book.Author.AuthorFirstName + " " + book.Author.AuthorLastName, book.Genre.GenreName, book.BookQuantity);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (mGrdBooks.SelectedRows.Count != 0)
            {
                var frm = new AddEditBookForm(Db, (int)(mGrdBooks.SelectedRows[0].Cells[0].Value));
                frm.Show();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (mGrdBooks.SelectedRows.Count != 0)
            {
                if (MetroMessageBox.Show(this, "ნამდვილად გსურთ წაშლა?", "ყურადღება", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    var id  = (int)(mGrdBooks.SelectedRows[0].Cells[0].Value);
                    var res = (from x in Db.Books
                            where x.BookID == id
                            select x).FirstOrDefault();
                    Db.Books.DeleteOnSubmit(res);
                    Db.SubmitChanges();
                    ReFillDatagridview();
                }
            }
        }
    }
}

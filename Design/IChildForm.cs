using LibraryDatabase;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class IChildForm : MetroForm
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

           public IChildForm(LibraryDbContext db)
        {
            InitializeComponent();
            Db = db;

            ReFillDatagridview();
        }

        public LibraryDbContext Db { get; set; }

        private void AnimateExpand(SplitContainer splitContainer)
        {
            for (int i = 200 - 1; i >= 0; i--)
            {
                splitContainer.SplitterWidth += 1;
            }
        }

        private void AnimateCollapse(SplitContainer splitContainer)
        {
            for (int i = 200 - 1; i >= 0; i--)
            {
                splitContainer.SplitterWidth -= 1;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AnimateExpand(splitContainer1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimateCollapse(splitContainer1);
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
    }
}

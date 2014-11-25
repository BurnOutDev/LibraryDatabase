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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class AuthorsForm : MetroForm
    {
        private int rownum;
        public LibraryDbContext Db { get; set; }

        public AuthorsForm(LibraryDbContext db)
        {
            InitializeComponent();
            Db = db;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReFillDatagridview()
        {
            mGrid.Rows.Clear();

            var authors = from author in Db.Authors
                          select author;

            foreach (var author in authors)
                mGrid.Rows.Add(author.AuthorID, author. AuthorFirstName, author.AuthorLastName, author.AuthorBirthDate.Value.ToShortDateString());
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            ReFillDatagridview();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AddEditAuthorsForm frmAddBook = new AddEditAuthorsForm(Db);
            if (frmAddBook.ShowDialog() == DialogResult.OK)
                ReFillDatagridview();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (mGrid.SelectedRows.Count != 0)
            {
                if (MetroMessageBox.Show(this, "ნამდვილად გსურთ წაშლა?", "ყურადღება", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    var id = (int)(mGrid.SelectedRows[0].Cells[0].Value);

                    Db.AddAuthor(2, id, null, null, null);
                }
            }
            ReFillDatagridview();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mGrid.SelectedRows.Count != 0)
                {
                    var frm = new AddEditAuthorsForm(Db, (int)(mGrid.SelectedRows[0].Cells[0].Value));
                    frm.ShowDialog();
                    ReFillDatagridview();
                }
            }
            catch { }
        }

        private void mGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mGrid.ClearSelection();
                mGrid.Rows[e.RowIndex].Selected = true;
                rownum = e.RowIndex;
                contextMenu.Show(MousePosition);
            }
            
        }

        private void წაშლაToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroButton3.PerformClick();
        }


    }
}

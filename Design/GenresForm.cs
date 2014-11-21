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
    public partial class GenresForm : MetroForm
    {
        public LibraryDbContext Db { get; set; }
        public GenresForm(LibraryDbContext db)
        {
            InitializeComponent();
            Db = db;
            ReFillDatagridview();
        }

        private void ReFillDatagridview()
        {
            metroGrid1.Rows.Clear();

            var genres = from genre in Db.Genres
                          select genre;

            foreach (var genre in genres)
                metroGrid1.Rows.Add(genre.GenreID, genre.GenreName);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddEditGenre frmGenre = new AddEditGenre(Db);
            if (frmGenre.ShowDialog() == DialogResult.OK)
            {
                ReFillDatagridview();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "ნამდვილად გსურთ წაშლა?","", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)(metroGrid1.SelectedRows[0].Cells[0].Value);
                Db.DeleteGenre(id);
                ReFillDatagridview();
            }
        }
    }
}

using LibraryDatabase;
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
    public partial class MainForm : MetroForm
    {
        public LibraryDbContext Db { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Db = new LibraryDbContext();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            BooksForm frm = new BooksForm(Db);
            frm.MdiParent = this;
            frm.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AuthorsForm frm = new AuthorsForm(Db);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

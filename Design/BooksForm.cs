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
        public BooksForm(LibraryDbContext db)
        {
            InitializeComponent();
            Db = db;
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

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            var db = new LibraryDbContext();

            if (mRdbAuthors.Checked)
            {
                var result = from x in db.Authors
                             
            }
        }

        private void metroTextBox1_Leave(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "")
                metroTextBox1.Text = "ძებნა...";
        }

        private void metroTextBox1_Enter(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "ძებნა...")
                metroTextBox1.Clear();
        }
    }
}

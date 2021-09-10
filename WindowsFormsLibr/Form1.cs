using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLibr
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new Authors();
            newForm.Show();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new Books();
            newForm.Show();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new Students();
            newForm.Show();
        }

        private void получитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new Give();
            newForm.Show();
        }

        private void выдатьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new Giveout();
            newForm.Show();
        }
    }
}

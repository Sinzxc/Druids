using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Druids
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            f.AddFontFile("Fonts/Vetka.ttf");

            выходToolStripMenuItem.Font = new Font(f.Families[0], 30, style: FontStyle.Bold);
            оПрограммеToolStripMenuItem.Font = new Font(f.Families[0], 30, style: FontStyle.Bold);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
            this.Close();

        }
    }
}

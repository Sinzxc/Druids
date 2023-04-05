using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Druids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            f.AddFontFile("Fonts/Vetka.ttf");

            выходToolStripMenuItem.Font = new Font(f.Families[0], 30,style:FontStyle.Bold);
            оПрограммеToolStripMenuItem.Font = new Font(f.Families[0], 30, style: FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(96, 108, 56);
            menuStrip1.BackColor = Color.FromArgb(40, 54, 24);
            menuStrip1.ForeColor=Color.FromArgb(150, 200, 70);
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

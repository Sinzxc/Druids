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
        int day=1,month=1;
        DateTime date = new DateTime();
        public Form1()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            f.AddFontFile("Fonts/Vetka.ttf");

            выходToolStripMenuItem.Font = new Font(f.Families[0], 30,style:FontStyle.Bold);
            оПрограммеToolStripMenuItem.Font = new Font(f.Families[0], 30, style: FontStyle.Bold);
            SetRoundedShape(panel1, 30);
            SetRoundedShape(comboBox1, 5);
            SetRoundedShape(comboBox2, 5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Location = this.Location;
            form2.Size = this.Size;
            this.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            month=(comboBox2.SelectedIndex + 1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            date = new DateTime(2000, month, day);
            label1.Text = date.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            day=(comboBox1.SelectedIndex + 1);
        }
       
    
    }
}

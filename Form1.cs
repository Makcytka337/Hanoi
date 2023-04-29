using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4._0
{
    public partial class Form1 : Form
    {
/////строка для гита мне все равноgggg
        public Rectangle Sz = Screen.PrimaryScreen.Bounds;
        bool raz = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Sz.Size.Width < 1920)
            {
                Location = new Point(0, 0);
                raz = true;
            }
            else
                Location = new Point(650, 200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)            
        {
            this.Hide();
            Form2 fm = new Form2();
            if (raz == true)
                fm.raz = true;
            fm.Show();            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Visible = true;
            fm.Close();
            Close();
            Application.Exit(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fm = new Form3();
            if (raz == true)
                fm.raz = true;
            fm.Show();
        }
    }
}

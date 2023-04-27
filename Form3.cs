using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica_4._0
{
    public partial class Form3 : Form
    {
        public bool raz;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (raz == true)
            {
                Location = new Point(0, 0);
            }
            else
                Location = new Point(600, 200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }

    }
}

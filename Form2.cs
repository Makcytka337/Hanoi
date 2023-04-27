using System;
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
    public partial class Form2 : Form
    {
        bool chto = false;
        public bool raz;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (raz == true)
                Location = new Point(100, 150);
            else
                Location = new Point(750, 400);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            label1.Text = "Выбери количество дисков";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chto = false;
            Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (chto == false)
            {
                Form1 fm = new Form1();
                fm.Show();
            }
            else
            {
                Form4 fm = new Form4();
                fm.kolv = Convert.ToInt32(numericUpDown1.Value);
                if (raz == true)
                    fm.raz = true;
                fm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chto = true;
            Close();
        }
    }
}

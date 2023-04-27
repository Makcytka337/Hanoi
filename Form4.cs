using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Practica_4._0
{
    public partial class Form4 : Form
    {
        public Rectangle Sz = Screen.PrimaryScreen.Bounds;

        public int kolv = 1;

        int locat = 50;
        int kn = -1;
        int hosi = 0;
        int ms = 0;
        int sec = 0;
        int min = 0;
        int hour = 0;

        bool p = false;
        bool v = false;
        public bool raz;

        Brush B = Brushes.Peru;

        public Button[] buton = new Button[2];
        int[] kto = new int[2];
        int[] kvs = new int[3];
        Point[] Kna = new Point[10];

        public Form4()
        {
            InitializeComponent();
        }

        private void blok(Button[] B)
        {
            for (int i = 0; i < B.Length; i++)
            {
                B[i].Enabled = false;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (raz == true)
            {
                if (Sz.Size.Width == 1366)
                {
                    Location = new Point(0, 0);
                }
                else
                {
                    if (Sz.Size.Width != 1536)
                    {
                        this.WindowState = FormWindowState.Maximized;
                        button1.Location = new Point(button1.Location.X, button1.Location.Y + 29);
                    }
                }
            }
            else
                Location = new Point(300, 170);
            if (Sz.Size.Width == 1536) locat = 70;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            int oo = 1;            
            kvs[0] = kolv;
            kvs[1] = 0;
            kvs[2] = 0;
            Array.Resize(ref buton, kolv);
            Array.Resize(ref kto, kolv);

            for (int i = 0; i < kolv; i++)
            {
                buton[i] = new Button();
                buton[i].Text = Convert.ToString(kolv - i);
                buton[i].Location = new Point(310 + i * 8, 570 - 50 * i);
                buton[i].Size = new Size(200 - i * 16, 40);
                buton[i].FlatStyle = FlatStyle.Flat;
                buton[i].FlatAppearance.BorderColor = Color.Black;
                buton[i].FlatAppearance.BorderSize = 2;
                buton[i].FlatAppearance.MouseDownBackColor = Color.White;
                buton[i].FlatAppearance.MouseOverBackColor = Color.White;
                switch (oo)
                {
                    case 1:
                        {
                            buton[i].BackColor = Color.Purple;
                            oo++;
                            break;
                        }
                    case 2:
                        {
                            buton[i].BackColor = Color.Fuchsia;
                            oo++;
                            break;
                        }
                    case 3:
                        {
                            buton[i].BackColor = Color.Blue;
                            oo++;
                            break;
                        }
                    case 4:
                        {
                            buton[i].BackColor = Color.DeepSkyBlue;
                            oo++;
                            break;
                        }
                    case 5:
                        {
                            buton[i].BackColor = Color.Lime;
                            oo++;
                            break;
                        }
                    case 6:
                        {
                            buton[i].BackColor = Color.Yellow;
                            oo++;
                            break;
                        }
                    case 7:
                        {
                            buton[i].BackColor = Color.Orange;
                            oo++;
                            break;
                        }
                    case 8:
                        {
                            buton[i].BackColor = Color.Red;
                            oo++;
                            break;
                        }
                    
                    case 9:
                        {
                            buton[i].BackColor = Color.Maroon;
                            oo++;
                            break;
                        }
                    case 10:
                        {
                            buton[i].BackColor = Color.Gray;
                            oo++;
                            break;
                        }
                }
                kto[i] = 0;
                Controls.Add(buton[i]);
            }
            for (int i = 0; i < kolv - 1; i++)
            {
                buton[i].Enabled = false;
            }
            for (int i = 0; i < buton.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            MouseEventHandler Eventhandler = new MouseEventHandler(buton0_Click);
                            buton[i].MouseClick += Eventhandler;
                            break;
                        }
                    case 1:
                        {
                            MouseEventHandler Eventhandler = new MouseEventHandler(buton1_Click);
                            buton[i].MouseClick += Eventhandler;
                            break;
                        }
                    case 2:
                        {
                            MouseEventHandler Eventhandler = new MouseEventHandler(buton2_Click);
                            buton[i].MouseClick += Eventhandler;
                            break;
                        }
                    case 3:
                        {
                            MouseEventHandler Eventhandler = new MouseEventHandler(buton3_Click);
                            buton[i].MouseClick += Eventhandler;
                            break;
                        }
                    case 4:
                        {
                            MouseEventHandler Eventhandler = new MouseEventHandler(buton4_Click);
                            buton[i].MouseClick += Eventhandler;
                            break;
                        }
                    case 5:
                        {
                            MouseEventHandler Eventhandler = new MouseEventHandler(buton5_Click);
                            buton[i].MouseClick += Eventhandler;
                            break;
                        }
                    case 6:
                        {
                            MouseEventHandler Eventhandler = new MouseEventHandler(buton6_Click);
                            buton[i].MouseClick += Eventhandler;
                            break;
                        }
                    case 7:
                        {
                            MouseEventHandler Eventhandler = new MouseEventHandler(buton7_Click);
                            buton[i].MouseClick += Eventhandler;
                            break;
                        }
                    case 8:
                        {
                            MouseEventHandler Eventhandler = new MouseEventHandler(buton8_Click);
                            buton[i].MouseClick += Eventhandler;
                            break;
                        }
                    case 9:
                        {
                            MouseEventHandler Eventhandler = new MouseEventHandler(buton9_Click);
                            buton[i].MouseClick += Eventhandler;
                            break;
                        }
                }
            }
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(B, 200, this.ClientSize.Height - 50, this.ClientSize.Width - 225, 37);

            g.FillRectangle(B, 400, 100, 20, 550);
            g.FillEllipse(B, 399, 80, 21, 50);

            g.FillRectangle(B, 700, 100, 20, 550);
            g.FillEllipse(B, 699, 80, 21, 50);

            g.FillRectangle(B, 1000, 100, 20, 550);
            g.FillEllipse(B, 999, 80, 21, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
                Form1 fm = new Form1();
                fm.Show();            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            buton[kn].Location = new Point(Cursor.Position.X - this.DesktopLocation.X - 120 + kn * 10,
                                           Cursor.Position.Y - this.DesktopLocation.Y - locat);
        }

        private void timerR_Tick(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(kvs[0]);
            label3.Text = Convert.ToString(kvs[1]);
            label4.Text = Convert.ToString(kvs[2]);
            if (v == true)
            {
                listBox1.SetSelected(listBox1.Items.Count - 1, true);
                v = false;
            }
        }

        private void prover(Button B, int m)
        {            
            if (B.Location.X < 445)
            {
                if (kvs[0] == 0)
                {
                    B.Location = new Point(410 - B.Width / 2, 570 - 50 * kvs[0]);
                    v = true;
                    if (!(kto[m] == 0))
                    {
                        listBox1.Items.Add((kto[m] + 1) + " --> " + 1);
                        hosi++;
                    }
                    kto[m] = 0;
                    kvs[0]++;
                    if (hosi == 1)
                        label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ход";
                    if (hosi > 1 && hosi < 5)
                        label1.Text = "Вы сделали " + Convert.ToString(hosi) + " хода";
                    if (hosi > 4)
                        label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ходов";
                    return;
                }
                int loc = 570 - 50 * (kvs[0]-1); 
                for (int i = 0; i < kolv; i++)
                {
                    if (buton[i].Location.Y == loc && buton[i].Location.X < 445)
                    {
                        if (Convert.ToInt32(buton[i].Text) > Convert.ToInt32(buton[m].Text))
                        {
                            B.Location = new Point(410 - B.Width / 2, 570 - 50 * kvs[0]);
                            v = true;
                            if (!(kto[m] == 0))
                            {
                                listBox1.Items.Add((kto[m] + 1) + " --> " + 1);
                                hosi++;
                            }
                            kto[m] = 0;
                            kvs[0]++;
                            if (hosi == 1)
                                label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ход";
                            if (hosi > 1 && hosi < 5)
                                label1.Text = "Вы сделали " + Convert.ToString(hosi) + " хода";
                            if (hosi > 4)
                                label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ходов";
                            return;
                        }
                        else
                        {
                            B.Location = Kna[m];
                            kvs[kto[m]]++;
                        }
                    }
                }
                                 
            }
            if (B.Location.X >= 445 && B.Location.X < 750)
            {
                if (kvs[1] == 0)
                {
                    B.Location = new Point(710 - B.Width / 2, 570);
                    v = true;
                    if (!(kto[m] == 1))
                    {
                        listBox1.Items.Add((kto[m] + 1) + " --> " + 2);
                        hosi++;
                    }
                    kto[m] = 1;
                    kvs[1]++;
                    if (hosi == 1)
                        label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ход";
                    if (hosi > 1 && hosi < 5)
                        label1.Text = "Вы сделали " + Convert.ToString(hosi) + " хода";
                    if (hosi > 4)
                        label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ходов";
                    return;
                }
                int loc = 570 - 50 * (kvs[1] - 1);
                for (int i = 0; i < kolv; i++)
                {
                    if (buton[i].Location.Y == loc && buton[i].Location.X >= 445 && buton[i].Location.X < 750)
                    {
                        int ras = Convert.ToInt32(buton[i].Text);
                        int pos = Convert.ToInt32(buton[m].Text);
                        if (ras > pos)
                        {                            
                            B.Location = new Point(710 - B.Width / 2, 570 - 50 * kvs[1]);
                            v = true;
                            if (!(kto[m] == 1))
                            {
                                listBox1.Items.Add((kto[m] + 1) + " --> " + 2);
                                hosi++;
                            }
                            kto[m] = 1;
                            kvs[1]++;
                            if (hosi == 1)
                                label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ход";
                            if (hosi > 1 && hosi < 5)
                                label1.Text = "Вы сделали " + Convert.ToString(hosi) + " хода";
                            if (hosi > 4)
                                label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ходов";
                            return;
                        }
                        else
                        {
                            B.Location = Kna[m];
                            kvs[kto[m]]++;
                            return;
                        }
                    }
                }
            }
            if (B.Location.X >= 750)
            {
                if (kvs[2] == 0)
                {
                    B.Location = new Point(1010 - B.Width / 2, 570);
                    v = true;
                    if (!(kto[m] == 2))
                    {
                        listBox1.Items.Add((kto[m] + 1) + " --> " + 3);
                        hosi++;
                    }
                    kto[m] = 2;
                    kvs[2]++;                    
                    if (hosi == 1)
                        label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ход";
                    if (hosi > 1 && hosi < 5)
                        label1.Text = "Вы сделали " + Convert.ToString(hosi) + " хода";
                    if (hosi > 4)
                        label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ходов";
                    if (kvs[2] == kolv)
                    {
                        blok(buton);
                        timer1.Enabled = false;
                        MessageBox.Show("Вы победили за " + hour + " часов, " + min + " минут, " + sec + " секунд и " + ms + "0 милисекунд.\nВы походили " + hosi + " раз\nВы будете перенаправлены в меню");
                        Close();
                    }
                    return;
                }                
                int loc = 570 - 50 * (kvs[2] - 1);
                for (int i = 0; i < kolv; i++)
                {
                    if (buton[i].Location.Y == loc && buton[i].Location.X >= 750)
                    {
                        int ras = Convert.ToInt32(buton[i].Text);
                        int pos = Convert.ToInt32(buton[m].Text);
                        if (ras > pos)
                        {
                            B.Location = new Point(1010 - B.Width / 2, 570 - 50 * kvs[2]);
                            v = true;
                            if (!(kto[m] == 2))
                            {
                                listBox1.Items.Add((kto[m] + 1) + " --> " + 3);
                                hosi++;
                            }
                            kto[m] = 2;
                            kvs[2]++;
                            if (hosi == 1)
                                label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ход";
                            if (hosi > 1 && hosi < 5)
                                label1.Text = "Вы сделали " + Convert.ToString(hosi) + " хода";
                            if (hosi > 4)
                                label1.Text = "Вы сделали " + Convert.ToString(hosi) + " ходов";
                        }
                        else
                        {
                            B.Location = Kna[m];
                            kvs[kto[m]]++;                            
                        }
                    }
                }                
                if (kvs[2] == kolv)
                {
                    blok(buton);
                    timer1.Enabled = false;
                    MessageBox.Show("Вы победили за " + hour + " часов, " + min + " минут, " + sec + " секунд и " + ms + "0 милисекунд.\nВы походили " + hosi + " раз\nВы будете перенаправлены в меню");
                    Close();
                }                
            }
        }

        private void unlock(int k)
        {
            int[] knop = new int[10];
            int loc = 570;
            switch (k)
            {
                case 0:
                    {
                        for (int i = 0; i < kolv; i++)
                        {
                            if (buton[i].Location.X < 445)
                            {
                                knop[i] = 1;
                                if (buton[i].Location.Y < loc)
                                    loc = buton[i].Location.Y;
                            }
                        }
                        for (int i = 0; i < kolv; i++)
                        {
                            if (knop[i] == 1)
                                if (buton[i].Location.Y == loc)
                                {
                                    buton[i].Enabled = true;
                                }
                        }
                        break;
                    }
                case 1:
                    {
                        for (int i = 0; i < kolv; i++)
                        {
                            if (buton[i].Location.X >= 445 && buton[i].Location.X < 750)
                            {
                                knop[i] = 1;
                                if (buton[i].Location.Y < loc)
                                    loc = buton[i].Location.Y;
                            }
                        }
                        for (int i = 0; i < kolv; i++)
                        {
                            if (knop[i] == 1)
                                if (buton[i].Location.Y == loc)
                                {
                                    buton[i].Enabled = true;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < kolv; i++)
                        {
                            if (buton[i].Location.X >= 750)
                            {
                                knop[i] = 1;
                                if (buton[i].Location.Y < loc)
                                    loc = buton[i].Location.Y;
                            }
                        }
                        for (int i = 0; i < kolv; i++)
                        {
                            if (knop[i] == 1)
                                if (buton[i].Location.Y == loc)
                                {
                                    buton[i].Enabled = true;
                                }
                        }
                        break;
                    }
            }
        }

        private void lok(int k)
        {
            int[] knop = new int[10];
            int loc = 570;
            switch (k)
            {
                case 0:
                    {
                        for (int i = 0; i < kolv; i++)
                        {
                            if (buton[i].Location.X < 445)
                            {
                                knop[i] = 1;
                                if (buton[i].Location.Y < loc)
                                    loc = buton[i].Location.Y;
                            }
                        }
                        for (int i = 0; i < kolv; i++)
                        {
                            if (knop[i] == 1)
                                if (buton[i].Location.Y > loc)
                                {
                                    buton[i].Enabled = false;
                                }
                        }
                        break;
                    }
                case 1:
                    {
                        for (int i = 0; i < kolv; i++)
                        {
                            if (buton[i].Location.X >= 445 && buton[i].Location.X < 750)
                            {
                                knop[i] = 1;
                                if (buton[i].Location.Y < loc)
                                    loc = buton[i].Location.Y;
                            }
                        }
                        for (int i = 0; i < kolv; i++)
                        {
                            if (knop[i] == 1)
                                if (buton[i].Location.Y > loc)
                                {
                                    buton[i].Enabled = false;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < kolv; i++)
                        {
                            if (buton[i].Location.X >= 750)
                            {
                                knop[i] = 1;
                                if (buton[i].Location.Y < loc)
                                    loc = buton[i].Location.Y;
                            }
                        }
                        for (int i = 0; i < kolv; i++)
                        {
                            if (knop[i] == 1)
                                if (buton[i].Location.Y > loc)
                                {
                                    buton[i].Enabled = false;
                                }
                        }
                        break;
                    }
            }
        }

        private void buton0_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                Kna[0] = buton[0].Location;
                kvs[kto[0]]--;
                kn = 0;
                timer2.Enabled = true;
                p = true;
            }
            else
            {
                kn = -1;
                timer2.Enabled = false;
                p = false;
                unlock(kto[0]);
                prover(buton[0], 0);
                lok(kto[0]);
            }
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                Kna[1] = buton[1].Location;
                kvs[kto[1]]--;
                kn = 1;
                timer2.Enabled = true;
                p = true;
            }
            else
            {
                kn = -1;
                timer2.Enabled = false;
                p = false;
                unlock(kto[1]);
                prover(buton[1], 1);
                lok(kto[1]);
            }
        }

        private void buton2_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                Kna[2] = buton[2].Location;
                kvs[kto[2]]--;
                kn = 2;
                timer2.Enabled = true;
                p = true;
            }
            else
            {
                kn = -1;
                timer2.Enabled = false;
                p = false;
                unlock(kto[2]);
                prover(buton[2], 2);
                lok(kto[2]);
            }
        }

        private void buton3_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                Kna[3] = buton[3].Location;
                kvs[kto[3]]--;
                kn = 3;
                timer2.Enabled = true;
                p = true;
            }
            else
            {
                kn = -1;
                timer2.Enabled = false;
                p = false;
                unlock(kto[3]);
                prover(buton[3], 3);
                lok(kto[3]);
            }
        }

        private void buton4_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                Kna[4] = buton[4].Location;
                kvs[kto[4]]--;
                kn = 4;
                timer2.Enabled = true;
                p = true;
            }
            else
            {
                kn = -1;
                timer2.Enabled = false;
                p = false;
                unlock(kto[4]);
                prover(buton[4], 4);
                lok(kto[4]);
            }
        }

        private void buton5_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                Kna[5] = buton[5].Location;
                kvs[kto[5]]--;
                kn = 5;
                timer2.Enabled = true;
                p = true;
            }
            else
            {
                kn = -1;
                timer2.Enabled = false;
                p = false;
                unlock(kto[5]);
                prover(buton[5], 5);
                lok(kto[5]);
            }
        }

        private void buton6_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                Kna[6] = buton[6].Location;
                kvs[kto[6]]--;
                kn = 6;
                timer2.Enabled = true;
                p = true;
            }
            else
            {
                kn = -1;
                timer2.Enabled = false;
                p = false;
                unlock(kto[6]);
                prover(buton[6], 6);
                lok(kto[6]);
            }
        }

        private void buton7_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                Kna[7] = buton[7].Location;
                kvs[kto[7]]--;
                kn = 7;
                timer2.Enabled = true;
                p = true;
            }
            else
            {
                kn = -1;
                timer2.Enabled = false;
                p = false;
                unlock(kto[7]);
                prover(buton[7], 7);
                lok(kto[7]);
            }
        }

        private void buton8_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                Kna[8] = buton[8].Location;
                kvs[kto[8]]--;
                kn = 8;
                timer2.Enabled = true;
                p = true;
            }
            else
            {
                kn = -1;
                timer2.Enabled = false;
                p = false;
                unlock(kto[8]);
                prover(buton[8], 8);
                lok(kto[8]);
            }
        }

        private void buton9_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                Kna[9] = buton[9].Location;
                kvs[kto[9]]--;
                kn = 9;
                timer2.Enabled = true;
                p = true;
            }
            else
            {
                kn = -1;
                timer2.Enabled = false;
                p = false;
                unlock(kto[9]);
                prover(buton[9], 9);
                lok(kto[9]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ms += 1;
            if (ms == 10)
            {
                ms = 0;
                sec += 1;
            }
            if (sec == 60)
            {
                sec = 0;
                min += 1;
            }
            if (min == 60)
            { 
                min = 0;
                hour += 1;
            }
            label5.Text = "Время: " + hour + ":" + min + ":" + sec + ":" + ms;
        }

    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_MODUL_BRSL
{
    public partial class FormTabung : Form
    {
        List<Panel> lispanel = new List<Panel>();
        int index;
        public FormTabung()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Kamu Akan Keluar dari form materi, dan kembali ke Beranda", "Komfirmasi?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question));
            if (z == DialogResult.OK)
            {
                timer2.Start();
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void sblm_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                lispanel[--index].BringToFront();
            }
        }

        private void lanjut_Click(object sender, EventArgs e)
        {
            if (index < lispanel.Count - 1)
            {
                lispanel[++index].BringToFront();
            }
        }

        private void FormTabung_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            lispanel.Add(a);
            lispanel.Add(b);
            lispanel.Add(c);
            lispanel.Add(d);
            lispanel.Add(ee);
            lispanel.Add(f);
            lispanel.Add(g);
            lispanel.Add(h);
           // lispanel.Add(i);
           // lispanel.Add(j);
            lispanel[index].BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.1)
            {
                this.Opacity += 0.25;
            }
            else
            {
                this.Opacity = 100;
                timer1.Stop();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (cari.Text == "1")
            {
                a.BringToFront();
            }
            if (cari.Text == "2")
            {
                b.BringToFront();
            }
            if (cari.Text == "3")
            {
                c.BringToFront();
            }
            if (cari.Text == "4")
            {
                d.BringToFront();
            }
            if (cari.Text == "5")
            {
                ee.BringToFront();
            }
            if (cari.Text == "6")
            {
                f.BringToFront();
            }
            if (cari.Text == "7")
            {
                g.BringToFront();
            }
            if (cari.Text == "8")
            {
                h.BringToFront();
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {

        }

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.01)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                this.Opacity = 0;
                this.Close();
                timer2.Stop();
            }
        }
    }
}

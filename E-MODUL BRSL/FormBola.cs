using System;
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
    public partial class FormBola : Form
    {
        List<Panel> listpanel = new List<Panel>();
        int index;
        public FormBola()
        {
            InitializeComponent();
        }

        private void Off_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Kamu Akan Keluar dari form materi, dan kembali ke Beranda", "Komfirmasi?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question));
            if (z == DialogResult.OK)
            {
                timer2.Start();
            }
        }

        private void Tray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sblm_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listpanel[--index].BringToFront();
            }
        }

        private void lanjut_Click(object sender, EventArgs e)
        {
            if (index < listpanel.Count - 1)
            {
                listpanel[++index].BringToFront();
            }
        }

        private void FormBola_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            listpanel.Add(a);
            listpanel.Add(b);
            listpanel.Add(c);
            listpanel.Add(d);
            listpanel.Add(ee);
            listpanel.Add(f);
            listpanel.Add(g);
            listpanel.Add(h);
            //listpanel.Add(i);
            //listpanel.Add(j);
            listpanel[index].BringToFront();

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

        private void b_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label156_Click(object sender, EventArgs e)
        {

        }

        private void g_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label150_Click(object sender, EventArgs e)
        {

        }

        private void label151_Click(object sender, EventArgs e)
        {

        }

        private void label153_Click(object sender, EventArgs e)
        {

        }

        private void label154_Click(object sender, EventArgs e)
        {

        }

        private void label155_Click(object sender, EventArgs e)
        {

        }

        private void a_Paint(object sender, PaintEventArgs e)
        {

        }

        private void f_Paint(object sender, PaintEventArgs e)
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

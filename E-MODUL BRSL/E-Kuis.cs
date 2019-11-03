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
    public partial class E_Kuis : Form
    {
        public E_Kuis()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (bantuan.Visible == true)
            {
                transBantu.HideSync(bantuan);
                bantuan.Visible = false;
            }
            else
            {
                bantuan.BringToFront();
                transBantu.ShowSync(bantuan);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            transBantu.HideSync(bantuan);
            bantuan.Visible = false;
              
        }

        private void timerMuncul_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.1)
            {
                this.Opacity += 0.25;
            }
            else
            {
                this.Opacity = 100;
                timerMuncul.Stop();
            }
        }

        private void E_Kuis_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timerMuncul.Start();
            a.Checked = false;
            radioButton1.Checked = true;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Semua Pekerjaanmu akan Terhapus!", "Komfirmasi Penting!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (z == DialogResult.OK)
            {
                timer1.Start();
            }
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            soalNo1.Visible = false;
            cj1.Visible = false;
            transSoal.ShowSync(soalNo2);
            cj2.BringToFront();
            transPilihan.ShowSync(cj2);
            cek1.Visible = false;
            cek2.BringToFront();
            cek2.Visible = true;
            btnLanjut.Visible = false;
            btnLanjut1.BringToFront();
            btnLanjut1.Visible = true;
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ez.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
            i.Checked = false;
            j.Checked = false;
            k.Checked = false;
            l.Checked = false;
            m.Checked = false;
            n.Checked = false;
            o.Checked = false;
            p.Checked = false;
            q.Checked = false;
            r.Checked = false;
            s.Checked = false;
            t.Checked = false;
            u.Checked = false;
            v.Checked = false;
            w.Checked = false;
            x.Checked = false;
            a1.Checked = false;
            b1.Checked = false;
            d1.Checked = false;
            e1.Checked = false;
            f1.Checked = false;
            g1.Checked = false;
            h1.Checked = false;
            j1.Checked = false;
            c1.Checked = false;
            j2.Checked = false;
            j3.Checked = false;
            j4.Checked = false;
            k1.Checked = false;
            l1.Checked = false;
            m1.Checked = false;
            n1.Checked = false;
          
        }

        private void hapusJwb_Click(object sender, EventArgs e)
        {
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ez.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
            i.Checked = false;
            j.Checked = false;
            k.Checked = false;
            l.Checked = false;
            m.Checked = false;
            n.Checked = false;
            o.Checked = false;
            p.Checked = false;
            q.Checked = false;
            r.Checked = false;
            s.Checked = false;
            t.Checked = false;
            u.Checked = false;
            v.Checked = false;
            w.Checked = false;
            x.Checked = false;
            a1.Checked = false;
            b1.Checked = false;
            d1.Checked = false;
            e1.Checked = false;
            f1.Checked = false;
            g1.Checked = false;
            h1.Checked = false;
            j1.Checked = false;
            c1.Checked = false;
            j2.Checked = false;
            j3.Checked = false;
            j4.Checked = false;
            k1.Checked = false;
            l1.Checked = false;
            m1.Checked = false;
            n1.Checked = false;
        }

        private void cek1_Click_1(object sender, EventArgs e)
        {
            if (a.Checked)
            {
                var z = (MessageBox.Show("Selamat Jawaban Kamu Benar, Pilih Soal Selanjutnya", "Kamu Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information));

                if (z == DialogResult.OK)
                {
                    cek1.Enabled = false;
                    textBox1.Text="10";
                }
            }
            else if (b.Checked)
            {
                var Jawaban1 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban1 == DialogResult.OK)
                {
                    cek1.Enabled = false;
                }
            }
            else if (c.Checked)
            {
                var Jawaban2 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban2 == DialogResult.OK)
                {
                    cek1.Enabled = false;
                }
            }
            else if (d.Checked)
            {
                var Jawaban3 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban3 == DialogResult.OK)
                {
                    cek1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Kamu Belum memilih jawaban!", "Wajib Menjawab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cek2_Click_1(object sender, EventArgs e)
        {
                if (h.Checked)
                {
                
                var z = (MessageBox.Show("Selamat Jawaban Kamu Benar, Pilih Soal Selanjutnya", "Kamu Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information));
                
                if (z == DialogResult.OK)
                {
                    cek2.Enabled = false;
                    textBox2.Text = "10";
                }
                }
                else if (ez.Checked)
                {
                    var Jawaban1 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                    if (Jawaban1 == DialogResult.OK)
                    {
                        cek2.Enabled = false;
                    }
                }
                else if (f.Checked)
                {
                    var Jawaban2 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                    if (Jawaban2 == DialogResult.OK)
                    {
                        cek2.Enabled = false;
                    }
                }
                else if (g.Checked)
                {
                    var Jawaban3 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                    if (Jawaban3 == DialogResult.OK)
                    {
                        cek2.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Kamu Belum memilih jawaban!", "Wajib Menjawab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            soalNo2.Visible = false;
            cj2.Visible = false;
            transSoal.ShowSync(soalNo3);
            cj3.BringToFront();
            transPilihan.ShowSync(cj3);
            cek2.Visible = false;
            cek3.BringToFront();
            cek3.Visible = true;
            btnLanjut1.Visible = false;
            btnLanjut2.BringToFront();
            btnLanjut2.Visible = true;
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ez.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
            i.Checked = false;
            j.Checked = false;
            k.Checked = false;
            l.Checked = false;
            m.Checked = false;
            n.Checked = false;
            o.Checked = false;
            p.Checked = false;
            q.Checked = false;
            r.Checked = false;
            s.Checked = false;
            t.Checked = false;
            u.Checked = false;
            v.Checked = false;
            w.Checked = false;
            x.Checked = false;
            a1.Checked = false;
            b1.Checked = false;
            d1.Checked = false;
            e1.Checked = false;
            f1.Checked = false;
            g1.Checked = false;
            h1.Checked = false;
            j1.Checked = false;
            c1.Checked = false;
            j2.Checked = false;
            j3.Checked = false;
            j4.Checked = false;
            k1.Checked = false;
            l1.Checked = false;
            m1.Checked = false;
            n1.Checked = false;
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            soalNo3.Visible = false;
            cj3.Visible = false;
            transSoal.ShowSync(soalNo4);
            cj4.BringToFront();
            transPilihan.ShowSync(cj4);
            cek3.Visible = false;
            cek4.BringToFront();
            cek4.Visible = true;
            btnLanjut2.Visible = false;
            btnLanjut3.BringToFront();
            btnLanjut3.Visible = true;
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ez.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
            i.Checked = false;
            j.Checked = false;
            k.Checked = false;
            l.Checked = false;
            m.Checked = false;
            n.Checked = false;
            o.Checked = false;
            p.Checked = false;
            q.Checked = false;
            r.Checked = false;
            s.Checked = false;
            t.Checked = false;
            u.Checked = false;
            v.Checked = false;
            w.Checked = false;
            x.Checked = false;
            a1.Checked = false;
            b1.Checked = false;
            d1.Checked = false;
            e1.Checked = false;
            f1.Checked = false;
            g1.Checked = false;
            h1.Checked = false;
            j1.Checked = false;
            c1.Checked = false;
            j2.Checked = false;
            j3.Checked = false;
            j4.Checked = false;
            k1.Checked = false;
            l1.Checked = false;
            m1.Checked = false;
            n1.Checked = false;
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            soalNo4.Visible = false;
            cj4.Visible = false;
            transSoal.ShowSync(soalNo5);
            cj5.BringToFront();
            transPilihan.ShowSync(cj5);
            cek4.Visible = false;
            cek5.BringToFront();
            cek5.Visible = true;
            btnLanjut3.Visible = false;
            btnLanjut4.BringToFront();
            btnLanjut4.Visible = true;
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ez.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
            i.Checked = false;
            j.Checked = false;
            k.Checked = false;
            l.Checked = false;
            m.Checked = false;
            n.Checked = false;
            o.Checked = false;
            p.Checked = false;
            q.Checked = false;
            r.Checked = false;
            s.Checked = false;
            t.Checked = false;
            u.Checked = false;
            v.Checked = false;
            w.Checked = false;
            x.Checked = false;
            a1.Checked = false;
            b1.Checked = false;
            d1.Checked = false;
            e1.Checked = false;
            f1.Checked = false;
            g1.Checked = false;
            h1.Checked = false;
            j1.Checked = false;
            c1.Checked = false;
            j2.Checked = false;
            j3.Checked = false;
            j4.Checked = false;
            k1.Checked = false;
            l1.Checked = false;
            m1.Checked = false;
            n1.Checked = false;
            
        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            soalNo5.Visible = false;
            cj5.Visible = false;
            transSoal.ShowSync(soalNo6);
            cj6.BringToFront();
            transPilihan.ShowSync(cj6);
            cek5.Visible = false;
            cek6.BringToFront();
            cek6.Visible = true;
            btnLanjut4.Visible = false;
            btnLanjut5.BringToFront();
            btnLanjut5.Visible = true;
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ez.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
            i.Checked = false;
            j.Checked = false;
            k.Checked = false;
            l.Checked = false;
            m.Checked = false;
            n.Checked = false;
            o.Checked = false;
            p.Checked = false;
            q.Checked = false;
            r.Checked = false;
            s.Checked = false;
            t.Checked = false;
            u.Checked = false;
            v.Checked = false;
            w.Checked = false;
            x.Checked = false;
            a1.Checked = false;
            b1.Checked = false;
            d1.Checked = false;
            e1.Checked = false;
            f1.Checked = false;
            g1.Checked = false;
            h1.Checked = false;
            j1.Checked = false;
            c1.Checked = false;
            j2.Checked = false;
            j3.Checked = false;
            j4.Checked = false;
            k1.Checked = false;
            l1.Checked = false;
            m1.Checked = false;
            n1.Checked = false;
           
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            soalNo6.Visible = false;
            cj6.Visible = false;
            transSoal.ShowSync(soalNo7);
            cj7.BringToFront();
            transPilihan.ShowSync(cj7);
            cek6.Visible = false;
            cek7.BringToFront();
            cek7.Visible = true;
            btnLanjut5.Visible = false;
            btnLanjut6.BringToFront();
            btnLanjut6.Visible = true;
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ez.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
            i.Checked = false;
            j.Checked = false;
            k.Checked = false;
            l.Checked = false;
            m.Checked = false;
            n.Checked = false;
            o.Checked = false;
            p.Checked = false;
            q.Checked = false;
            r.Checked = false;
            s.Checked = false;
            t.Checked = false;
            u.Checked = false;
            v.Checked = false;
            w.Checked = false;
            x.Checked = false;
            a1.Checked = false;
            b1.Checked = false;
            d1.Checked = false;
            e1.Checked = false;
            f1.Checked = false;
            g1.Checked = false;
            h1.Checked = false;
            j1.Checked = false;
            c1.Checked = false;
            j2.Checked = false;
            j3.Checked = false;
            j4.Checked = false;
            k1.Checked = false;
            l1.Checked = false;
            m1.Checked = false;
            n1.Checked = false;
            
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            soalNo7.Visible = false;
            cj7.Visible = false;
            transSoal.ShowSync(soalNo8);
            cj8.BringToFront();
            transPilihan.ShowSync(cj8);
            cek7.Visible = false;
            cek8.BringToFront();
            cek8.Visible = true;
            btnLanjut6.Visible = false;
            btnLanjut7.BringToFront();
            btnLanjut7.Visible = true;
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ez.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
            i.Checked = false;
            j.Checked = false;
            k.Checked = false;
            l.Checked = false;
            m.Checked = false;
            n.Checked = false;
            o.Checked = false;
            p.Checked = false;
            q.Checked = false;
            r.Checked = false;
            s.Checked = false;
            t.Checked = false;
            u.Checked = false;
            v.Checked = false;
            w.Checked = false;
            x.Checked = false;
            a1.Checked = false;
            b1.Checked = false;
            d1.Checked = false;
            e1.Checked = false;
            f1.Checked = false;
            g1.Checked = false;
            h1.Checked = false;
            j1.Checked = false;
            c1.Checked = false;
            j2.Checked = false;
            j3.Checked = false;
            j4.Checked = false;
            k1.Checked = false;
            l1.Checked = false;
            m1.Checked = false;
            n1.Checked = false;
            
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            soalNo8.Visible = false;
            cj8.Visible = false;
            transSoal.ShowSync(soalNo9);
            cj9.BringToFront();
            transPilihan.ShowSync(cj9);
            cek8.Visible = false;
            cek9.BringToFront();
            cek9.Visible = true;
            btnLanjut7.Visible = false;
            btnLanjut8.BringToFront();
            btnLanjut8.Visible = true;
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ez.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
            i.Checked = false;
            j.Checked = false;
            k.Checked = false;
            l.Checked = false;
            m.Checked = false;
            n.Checked = false;
            o.Checked = false;
            p.Checked = false;
            q.Checked = false;
            r.Checked = false;
            s.Checked = false;
            t.Checked = false;
            u.Checked = false;
            v.Checked = false;
            w.Checked = false;
            x.Checked = false;
            a1.Checked = false;
            b1.Checked = false;
            d1.Checked = false;
            e1.Checked = false;
            f1.Checked = false;
            g1.Checked = false;
            h1.Checked = false;
            j1.Checked = false;
            c1.Checked = false;
            j2.Checked = false;
            j3.Checked = false;
            j4.Checked = false;
            k1.Checked = false;
            l1.Checked = false;
            m1.Checked = false;
            n1.Checked = false;
           
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            soalNo9.Visible = false;
            cj9.Visible = false;
            transSoal.ShowSync(soalNo10);
            cj10.BringToFront();
            transPilihan.ShowSync(cj10);
            cek9.Visible = false;
            cek10.BringToFront();
            cek10.Visible = true;
            btnLanjut8.Visible = false;
            btnLanjut9.BringToFront();
            btnLanjut9.Visible = true;
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ez.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
            i.Checked = false;
            j.Checked = false;
            k.Checked = false;
            l.Checked = false;
            m.Checked = false;
            n.Checked = false;
            o.Checked = false;
            p.Checked = false;
            q.Checked = false;
            r.Checked = false;
            s.Checked = false;
            t.Checked = false;
            u.Checked = false;
            v.Checked = false;
            w.Checked = false;
            x.Checked = false;
            a1.Checked = false;
            b1.Checked = false;
            d1.Checked = false;
            e1.Checked = false;
            f1.Checked = false;
            g1.Checked = false;
            h1.Checked = false;
            j1.Checked = false;
            c1.Checked = false;
            j2.Checked = false;
            j3.Checked = false;
            j4.Checked = false;
            k1.Checked = false;
            l1.Checked = false;
            m1.Checked = false;
            n1.Checked = false; 
        }
        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            soalNo1.Visible = false;
            cek10.Visible = false;
            cek1.Visible = true;
            cek1.BringToFront();
            cek1.Visible = true;
            cj10.Visible = false;
            btnLihatNilai.BringToFront();
            btnLihatNilai.Visible = true;
            btnKeluar.ButtonText = "";
            btnKeluar.Enabled = false;
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            ez.Checked = false;
            f.Checked = false;
            g.Checked = false;
            h.Checked = false;
            i.Checked = false;
            j.Checked = false;
            k.Checked = false;
            l.Checked = false;
            m.Checked = false;
            n.Checked = false;
            o.Checked = false;
            p.Checked = false;
            q.Checked = false;
            r.Checked = false;
            s.Checked = false;
            t.Checked = false;
            u.Checked = false;
            v.Checked = false;
            w.Checked = false;
            x.Checked = false;
            a1.Checked = false;
            b1.Checked = false;
            d1.Checked = false;
            e1.Checked = false;
            f1.Checked = false;
            g1.Checked = false;
            h1.Checked = false;
            j1.Checked = false;
            c1.Checked = false;
            j2.Checked = false;
            j3.Checked = false;
            j4.Checked = false;
            k1.Checked = false;
            l1.Checked = false;
            m1.Checked = false;
            n1.Checked = false;
            cj1.Visible = false;
            cj2.Visible = false;
            cj3.Visible = false;
            cj4.Visible = false;
            cj5.Visible = false;
            cj6.Visible = false;
            cj7.Visible = false;
            cj8.Visible = false;
            cj9.Visible = false;
            cj10.Visible = false;
            soalNo1.Visible = false;
            soalNo2.Visible = false;
            soalNo3.Visible = false;
            soalNo4.Visible = false;
            soalNo5.Visible = false;
            soalNo6.Visible = false;
            soalNo7.Visible = false;
            soalNo8.Visible = false;
            soalNo9.Visible = false;
            soalNo10.Visible = false;
            label15.Visible = true;
        }

        private void cek3_Click(object sender, EventArgs e)
        {
            if (j.Checked)
            {
                var z = (MessageBox.Show("Selamat Jawaban Kamu Benar, Pilih Soal Selanjutnya", "Kamu Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information));

                if (z == DialogResult.OK)
                {
                    cek3.Enabled = false;
                    textBox3.Text = "10";
                }
            }
            else if (i.Checked)
            {
                var Jawaban1 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban1 == DialogResult.OK)
                {
                    cek3.Enabled = false;
                }
            }
            else if (k.Checked)
            {
                var Jawaban2 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban2 == DialogResult.OK)
                {
                    cek3.Enabled = false;
                }
            }
            else if (l.Checked)
            {
                var Jawaban3 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban3 == DialogResult.OK)
                {
                    cek3.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Kamu Belum memilih jawaban!", "Wajib Menjawab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cek4_Click(object sender, EventArgs e)
        {
            if (o.Checked)
            {
                var z = (MessageBox.Show("Selamat Jawaban Kamu Benar, Pilih Soal Selanjutnya", "Kamu Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information));

                if (z == DialogResult.OK)
                {
                    cek4.Enabled = false;
                    textBox4.Text = "10";
                }
            }
            else if (m.Checked)
            {
                var Jawaban1 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban1 == DialogResult.OK)
                {
                    cek4.Enabled = false;
                }
            }
            else if (n.Checked)
            {
                var Jawaban2 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban2 == DialogResult.OK)
                {
                    cek4.Enabled = false;
                }
            }
            else if (p.Checked)
            {
                var Jawaban3 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban3 == DialogResult.OK)
                {
                    cek4.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Kamu Belum memilih jawaban!", "Wajib Menjawab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cek5_Click(object sender, EventArgs e)
        {
            if (q.Checked)
            {
                var z = (MessageBox.Show("Selamat Jawaban Kamu Benar, Pilih Soal Selanjutnya", "Kamu Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information));

                if (z == DialogResult.OK)
                {
                    cek5.Enabled = false;
                    textBox5.Text = "10";
                }
            }
            else if (r.Checked)
            {
                var Jawaban1 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban1 == DialogResult.OK)
                {
                    cek5.Enabled = false;
                }
            }
            else if (s.Checked)
            {
                var Jawaban2 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban2 == DialogResult.OK)
                {
                    cek5.Enabled = false;
                }
            }
            else if (t.Checked)
            {
                var Jawaban3 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban3 == DialogResult.OK)
                {
                    cek5.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Kamu Belum memilih jawaban!", "Wajib Menjawab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cek6_Click(object sender, EventArgs e)
        {
            if (u.Checked)
            {
                var z = (MessageBox.Show("Selamat Jawaban Kamu Benar, Pilih Soal Selanjutnya", "Kamu Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information));

                if (z == DialogResult.OK)
                {
                    cek6.Enabled = false;
                    textBox6.Text = "10";
                }
            }
            else if (v.Checked)
            {
                var Jawaban1 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban1 == DialogResult.OK)
                {
                    cek6.Enabled = false;
                }
            }
            else if (w.Checked)
            {
                var Jawaban2 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban2 == DialogResult.OK)
                {
                    cek6.Enabled = false;
                }
            }
            else if (x.Checked)
            {
                var Jawaban3 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban3 == DialogResult.OK)
                {
                    cek6.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Kamu Belum memilih jawaban!", "Wajib Menjawab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cek7_Click(object sender, EventArgs e)
        {
            if (b1.Checked)
            {
                var z = (MessageBox.Show("Selamat Jawaban Kamu Benar, Pilih Soal Selanjutnya", "Kamu Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information));

                if (z == DialogResult.OK)
                {
                    cek7.Enabled = false;
                    textBox7.Text = "10";
                }
            }
            else if (a1.Checked)
            {
                var Jawaban1 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban1 == DialogResult.OK)
                {
                    cek7.Enabled = false;
                }
            }
            else if (c1.Checked)
            {
                var Jawaban2 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban2 == DialogResult.OK)
                {
                    cek7.Enabled = false;
                }
            }
            else if (d1.Checked)
            {
                var Jawaban3 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban3 == DialogResult.OK)
                {
                    cek7.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Kamu Belum memilih jawaban!", "Wajib Menjawab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cek8_Click(object sender, EventArgs e)
        {
            if (h1.Checked)
            {
                var z = (MessageBox.Show("Selamat Jawaban Kamu Benar, Pilih Soal Selanjutnya", "Kamu Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information));

                if (z == DialogResult.OK)
                {
                    cek8.Enabled = false;
                    textBox8.Text = "10";
                }
            }
            else if (e1.Checked)
            {
                var Jawaban1 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban1 == DialogResult.OK)
                {
                    cek8.Enabled = false;
                }
            }
            else if (f1.Checked)
            {
                var Jawaban2 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban2 == DialogResult.OK)
                {
                    cek8.Enabled = false;
                }
            }
            else if (g1.Checked)
            {
                var Jawaban3 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban3 == DialogResult.OK)
                {
                    cek8.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Kamu Belum memilih jawaban!", "Wajib Menjawab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cek9_Click(object sender, EventArgs e)
        {
            if (j3.Checked)
            {
                var z = (MessageBox.Show("Selamat Jawaban Kamu Benar, Pilih Soal Selanjutnya", "Kamu Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information));

                if (z == DialogResult.OK)
                {
                    cek9.Enabled = false;
                    textBox9.Text = "10";
                }
            }
            else if (j1.Checked)
            {
                var Jawaban1 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban1 == DialogResult.OK)
                {
                    cek9.Enabled = false;
                }
            }
            else if (j2.Checked)
            {
                var Jawaban2 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban2 == DialogResult.OK)
                {
                    cek9.Enabled = false;
                }
            }
            else if (j4.Checked)
            {
                var Jawaban3 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban3 == DialogResult.OK)
                {
                    cek9.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Kamu Belum memilih jawaban!", "Wajib Menjawab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cek10_Click(object sender, EventArgs e)
        {
            if (m1.Checked)
            {
                var z = (MessageBox.Show("Selamat Jawaban Kamu Benar, Pilih Soal Selanjutnya", "Kamu Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information));

                if (z == DialogResult.OK)
                {
                    cek10.Enabled = false;
                    textBox10.Text = "10";
                }
            }
            else if (n1.Checked)
            {
                var Jawaban1 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban1 == DialogResult.OK)
                {
                    cek10.Enabled = false;
                }
            }
            else if (k1.Checked)
            {
                var Jawaban2 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban2 == DialogResult.OK)
                {
                    cek10.Enabled = false;
                }
            }
            else if (l1.Checked)
            {
                var Jawaban3 = (MessageBox.Show("Tetep Semangat, Belajar lebih Giat Lagi, Pilih Soal Selanjutnya", "Tetap Semangat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));

                if (Jawaban3 == DialogResult.OK)
                {
                    cek10.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Kamu Belum memilih jawaban!", "Wajib Menjawab!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
        private void panelAtas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLihatNilai_Click(object sender, EventArgs e)
        {
            int aa, bb, cc, dd, ee, ff, gg, hh, ii, jj, hasil;
            aa = Convert.ToInt32(textBox1.Text);
            bb = Convert.ToInt32(textBox2.Text);
            cc = Convert.ToInt32(textBox3.Text);
            dd = Convert.ToInt32(textBox4.Text);
            ee = Convert.ToInt32(textBox5.Text);
            ff = Convert.ToInt32(textBox6.Text);
            gg = Convert.ToInt32(textBox7.Text);
            hh = Convert.ToInt32(textBox8.Text);
            ii = Convert.ToInt32(textBox9.Text);
            jj = Convert.ToInt32(textBox10.Text);
            hasil = aa + bb + cc + dd + ee + ff + gg + hh + ii + jj;
            skorakhir.Text = hasil.ToString();
            transPilihan.ShowSync(panelSkor);
            btnKeluar.ButtonText = "Keluar";
            btnKeluar.Enabled = true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (history.Visible == false)
            {
                history.BringToFront();
                transBantu.ShowSync(history);
            }
            else
            {
                transBantu.HideSync(history);
                history.Visible = false;
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.01)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                this.Opacity = 0;
                this.Close();
                timer1.Stop();
            }
        }
    }
}

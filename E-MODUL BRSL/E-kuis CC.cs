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
    public partial class kuisCC : Form
    {
        public kuisCC()
        {
            InitializeComponent();
        }

        private void tmrMuncul_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.1)
            {
                this.Opacity += 0.25;
            }
            else
            {
                this.Opacity = 100;
                tmrMuncul.Stop();
            }
        }

        private void E_kuis_CC_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            tmrMuncul.Start();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Semua Pekerjaanmu akan Terhapus!", "Komfirmasi Penting!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (z == DialogResult.OK)
            {
                timer1.Start();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (bantuan.Visible == true)
            {
                transbantuan.HideSync(bantuan);
                bantuan.Visible = false;
            }
            else
            {
                bantuan.BringToFront();
                transbantuan.ShowSync(bantuan);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            transbantuan.HideSync(bantuan);
            bantuan.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnlanjut_Click(object sender, EventArgs e)
        {
            if (panelsoal2.Visible == false)
            {
                panelsoal1.Visible = false;
                panelsoal2.BringToFront();
                transSoal.ShowSync(panelsoal2);
                btnlanjut.Visible = false;
                btnlanjut2.BringToFront();
                btnlanjut2.Visible = true;
                cek1.Visible = false;
                cek2.BringToFront();
                cek2.Visible = true;
                jwb1.Visible = false;
                jwb2.BringToFront();
                transPilihan.ShowSync(jwb2);
                jwb2.Visible = true;
            }
        }

        private void btnlanjut2_Click(object sender, EventArgs e)
        {
            if (panelsoal3.Visible == false)
            {
                panelsoal2.Visible = false;
                panelsoal3.BringToFront();
                transSoal.ShowSync(panelsoal3);
                btnlanjut2.Visible = false;
                btnlanjut3.BringToFront();
                btnlanjut3.Visible = true;
                cek2.Visible = false;
                cek3.BringToFront();
                cek3.Visible = true;
                jwb2.Visible = false;
                jwb3.BringToFront();
                transPilihan.ShowSync(jwb3);
                jwb3.Visible = true;

            }
        }

        private void btnlanjut3_Click(object sender, EventArgs e)
        {
            if (panelsoal4.Visible == false)
            {
                panelsoal3.Visible = false;
                panelsoal4.BringToFront();
                transSoal.ShowSync(panelsoal4);
                btnlanjut3.Visible = false;
                lihatNilai.BringToFront();
                lihatNilai.Visible = true;
                cek3.Visible = false;
                cek4.BringToFront();
                cek4.Visible = true;
                btnlanjut3.Visible = true;
                jwb3.Visible = false;
                jwb4.BringToFront();
                transPilihan.ShowSync(jwb4);
                jwb4.Visible = true;

            }
        }

        private void cek1_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (textBox1.Text == "E" )
                {
                    textBox21.Text = "10";
                }
                 if (textBox2.Text == "B")
                {
                    textBox22.Text = "10";  
                }
                if (textBox3.Text == "D")
                {
                    textBox23.Text = "10";
                }
                if (textBox4.Text == "F")
                {
                    textBox24.Text = "10";
                }
               if (textBox5.Text == "A")
                {
                    textBox25.Text = "10";
                }
            }
            cek1.Enabled = false;
        }

        private void cek2_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (textBox10.Text == "B")
                {
                    textBox26.Text = "10";
                }
                if (textBox9.Text == "E")
                {
                    textBox27.Text = "10";
                }
                if (textBox8.Text == "C")
                {
                    textBox28.Text = "10";
                }
                if (textBox7.Text == "A")
                {
                    textBox29.Text = "10";
                }
                if (textBox6.Text == "F")
                {
                    textBox30.Text = "10";
                }
            }
            cek2.Enabled = false;
        }

        private void lihatNilai_Click(object sender, EventArgs e)
        {

        }

        private void cek3_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (textBox16.Text == "D")
                {
                    textBox31.Text = "10";
                }
                if (textBox17.Text == "E")
                {
                    textBox32.Text = "10";
                }
                if (textBox18.Text == "F")
                {
                    textBox33.Text = "10";
                }
                if (textBox19.Text == "A")
                {
                    textBox34.Text = "10";
                }
                if (textBox20.Text == "C")
                {
                    textBox35.Text = "10";
                }
            }
            cek3.Enabled = false;
        }

        private void cek4_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (textBox15.Text == "A")
                {
                    textBox36.Text = "10";
                }
                if (textBox14.Text == "F")
                {
                    textBox37.Text = "10";
                }
                if (textBox13.Text == "C")
                {
                    textBox38.Text = "10";
                }
                if (textBox12.Text == "D")
                {
                    textBox39.Text = "10";
                }
                if (textBox11.Text == "B")
                {
                    textBox40.Text = "10";
                }
            }
            cek4.Visible = false;
            cek5.BringToFront();
            cek5.Visible = true;
            btnlanjut3.ButtonText = "........";
        }

        private void cek5_Click(object sender, EventArgs e)
        {
            lihatNilai.Enabled = true;
            cek5.Enabled = false;
            jwb4.Visible = false;

        }

        private void lihatNilai_Click_1(object sender, EventArgs e)
        {
            int aa, bb, cc, dd, ee, ff, gg, hh, ii, jj, hasil1;
            int kk,ll, mm, nn, oo, pp, qq, rr, ss, tt,hasil2;
            int total;
            aa = Convert.ToInt32(textBox21.Text);
            bb = Convert.ToInt32(textBox22.Text);
            cc = Convert.ToInt32(textBox23.Text);
            dd = Convert.ToInt32(textBox24.Text);
            ee = Convert.ToInt32(textBox25.Text);
            ff = Convert.ToInt32(textBox26.Text);
            gg = Convert.ToInt32(textBox27.Text);
            hh = Convert.ToInt32(textBox28.Text);
            ii = Convert.ToInt32(textBox29.Text);
            jj = Convert.ToInt32(textBox30.Text);
            kk = Convert.ToInt32(textBox31.Text);
            ll = Convert.ToInt32(textBox32.Text);
            mm = Convert.ToInt32(textBox33.Text);
            nn = Convert.ToInt32(textBox34.Text);
            oo = Convert.ToInt32(textBox35.Text);
            pp = Convert.ToInt32(textBox36.Text);
            qq = Convert.ToInt32(textBox37.Text);
            rr = Convert.ToInt32(textBox38.Text);
            ss = Convert.ToInt32(textBox39.Text);
            tt = Convert.ToInt32(textBox40.Text);
            hasil1 = aa + bb + cc + dd + ee + ff + gg + hh + ii + jj;
            hasil2 = kk + ll + mm + nn + oo + pp + qq + rr + ss+ tt;
            total = ((hasil1 + hasil2)/2);
            labelskor.Text = total.ToString();
            panelNilaiAkhir.BringToFront();
            transQ.ShowSync(panelNilaiAkhir);
            panelNilaiAkhir.Visible = true;

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (panelSkor.Visible == false)
            {
                panelSkor.BringToFront();
                transbantuan.ShowSync(panelSkor);
            }
            else
            {
                transbantuan.HideSync(panelSkor);
                panelSkor.Visible = false;
            }
        }

        private void jwb4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelsoal3_Paint(object sender, PaintEventArgs e)
        {

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

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
    public partial class kuisbs : Form
    {
        public kuisbs()
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

        private void E_kuis_BS_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            tmrMuncul.Start();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Semua Pekerjaanmu akan Terhapus!", "Komfirmasi Penting!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (z == DialogResult.OK)
            {
                timer1.Start();
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (bantuan.Visible == true)
            {
                cccA.HideSync(bantuan);
                bantuan.Visible = false;
                
            }
            else
            {
                bantuan.BringToFront();
                cccA.ShowSync(bantuan);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cccA.HideSync(bantuan);
            bantuan.Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (riwayatSkor.Visible == false)
            {
                riwayatSkor.BringToFront();
                transbantuan.ShowSync(riwayatSkor);
            }
            else
            {
                transbantuan.HideSync(riwayatSkor);
                riwayatSkor.Visible = false;
            }
        }

        private void cek1_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (benar.Checked==true)
                {
                    textBox1.Text = "10";                    
                    btnlanjut.ButtonText = "Lanjut Soal 2";
                    
                }  
            }
            cek1.Enabled = false;
            label29.Text = "Benar";
        }

        private void cek2_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (salah.Checked == true)
                {
                    textBox2.Text = "10";
                }
                btnlanjut.Visible = false;
                btnlanjut3.BringToFront();
                btnlanjut3.Visible = true;

            }
            label29.Text = "Salah";
            cek2.Enabled = false;
        }

        private void cek3_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (salah.Checked == true)
                {
                    textBox3.Text = "10";
                }                
                btnlanjut3.Visible = false;
                btnlanjut4.BringToFront();
                btnlanjut4.Visible = true;
            }
            label29.Text = "Salah";
            cek3.Enabled = false;
        }

        private void cek4_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (benar.Checked == true)
                {
                    textBox4.Text = "10";
                }
     
                btnlanjut4.Visible = false;
                btnlanjut5.BringToFront();
                btnlanjut5.Visible = true;
            }
            cek4.Enabled = false;
            label29.Text = "Benar";
        }

        private void cek5_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (salah.Checked == true)
                {
                    textBox5.Text = "10";
                }
                btnlanjut5.Visible = false;
                btnlanjut6.BringToFront();
                btnlanjut6.Visible = true;
            }
            label29.Text = "Salah";
            cek5.Enabled = false;
        }

        private void cek6_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (benar.Checked == true)
                {
                    textBox6.Text = "10";                    
                }
                btnlanjut6.Visible = false;
                btnlanjut7.BringToFront();
                btnlanjut7.Visible = true;
            }
            label29.Text = "Benar";
            cek6.Enabled = false;
        }

        private void cek7_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (benar.Checked == true)
                {
                    textBox7.Text = "10";
                }
                btnlanjut7.Visible = false;
                btnlanjut8.BringToFront();
                btnlanjut8.Visible = true;
            }
            label29.Text = "Benar";
            cek7.Enabled = false;
        }

        private void cek8_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (salah.Checked == true)
                {
                    textBox8.Text = "10";
                }              
                btnlanjut8.Visible = false;
                btnlanjut9.BringToFront();
                btnlanjut9.Visible = true;
            }
            label29.Text = "Salah";
            cek8.Enabled = false;
        }

        private void cek9_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (benar.Checked == true)
                {
                    textBox9.Text = "10";
                }
                btnlanjut9.Visible = false;
                btnlanjut10.BringToFront();
                btnlanjut10.Visible = true;
            }
            label29.Text = "Benar";
            cek9.Enabled = false;
        }

        private void cek10_Click(object sender, EventArgs e)
        {
            var z = (MessageBox.Show("Jawaban Sedang Dicek, Klik OK", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information));
            if (z == DialogResult.OK)
            {
                if (salah.Checked == true)
                {
                    textBox10.Text = "10";
                }
                btnselesai.BringToFront();
                btnselesai.Visible = true;
            }
            label29.Text = "Salah";
            cek10.Enabled = false;
        }

        private void btnselesai_Click(object sender, EventArgs e)
        {
            lihatNilai.BringToFront();
            lihatNilai.Visible = true;
            soal1.Visible = false;
            soal2.Visible = false;
            soal3.Visible = false;
            soal4.Visible = false;
            soal5.Visible = false;
            soal6.Visible = false;
            soal7.Visible = false;
            soal8.Visible = false;
            soal9.Visible = false;
            soal10.Visible = false;
            radioButton1.Checked = true;
            label27.BringToFront();
            label27.Visible = true;
        }

        private void lihatNilai_Click(object sender, EventArgs e)
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
            skorQ.Text = hasil.ToString();
            label27.Hide();
            panelNilaiAkhir.BringToFront();
            transQ.ShowSync(panelNilaiAkhir);
            panelNilaiAkhir.Visible = true;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlanjut_Click(object sender, EventArgs e)
        {
            soal1.Visible = false;
            soal2.BringToFront();
            transbantuan.ShowSync(soal2);
            soal2.Visible = true;
            cek1.Visible = false;
            cek2.BringToFront();
            cek2.Visible = true;
            radioButton1.Checked = true;
        }

        private void btnlanjut3_Click(object sender, EventArgs e)
        {
            soal2.Visible = false;
            soal3.BringToFront();
            transbantuan.ShowSync(soal3);
            soal3.Visible = true;
            cek2.Visible = false;
            cek3.BringToFront();
            cek3.Visible = true;
            radioButton1.Checked = true;
        }

        private void btnlanjut4_Click(object sender, EventArgs e)
        {
            soal3.Visible = false;
            soal4.BringToFront();
            transbantuan.ShowSync(soal4);
            transbantuan.ShowSync(l4);
            soal4.Visible = true;
            cek3.Visible = false;
            cek4.BringToFront();
            cek4.Visible = true;
            radioButton1.Checked = true;
        }

        private void btnlanjut5_Click(object sender, EventArgs e)
        {
            l4.Visible = false;
            soal4.Visible = false;        
            soal5.BringToFront();
            transbantuan.ShowSync(soal5);
            soal5.Visible = true;
            cek4.Visible = false;
            cek5.BringToFront();
            cek5.Visible = true;
            radioButton1.Checked = true;
        }

        private void btnlanjut6_Click(object sender, EventArgs e)
        {
            soal5.Visible = false;
            soal6.BringToFront();
            transbantuan.ShowSync(soal6);
            transbantuan.ShowSync(l6);
            soal6.Visible = true;
            cek5.Visible = false;
            cek6.BringToFront();
            cek6.Visible = true;
            radioButton1.Checked = true;
        }

        private void btnlanjut7_Click(object sender, EventArgs e)
        {
            l6.Visible = false;
            soal6.Visible = false;
            soal7.BringToFront();
            transbantuan.ShowSync(soal7);
            soal7.Visible = true;
            cek6.Visible = false;
            cek7.BringToFront();
            cek7.Visible = true;
            radioButton1.Checked = true;
        }

        private void btnlanjut8_Click(object sender, EventArgs e)
        {
            soal7.Visible = false;
            soal8.BringToFront();
            transbantuan.ShowSync(soal8);
            transbantuan.ShowSync(i8);
            soal8.Visible = true;
            cek7.Visible = false;
            cek8.BringToFront();
            cek8.Visible = true;
            radioButton1.Checked = true;
        }

        private void btnlanjut9_Click(object sender, EventArgs e)
        {
            i8.Visible = false;
            soal8.Visible = false;
            soal9.BringToFront();
            transbantuan.ShowSync(soal9);
            transbantuan.ShowSync(i9);
            soal9.Visible = true;
            cek8.Visible = false;
            cek9.BringToFront();
            cek9.Visible = true;
            radioButton1.Checked = true;
        }

        private void btnlanjut10_Click(object sender, EventArgs e)
        {
            soal9.Visible = false;
            i9.Visible = false;
            soal10.BringToFront();
            transbantuan.ShowSync(soal10);
            soal10.Visible = true;
            cek9.Visible = false;
            cek10.BringToFront();
            cek10.Visible = true;
            btnlanjut10.Visible = false;
            yyy.BringToFront();
            radioButton1.Checked = true;
        }

        private void yyy_Click(object sender, EventArgs e)
        {

        }

        private void xxx_Click(object sender, EventArgs e)
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

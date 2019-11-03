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
    public partial class Beranda : Form
    {
        Boolean flag;
        public Beranda()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            PesanKeluar pesanQ = new PesanKeluar();
            pesanQ.ShowDialog();
        }
        private void BtnMateri_Click(object sender, EventArgs e)
        {
            ListSamping.Height = BtnMateri.Height;
            ListSamping.Top = BtnMateri.Top;
            LabelKet.Text = "Materi";
            Materi.BringToFront();
            btngr1.Visible = false;
            btngr2.Visible = false;
            btngr3.Visible = false;
            btngr4.Visible = false;
            btngr5.Visible = false;
            btngr6.Visible = false;
            btngr7.Visible = false;
            btngr8.Visible = false;
            btngr9.Visible = false;
            btngr10.Visible = false;
        }
        private void BtnBeranda_Click(object sender, EventArgs e)
        {
            
            gr1.BringToFront();
            ListSamping.Height = BtnBeranda.Height;
            ListSamping.Top = BtnBeranda.Top;
            LabelKet.Text = "Beranda";
            btngr1.BringToFront();
            btngr1.Visible = true;
            btngr2.Visible = true;
            btngr3.Visible = true;
            btngr4.Visible = true;
            btngr5.Visible = true;
            btngr6.Visible = true;
            btngr7.Visible = true;
            btngr8.Visible = true;
            btngr9.Visible = true;
            btngr10.Visible = true;
            btnBantu.BringToFront();
        }
        private void BtnKompetensi_Click(object sender, EventArgs e)
        {
            ListSamping.Height = BtnKompetensi.Height;
            ListSamping.Top = BtnKompetensi.Top;
            LabelKet.Text = "Kompetensi";
            Kompetensi.BringToFront();
            btngr1.Visible = false;
            btngr2.Visible = false;
            btngr3.Visible = false;
            btngr4.Visible = false;
            btngr5.Visible = false;
            btngr6.Visible = false;
            btngr7.Visible = false;
            btngr8.Visible = false;
            btngr9.Visible = false;
            btngr10.Visible = false;
        }
        private void BtnRangkuman_Click(object sender, EventArgs e)
        {
            ListSamping.Height = BtnRangkuman.Height;
            ListSamping.Top = BtnRangkuman.Top;
            LabelKet.Text = "Rangkuman";
            Rangkuman.BringToFront();
            btngr1.Visible = false;
            btngr2.Visible = false;
            btngr3.Visible = false;
            btngr4.Visible = false;
            btngr5.Visible = false;
            btngr6.Visible = false;
            btngr7.Visible = false;
            btngr8.Visible = false;
            btngr9.Visible = false;
            btngr10.Visible = false;
        }
        private void BtnEvaluasi_Click(object sender, EventArgs e)
        {
            ListSamping.Height = BtnEvaluasi.Height;
            ListSamping.Top = BtnEvaluasi.Top;
            LabelKet.Text = "Evaluasi";
            popUp Up = new popUp();
            Up.Show();
            loginEvaluasi.BringToFront();
            loginEvaluasi.Show();
           // brandaTrs.ShowSync(loginEvaluasi);
            btngr1.Visible = false;
            btngr2.Visible = false;
            btngr3.Visible = false;
            btngr4.Visible = false;
            btngr5.Visible = false;
            btngr6.Visible = false;
            btngr7.Visible = false;
            btngr8.Visible = false;
            btngr9.Visible = false;
            btngr10.Visible = false;
        }
        private void BtnBantuan_Click(object sender, EventArgs e)
        {
            ListSamping.Height = BtnBantuan.Height;
            ListSamping.Top = BtnBantuan.Top;
            LabelKet.Text = "Bantuan";
            Bantuan.BringToFront();
            btngr1.Visible = false;
            btngr2.Visible = false;
            btngr3.Visible = false;
            btngr4.Visible = false;
            btngr5.Visible = false;
            btngr6.Visible = false;
            btngr7.Visible = false;
            btngr8.Visible = false;
            btngr9.Visible = false;
            btngr10.Visible = false;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com");
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.whatsapp.com"); 
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://accounts.google.com/signin/v2/sl/pwd?passive=1209600&continue=https%3A%2F%2Faccounts.google.com%2FManageAccount&followup=https%3A%2F%2Faccounts.google.com%2FManageAccount&flowName=GlifWebSignIn&flowEntry=ServiceLogin"); 
        }
        private void btntabung_Click(object sender, EventArgs e)
        {
            Form tbg = new FormTabung();
            tbg.Show();
        }

        private void btnkerucut_Click(object sender, EventArgs e)
        {
            Form krc = new FormKerucut();
            krc.Show();
        }

        private void btnbola_Click(object sender, EventArgs e)
        {
            Form bol = new FormBola();
            bol.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            flag = false;
            timermuncul.Start();
        }

        private void timermuncul_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (this.Opacity <= 0.1)
                {
                    this.Opacity += 0.025;
                }
                else
                {
                    timermuncul.Stop();
                    this.Opacity = 100;
                }
            }
            else
            {
                if (this.Opacity > 0.0)
                {
                    this.Opacity -= 0.5;
                }
                else
                {
                    timermuncul.Stop();
                    this.WindowState = FormWindowState.Minimized;
                    this.Opacity = 100;
                }
            }
        }
        private void Beranda_Load(object sender, EventArgs e)
        {
            flag = true;
            this.Opacity=0.0;
            timermuncul.Start();
            timer.Tick += new EventHandler(this.timer_Tick);
            timer.Start();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            if (PanelWaktu.Visible == false)
            {
                PanelWaktu.BringToFront();
                TransisiKeluar.ShowSync(PanelWaktu);
                PanelWaktu.Visible = true;
                LabelKet.Text = "Waktu";
            }
            else
            {
                TransisiKeluar.HideSync(PanelWaktu);
            }
        }
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            if (PanelMusik.Visible == false)
            {
                PanelMusik.BringToFront();
                TransA.ShowSync(PanelMusik);
                PanelMusik.Visible = true;
                LabelKet.Text = "Media";
            }
            else
            {
                TransA.HideSync(PanelMusik);
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Video vdo = new Video();
            vdo.Show();
        }

        private void bunifuImageButton5_Click_1(object sender, EventArgs e)
        {
            Musik msk = new Musik();
            msk.Show();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (PanelAlat.Visible == false)
            {
                PanelAlat.BringToFront();
                TransB.ShowSync(PanelAlat);
                PanelAlat.Visible = true;
                LabelKet.Text = "Alat";
            }
            else
            {
                TransB.HideSync(PanelAlat);
            }
        }

        private void Cttan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wordpad.exe"); 
        }

        private void kalktor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe"); 
        }

        private void Kalender_Click(object sender, EventArgs e)
        {
            if (panelKalender.Visible == false)
            {
                panelKalender.BringToFront();
                TransisiKeluar.ShowSync(panelKalender);
                panelKalender.Visible = true;
            }
            else
            {
                TransisiKeluar.HideSync(panelKalender);
            } 
        }

        private void HilangOtomatis_Tick(object sender, EventArgs e)
        {
            TransB.HideSync(PanelAlat);
            TransA.HideSync(PanelMusik);
            TransisiKeluar.HideSync(PanelWaktu);
            TransisiHilang.HideSync(PanelTentang);
            TransisiKeluar.HideSync(panelKalender);
            TransA.HideSync(panelTransaparan);
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            if (PanelTentang.Visible == false)
            {
                PanelTentang.BringToFront();
                TransisiHilang.ShowSync(PanelTentang);
                PanelTentang.Visible = true;
                LabelKet.Text = "Tentang";
            }
            else
            {
                TransisiHilang.HideSync(PanelTentang);
            }
        }

        private void LinkUIN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.radenintan.ac.id");
        }

        private void LinkAljabar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ejournal.radenintan.ac.id/index.php/al-jabar");
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 202)
            {
                panel15.Visible = true;
                slideTrans3.HideSync(panel7);
                panel7.Visible = false;
                slideTrans.HideSync(panelMenu);
                panelMenu.Visible = false;
                slideTrans3.ShowSync(panel7);
                slideTrans4.ShowSync(panel16);
                panelMenu.Width = 56;
                slideTrans.ShowSync(panelMenu);
            }
            else
            {

                panelMenu.Visible = false;
                slideTrans3.HideSync(panel7);
                panel7.Visible = false;
                panelMenu.Width = 202;
                slideTrans4.HideSync(panel16);
                slideTrans2.ShowSync(panelMenu);
                slideTrans2.ShowSync(panel7);
                panel15.Visible = false;
            }
        }

        private void slide_Tick(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            btngr3.BringToFront();
            gr2.Visible = false;
            gr2.BringToFront();
            brandaTrs.ShowSync(gr2);
        }

        private void btngr4_Click(object sender, EventArgs e)
        {
            btngr2.BringToFront();
            gr3.Visible = false;
            gr3.BringToFront();
            brandaTrs.ShowSync(gr3);
        }

        private void btngr3_Click(object sender, EventArgs e)
        {
            btngr4.BringToFront();
            gr4.Visible = false;
            gr4.BringToFront();
            brandaTrs.ShowSync(gr4);
        }

        private void bunifuImageButton8_Click_1(object sender, EventArgs e)
        {
            btngr5.BringToFront();
            gr5.Visible = false;
            gr5.BringToFront();
            brandaTrs.ShowSync(gr5);
        }

        private void batal_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            loginEvaluasi.Hide();
            //brandaTrs.HideSync(loginEvaluasi);
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "matematika")
            {
                loginEvaluasi.Hide();
                txtPassword.Text = "";
                Evaluasi.BringToFront();
                Evaluasi.Show();
            }
            else
            {
                MessageBox.Show("Password Salah Atau belum diisi, Coba Lagi !", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openPG_Click(object sender, EventArgs e)
        {

            E_Kuis kuis = new E_Kuis();
            kuis.Show();
        }
        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            if(panelTransaparan.Visible==false)
            {
                panelTransaparan.BringToFront();
                TransA.ShowSync(panelTransaparan);
            }
            else
            {
                TransA.HideSync(panelTransaparan);
                panelTransaparan.Visible = false;
            }
        }


        private void openCK_Click(object sender, EventArgs e)
        {
            kuisCC kuiscc = new kuisCC();
            kuiscc.Show();
        }

        private void benarsalah_Click_1(object sender, EventArgs e)
        {
            kuisbs bs = new kuisbs();
            bs.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = ((double)(trackBar1.Value) / 10.0);
            lblOpc.Text = trackBar1.Value.ToString();
        }

        private void btngr5_Click(object sender, EventArgs e)
        {
            btngr6.BringToFront();
            gr6.Visible = false;
            gr6.BringToFront();
            brandaTrs.ShowSync(gr6);
        }

        private void btngr6_Click(object sender, EventArgs e)
        {
            btngr7.BringToFront();
            gr7.Visible = false;
            gr7.BringToFront();
            brandaTrs.ShowSync(gr7);
        }

        private void btngr7_Click(object sender, EventArgs e)
        {
            btngr8.BringToFront();
            gr8.Visible = false;
            gr8.BringToFront();
            brandaTrs.ShowSync(gr8);
        }

        private void btngr8_Click(object sender, EventArgs e)
        {
            btngr9.BringToFront();
            gr9.Visible = false;
            gr9.BringToFront();
            brandaTrs.ShowSync(gr9);
        }

        private void btngr9_Click(object sender, EventArgs e)
        {
            btngr10.BringToFront();
            gr10.Visible = false;
            gr10.BringToFront();
            brandaTrs.ShowSync(gr10);
        }

        private void btngr10_Click(object sender, EventArgs e)
        {
            btngr1.BringToFront();
            gr1.Visible = false;
            gr1.BringToFront();
            brandaTrs.ShowSync(gr1);
        }

        private void btnBantu_Click(object sender, EventArgs e)
        {
            Video vdo = new Video();
            vdo.Show(); 
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (validator.Visible == false)
            {
               validator.BringToFront();
               TransA.ShowSync(validator);
            }
            else
            {
                TransA.HideSync(validator);
                validator.Visible = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string waktu = "";
           
            if (hh < 10)
            {
                waktu += "0" + hh;
            }
            else
            {
                waktu += hh;
            }
            waktu += ":";
            if (mm < 10)
            {
                waktu += "0" + mm;
            }
            else
            {
                waktu += mm;
            }
            waktu += ":";
            if (ss < 10)
            {
                waktu += "0" + ss;
            }
            else
            {
                waktu += ss;
            }

            label39.Text = waktu;
            label40.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            label208.Text = DateTime.Now.ToString("tt");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.ruangguru.com/latihan-soal-uts-matematika-smp-kelas-9-dan-pembahasannya"); 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://matematikastudycenter.com/smp/57-9-smp-soal-pembahasan-bangun-ruang-sisi-lengkung"); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://idschool.net/contoh-soal-bangun-ruang-sisi-lengkung-matematika-smp-3/"); 
        }

        private void Tw_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/");  
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://materi4belajar.blogspot.com/2018/11/rumus-bangun-ruang-sisi-lengkung.html#");
        }
    }
}

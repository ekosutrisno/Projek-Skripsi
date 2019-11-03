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
    public partial class Musik : Form
    {
        String[] files, paths;
        Boolean flag;
        public Musik()
        {
            InitializeComponent();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlgOpen = new OpenFileDialog())
            {
                dlgOpen.Filter = "All Files |*.*";
                if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        files = dlgOpen.SafeFileNames;
                        paths = dlgOpen.FileNames;
                        axWindowsMediaPlayer1.URL = dlgOpen.FileName;
                        for (int i = 0; i < files.Length; i++)
                        {
                            txtalamat.Text = axWindowsMediaPlayer1.URL;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File Tidak Bisa Dibuka!\n\n" + ex.Message);
                    }
                }
            }
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button1_Click(object sender, EventArgs e)
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
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (this.Opacity <= 0.1)
                {
                    this.Opacity += 0.025;
                }
                else
                {
                    this.Opacity = 88;
                    timer2.Stop();
                }
            }
        }

        private void Musik_Load(object sender, EventArgs e)
        {
            flag = true;
            this.Opacity = 0.0;
            timer2.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

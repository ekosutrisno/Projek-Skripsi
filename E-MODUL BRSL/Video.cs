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
    public partial class Video : Form
    {
        String[] files, paths;
        public Video()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncari_Click(object sender, EventArgs e)
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
                            textBox1.Text = axWindowsMediaPlayer1.URL;
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

        private void btnstop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=R51IjsmHER8&list=WL&t=284s&index=66");
        }
    }
}

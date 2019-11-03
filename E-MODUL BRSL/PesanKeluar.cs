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
    public partial class PesanKeluar : Form
    {
        Boolean flag;
        public PesanKeluar()
        {
            InitializeComponent();
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            Timerhilang.Start();
        }

        private void batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.25;
            }
            else
            {
                Timerhilang.Stop();
                Application.Exit();
            }
        }

        private void PesanKeluar_Load(object sender, EventArgs e)
        {
            flag = true;
            this.Opacity = 0.0;
            timerMuncul.Start();
        }

        private void timerMuncul_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (this.Opacity <= 0.1)
                {
                    this.Opacity += 0.025;
                }
                else
                {
                    timerMuncul.Stop();
                    this.Opacity = 100;
                }
            }
        }
    }
}

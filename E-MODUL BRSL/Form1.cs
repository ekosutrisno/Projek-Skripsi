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
    public partial class FlasScreen : Form
    {
        Boolean flag;
        public FlasScreen()
        {
            InitializeComponent();
        }

        private void FlasScreen_Load(object sender, EventArgs e)
        {
            flag = true;
            this.Opacity = 0.0;
            tmrMuncul.Start();
            waktu_buka.Start();
        }

        private void waktu_buka_Tick(object sender, EventArgs e)
        {
            waktu_buka.Start();
            this.Close();
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCircleProgressbar1_Click(object sender, EventArgs e)
        {

        }

        private void batal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tnrMuncul_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (this.Opacity <= 0.1)
                {
                    this.Opacity += 0.025;
                }
                else
                {
                    tmrMuncul.Stop();
                    this.Opacity = 100;
                }
            }
        }
    }
}

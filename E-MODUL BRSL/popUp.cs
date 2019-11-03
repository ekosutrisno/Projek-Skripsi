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
    public partial class popUp : Form
    {
        Boolean flag;
        public popUp()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer3.Start();
        }

        private void popUp_Load(object sender, EventArgs e)
        {
            flag = true;
            this.Opacity = 0.0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (this.Opacity <= 0.1)
                {
                    this.Opacity += 0.025;
                }
                else
                {
                    timer1.Stop();
                    this.Opacity = 100;
                    timer2.Start();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }
    }
}

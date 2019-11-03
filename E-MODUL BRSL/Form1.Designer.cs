namespace E_MODUL_BRSL
{
    partial class FlasScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlasScreen));
            this.elips = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.waktu_buka = new System.Windows.Forms.Timer(this.components);
            this.batal = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.tmrMuncul = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.ElipseRadius = 10;
            this.elips.TargetControl = this;
            // 
            // drag
            // 
            this.drag.Fixed = true;
            this.drag.Horizontal = true;
            this.drag.TargetControl = this;
            this.drag.Vertical = true;
            // 
            // waktu_buka
            // 
            this.waktu_buka.Enabled = true;
            this.waktu_buka.Interval = 8000;
            this.waktu_buka.Tick += new System.EventHandler(this.waktu_buka_Tick);
            // 
            // batal
            // 
            this.batal.AutoSize = true;
            this.batal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.batal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.batal.ForeColor = System.Drawing.Color.Aqua;
            this.batal.Location = new System.Drawing.Point(448, 439);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(75, 22);
            this.batal.TabIndex = 1;
            this.batal.Text = "BATAL";
            this.batal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 50;
            this.bunifuCircleProgressbar1.animationSpeed = 500;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 5;
            this.bunifuCircleProgressbar1.LineThickness = 2;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(527, 388);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Cyan;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(54, 54);
            this.bunifuCircleProgressbar1.TabIndex = 14;
            this.bunifuCircleProgressbar1.Value = 20;
            this.bunifuCircleProgressbar1.Click += new System.EventHandler(this.bunifuCircleProgressbar1_Click);
            // 
            // tmrMuncul
            // 
            this.tmrMuncul.Tick += new System.EventHandler(this.tnrMuncul_Tick);
            // 
            // FlasScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(751, 701);
            this.Controls.Add(this.batal);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlasScreen";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-MODUL BRSL";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.FlasScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elips;
        private Bunifu.Framework.UI.BunifuDragControl drag;
        private System.Windows.Forms.Timer waktu_buka;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Label batal;
        private System.Windows.Forms.Timer tmrMuncul;

    }
}


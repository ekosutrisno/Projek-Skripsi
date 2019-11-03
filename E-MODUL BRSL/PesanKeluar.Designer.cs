namespace E_MODUL_BRSL
{
    partial class PesanKeluar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesanKeluar));
            this.batal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.keluar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Timerhilang = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerMuncul = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // batal
            // 
            this.batal.ActiveBorderThickness = 2;
            this.batal.ActiveCornerRadius = 20;
            this.batal.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.batal.ActiveForecolor = System.Drawing.Color.White;
            this.batal.ActiveLineColor = System.Drawing.Color.White;
            this.batal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.batal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("batal.BackgroundImage")));
            this.batal.ButtonText = "Batal";
            this.batal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.batal.IdleBorderThickness = 1;
            this.batal.IdleCornerRadius = 20;
            this.batal.IdleFillColor = System.Drawing.Color.White;
            this.batal.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(107)))));
            this.batal.IdleLineColor = System.Drawing.Color.White;
            this.batal.Location = new System.Drawing.Point(233, 129);
            this.batal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(118, 43);
            this.batal.TabIndex = 0;
            this.batal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // keluar
            // 
            this.keluar.ActiveBorderThickness = 2;
            this.keluar.ActiveCornerRadius = 20;
            this.keluar.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.keluar.ActiveForecolor = System.Drawing.Color.White;
            this.keluar.ActiveLineColor = System.Drawing.Color.White;
            this.keluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.keluar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("keluar.BackgroundImage")));
            this.keluar.ButtonText = "&Keluar";
            this.keluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keluar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.keluar.IdleBorderThickness = 1;
            this.keluar.IdleCornerRadius = 20;
            this.keluar.IdleFillColor = System.Drawing.Color.White;
            this.keluar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(107)))));
            this.keluar.IdleLineColor = System.Drawing.Color.White;
            this.keluar.Location = new System.Drawing.Point(15, 129);
            this.keluar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(189, 43);
            this.keluar.TabIndex = 1;
            this.keluar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // Timerhilang
            // 
            this.Timerhilang.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 3;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timerMuncul
            // 
            this.timerMuncul.Tick += new System.EventHandler(this.timerMuncul_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 186);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(3, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 55);
            this.panel1.TabIndex = 3;
            // 
            // PesanKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(381, 186);
            this.Controls.Add(this.batal);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "PesanKeluar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PesanKeluar";
            this.Load += new System.EventHandler(this.PesanKeluar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 batal;
        private Bunifu.Framework.UI.BunifuThinButton2 keluar;
        private System.Windows.Forms.Timer Timerhilang;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timerMuncul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
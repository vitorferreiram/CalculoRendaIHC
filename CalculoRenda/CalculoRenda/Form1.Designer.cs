namespace CalculoRenda
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMen = new System.Windows.Forms.Panel();
            this.btnVisuEcon = new System.Windows.Forms.Button();
            this.btnCalcSal = new System.Windows.Forms.Button();
            this.btnCalcHoraExtra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.calcSal1 = new CalculoRenda.CalcSal();
            this.visuEcon1 = new CalculoRenda.VisuEcon();
            this.calcHoraExtra2 = new CalculoRenda.CalcHoraExtra();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnCalculadora);
            this.panel1.Controls.Add(this.panelMen);
            this.panel1.Controls.Add(this.btnVisuEcon);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCalcSal);
            this.panel1.Controls.Add(this.btnCalcHoraExtra);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panelMen
            // 
            resources.ApplyResources(this.panelMen, "panelMen");
            this.panelMen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMen.Name = "panelMen";
            // 
            // btnVisuEcon
            // 
            resources.ApplyResources(this.btnVisuEcon, "btnVisuEcon");
            this.btnVisuEcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVisuEcon.FlatAppearance.BorderSize = 0;
            this.btnVisuEcon.ForeColor = System.Drawing.Color.White;
            this.btnVisuEcon.Name = "btnVisuEcon";
            this.btnVisuEcon.UseVisualStyleBackColor = true;
            this.btnVisuEcon.Click += new System.EventHandler(this.btnVisuEcon_Click);
            // 
            // btnCalcSal
            // 
            resources.ApplyResources(this.btnCalcSal, "btnCalcSal");
            this.btnCalcSal.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalcSal.FlatAppearance.BorderSize = 0;
            this.btnCalcSal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCalcSal.ForeColor = System.Drawing.Color.White;
            this.btnCalcSal.Name = "btnCalcSal";
            this.btnCalcSal.UseVisualStyleBackColor = true;
            this.btnCalcSal.Click += new System.EventHandler(this.btnCalcSal_Click);
            // 
            // btnCalcHoraExtra
            // 
            resources.ApplyResources(this.btnCalcHoraExtra, "btnCalcHoraExtra");
            this.btnCalcHoraExtra.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalcHoraExtra.FlatAppearance.BorderSize = 0;
            this.btnCalcHoraExtra.ForeColor = System.Drawing.Color.White;
            this.btnCalcHoraExtra.Name = "btnCalcHoraExtra";
            this.btnCalcHoraExtra.UseVisualStyleBackColor = true;
            this.btnCalcHoraExtra.Click += new System.EventHandler(this.btnCalcHoraExtra_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnAjuda);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Name = "label7";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // calcSal1
            // 
            resources.ApplyResources(this.calcSal1, "calcSal1");
            this.calcSal1.Name = "calcSal1";
            this.calcSal1.Load += new System.EventHandler(this.calcSal1_Load);
            // 
            // visuEcon1
            // 
            resources.ApplyResources(this.visuEcon1, "visuEcon1");
            this.visuEcon1.BackColor = System.Drawing.SystemColors.Window;
            this.visuEcon1.Name = "visuEcon1";
            // 
            // calcHoraExtra2
            // 
            resources.ApplyResources(this.calcHoraExtra2, "calcHoraExtra2");
            this.calcHoraExtra2.Name = "calcHoraExtra2";
            // 
            // btnAjuda
            // 
            resources.ApplyResources(this.btnAjuda, "btnAjuda");
            this.btnAjuda.BackgroundImage = global::CalculoRenda.Properties.Resources.info__2_;
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackgroundImage = global::CalculoRenda.Properties.Resources.error__1_;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalculadora
            // 
            resources.ApplyResources(this.btnCalculadora, "btnCalculadora");
            this.btnCalculadora.FlatAppearance.BorderSize = 0;
            this.btnCalculadora.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalculadora.Image = global::CalculoRenda.Properties.Resources.calculator__1_;
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::CalculoRenda.Properties.Resources.piggy_bank__7_;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calcSal1);
            this.Controls.Add(this.visuEcon1);
            this.Controls.Add(this.calcHoraExtra2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcSal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalcHoraExtra;
        public System.Windows.Forms.Panel panelMen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVisuEcon;
        // CalcSal calcHoraExtra1;
        private System.Windows.Forms.Button btnCalculadora;
        private VisuEcon visuEcon1;
        private CalcSal calcSal1;
        private CalcHoraExtra calcHoraExtra2;
        private System.Windows.Forms.Button btnAjuda;
    }
}


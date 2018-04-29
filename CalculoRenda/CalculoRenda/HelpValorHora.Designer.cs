namespace CalculoRenda
{
    partial class HelpValorHora
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAlerta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResultConv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsHorConv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValDia = new System.Windows.Forms.TextBox();
            this.btnCalcConv = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.txtValDia);
            this.panel1.Controls.Add(this.lbAlerta);
            this.panel1.Controls.Add(this.btnCalcConv);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnInsHorConv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 350);
            this.panel1.TabIndex = 18;
            // 
            // lbAlerta
            // 
            this.lbAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlerta.ForeColor = System.Drawing.Color.Red;
            this.lbAlerta.Location = new System.Drawing.Point(56, 228);
            this.lbAlerta.Name = "lbAlerta";
            this.lbAlerta.Size = new System.Drawing.Size(523, 40);
            this.lbAlerta.TabIndex = 13;
            this.lbAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAlerta.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.txtResultConv);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(77, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 44);
            this.panel2.TabIndex = 8;
            // 
            // txtResultConv
            // 
            this.txtResultConv.CausesValidation = false;
            this.txtResultConv.Enabled = false;
            this.txtResultConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultConv.Location = new System.Drawing.Point(336, 7);
            this.txtResultConv.Multiline = true;
            this.txtResultConv.Name = "txtResultConv";
            this.txtResultConv.ReadOnly = true;
            this.txtResultConv.Size = new System.Drawing.Size(118, 29);
            this.txtResultConv.TabIndex = 7;
            this.txtResultConv.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor da hora trabalhada (R$):";
            // 
            // btnInsHorConv
            // 
            this.btnInsHorConv.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInsHorConv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsHorConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsHorConv.Location = new System.Drawing.Point(206, 271);
            this.btnInsHorConv.Name = "btnInsHorConv";
            this.btnInsHorConv.Size = new System.Drawing.Size(184, 65);
            this.btnInsHorConv.TabIndex = 5;
            this.btnInsHorConv.Text = "Inserir no cálculo e fechar";
            this.btnInsHorConv.UseVisualStyleBackColor = true;
            this.btnInsHorConv.Click += new System.EventHandler(this.btnInsHorConv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor do dia trabalhado (R$):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para converter o valor do dia trabalhado \r\nno valor de horas trabalhadas preencha" +
    " abaixo\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(219, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Conversor hora/dia";
            // 
            // txtValDia
            // 
            this.txtValDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValDia.Location = new System.Drawing.Point(413, 130);
            this.txtValDia.Name = "txtValDia";
            this.txtValDia.Size = new System.Drawing.Size(86, 30);
            this.txtValDia.TabIndex = 14;
            this.txtValDia.TextChanged += new System.EventHandler(this.txtValDia_TextChanged);
            // 
            // btnCalcConv
            // 
            this.btnCalcConv.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcConv.BackgroundImage = global::CalculoRenda.Properties.Resources.clock__1_;
            this.btnCalcConv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcConv.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalcConv.FlatAppearance.BorderSize = 0;
            this.btnCalcConv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcConv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCalcConv.Location = new System.Drawing.Point(505, 129);
            this.btnCalcConv.Name = "btnCalcConv";
            this.btnCalcConv.Size = new System.Drawing.Size(34, 30);
            this.btnCalcConv.TabIndex = 12;
            this.btnCalcConv.UseVisualStyleBackColor = false;
            this.btnCalcConv.Click += new System.EventHandler(this.btnCalcConv_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculoRenda.Properties.Resources.clock__1_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::CalculoRenda.Properties.Resources.error__1_;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(598, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 36);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HelpValorHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(628, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpValorHora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpValorHora";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAlerta;
        private System.Windows.Forms.Button btnCalcConv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtResultConv;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsHorConv;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtValDia;
    }
}
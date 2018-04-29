namespace CalculoRenda
{
    partial class HelpHoraTrab
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAlerta = new System.Windows.Forms.Label();
            this.btnCalcConv = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResultConv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsHoraConv = new System.Windows.Forms.Button();
            this.txtHorTrabConv = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(217, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Conversor dia/mês";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lbAlerta);
            this.panel1.Controls.Add(this.btnCalcConv);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnInsHoraConv);
            this.panel1.Controls.Add(this.txtHorTrabConv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 350);
            this.panel1.TabIndex = 14;
            // 
            // lbAlerta
            // 
            this.lbAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlerta.ForeColor = System.Drawing.Color.Red;
            this.lbAlerta.Location = new System.Drawing.Point(187, 244);
            this.lbAlerta.Name = "lbAlerta";
            this.lbAlerta.Size = new System.Drawing.Size(443, 23);
            this.lbAlerta.TabIndex = 13;
            this.lbAlerta.Visible = false;
            // 
            // btnCalcConv
            // 
            this.btnCalcConv.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcConv.BackgroundImage = global::CalculoRenda.Properties.Resources.update;
            this.btnCalcConv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcConv.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalcConv.FlatAppearance.BorderSize = 0;
            this.btnCalcConv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcConv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCalcConv.Location = new System.Drawing.Point(527, 125);
            this.btnCalcConv.Name = "btnCalcConv";
            this.btnCalcConv.Size = new System.Drawing.Size(26, 30);
            this.btnCalcConv.TabIndex = 12;
            this.btnCalcConv.UseVisualStyleBackColor = false;
            this.btnCalcConv.Click += new System.EventHandler(this.btnCalcConv_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.txtResultConv);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(99, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 44);
            this.panel2.TabIndex = 8;
            // 
            // txtResultConv
            // 
            this.txtResultConv.CausesValidation = false;
            this.txtResultConv.Enabled = false;
            this.txtResultConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultConv.Location = new System.Drawing.Point(364, 7);
            this.txtResultConv.Multiline = true;
            this.txtResultConv.Name = "txtResultConv";
            this.txtResultConv.ReadOnly = true;
            this.txtResultConv.Size = new System.Drawing.Size(87, 29);
            this.txtResultConv.TabIndex = 7;
            this.txtResultConv.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quant. horas trabalhadas p/ mês:";
            // 
            // btnInsHoraConv
            // 
            this.btnInsHoraConv.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInsHoraConv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsHoraConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsHoraConv.Location = new System.Drawing.Point(229, 273);
            this.btnInsHoraConv.Name = "btnInsHoraConv";
            this.btnInsHoraConv.Size = new System.Drawing.Size(184, 65);
            this.btnInsHoraConv.TabIndex = 5;
            this.btnInsHoraConv.Text = "Inserir no cálculo e fechar";
            this.btnInsHoraConv.UseVisualStyleBackColor = true;
            this.btnInsHoraConv.Click += new System.EventHandler(this.btnInsHoraConv_Click);
            // 
            // txtHorTrabConv
            // 
            this.txtHorTrabConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorTrabConv.Location = new System.Drawing.Point(463, 125);
            this.txtHorTrabConv.Mask = "00:00";
            this.txtHorTrabConv.Name = "txtHorTrabConv";
            this.txtHorTrabConv.Size = new System.Drawing.Size(58, 30);
            this.txtHorTrabConv.TabIndex = 3;
            this.txtHorTrabConv.ValidatingType = typeof(System.DateTime);
            this.txtHorTrabConv.TextChanged += new System.EventHandler(this.txtHorTrabConv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quant. horas trabalhadas p/ dia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para converter a carga horária diária para \r\ncarga horária mensal preencha abaixo" +
    "\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculoRenda.Properties.Resources.calculatorConvHor;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
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
            this.btnClose.Location = new System.Drawing.Point(596, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HelpHoraTrab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(628, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpHoraTrab";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpHoraTrab";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtHorTrabConv;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsHoraConv;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtResultConv;
        private System.Windows.Forms.Button btnCalcConv;
        private System.Windows.Forms.Label lbAlerta;
    }
}
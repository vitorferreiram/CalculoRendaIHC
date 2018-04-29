namespace CalculoRenda
{
    partial class CalcHoraExtra
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCalculoSal = new System.Windows.Forms.Panel();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPercHor = new System.Windows.Forms.TextBox();
            this.lbAlerta = new System.Windows.Forms.Label();
            this.txtHorExt = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcHorExt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValHorEx = new System.Windows.Forms.TextBox();
            this.panelSalReceber = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultHoraExt = new System.Windows.Forms.TextBox();
            this.panelCalculoSal.SuspendLayout();
            this.panelSalReceber.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCalculoSal
            // 
            this.panelCalculoSal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCalculoSal.BackColor = System.Drawing.SystemColors.Window;
            this.panelCalculoSal.Controls.Add(this.cbMes);
            this.panelCalculoSal.Controls.Add(this.label9);
            this.panelCalculoSal.Controls.Add(this.txtPercHor);
            this.panelCalculoSal.Controls.Add(this.lbAlerta);
            this.panelCalculoSal.Controls.Add(this.txtHorExt);
            this.panelCalculoSal.Controls.Add(this.label7);
            this.panelCalculoSal.Controls.Add(this.btnCalcHorExt);
            this.panelCalculoSal.Controls.Add(this.label1);
            this.panelCalculoSal.Controls.Add(this.label3);
            this.panelCalculoSal.Controls.Add(this.label2);
            this.panelCalculoSal.Controls.Add(this.txtValHorEx);
            this.panelCalculoSal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCalculoSal.Location = new System.Drawing.Point(0, 0);
            this.panelCalculoSal.Name = "panelCalculoSal";
            this.panelCalculoSal.Size = new System.Drawing.Size(693, 309);
            this.panelCalculoSal.TabIndex = 16;
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Setembro",
            "Agosto",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(374, 236);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(109, 26);
            this.cbMes.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Selecione o mês:";
            // 
            // txtPercHor
            // 
            this.txtPercHor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercHor.Location = new System.Drawing.Point(374, 181);
            this.txtPercHor.Name = "txtPercHor";
            this.txtPercHor.Size = new System.Drawing.Size(109, 30);
            this.txtPercHor.TabIndex = 3;
            this.txtPercHor.TextChanged += new System.EventHandler(this.txtPercHor_TextChanged);
            this.txtPercHor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercHor_KeyPress);
            // 
            // lbAlerta
            // 
            this.lbAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlerta.ForeColor = System.Drawing.Color.Red;
            this.lbAlerta.Location = new System.Drawing.Point(0, 265);
            this.lbAlerta.Name = "lbAlerta";
            this.lbAlerta.Size = new System.Drawing.Size(637, 44);
            this.lbAlerta.TabIndex = 13;
            this.lbAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAlerta.Visible = false;
            // 
            // txtHorExt
            // 
            this.txtHorExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorExt.Location = new System.Drawing.Point(374, 76);
            this.txtHorExt.Mask = "000:00";
            this.txtHorExt.Name = "txtHorExt";
            this.txtHorExt.Size = new System.Drawing.Size(109, 30);
            this.txtHorExt.TabIndex = 1;
            this.txtHorExt.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Percentual da hora extra (%):";
            // 
            // btnCalcHorExt
            // 
            this.btnCalcHorExt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalcHorExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcHorExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcHorExt.Location = new System.Drawing.Point(499, 76);
            this.btnCalcHorExt.Name = "btnCalcHorExt";
            this.btnCalcHorExt.Size = new System.Drawing.Size(128, 183);
            this.btnCalcHorExt.TabIndex = 5;
            this.btnCalcHorExt.Text = "Calcular";
            this.btnCalcHorExt.UseVisualStyleBackColor = true;
            this.btnCalcHorExt.Click += new System.EventHandler(this.btnCalcHorExt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quant. horas extras p/ mês:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preencha os dados abaixo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor da hora trabalhada (R$):";
            // 
            // txtValHorEx
            // 
            this.txtValHorEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValHorEx.Location = new System.Drawing.Point(374, 129);
            this.txtValHorEx.Name = "txtValHorEx";
            this.txtValHorEx.Size = new System.Drawing.Size(109, 30);
            this.txtValHorEx.TabIndex = 2;
            this.txtValHorEx.TextChanged += new System.EventHandler(this.txtValHorEx_TextChanged);
            // 
            // panelSalReceber
            // 
            this.panelSalReceber.BackColor = System.Drawing.SystemColors.Window;
            this.panelSalReceber.Controls.Add(this.label6);
            this.panelSalReceber.Controls.Add(this.label4);
            this.panelSalReceber.Controls.Add(this.txtResultHoraExt);
            this.panelSalReceber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSalReceber.Location = new System.Drawing.Point(0, 327);
            this.panelSalReceber.Name = "panelSalReceber";
            this.panelSalReceber.Size = new System.Drawing.Size(693, 197);
            this.panelSalReceber.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(487, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor total da hora extra a receber:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "R$";
            // 
            // txtResultHoraExt
            // 
            this.txtResultHoraExt.Enabled = false;
            this.txtResultHoraExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultHoraExt.Location = new System.Drawing.Point(269, 111);
            this.txtResultHoraExt.Multiline = true;
            this.txtResultHoraExt.Name = "txtResultHoraExt";
            this.txtResultHoraExt.ReadOnly = true;
            this.txtResultHoraExt.Size = new System.Drawing.Size(209, 29);
            this.txtResultHoraExt.TabIndex = 1;
            // 
            // CalcHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelCalculoSal);
            this.Controls.Add(this.panelSalReceber);
            this.Name = "CalcHoraExtra";
            this.Size = new System.Drawing.Size(693, 524);
            this.panelCalculoSal.ResumeLayout(false);
            this.panelCalculoSal.PerformLayout();
            this.panelSalReceber.ResumeLayout(false);
            this.panelSalReceber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCalculoSal;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalcHorExt;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSalReceber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultHoraExt;
        private System.Windows.Forms.MaskedTextBox txtHorExt;
        private System.Windows.Forms.TextBox txtValHorEx;
        private System.Windows.Forms.Label lbAlerta;
        private System.Windows.Forms.TextBox txtPercHor;
        private System.Windows.Forms.ComboBox cbMes;
        public System.Windows.Forms.Label label9;
    }
}

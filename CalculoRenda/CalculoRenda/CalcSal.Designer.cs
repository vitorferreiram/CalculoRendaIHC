namespace CalculoRenda
{
    partial class CalcSal
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
            this.btnHelpValTrab = new System.Windows.Forms.Button();
            this.btnHelpHoraTrab = new System.Windows.Forms.Button();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAlerta = new System.Windows.Forms.Label();
            this.txtHorTrab = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcSal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValHor = new System.Windows.Forms.TextBox();
            this.panelSalReceber = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.panelCalculoSal.SuspendLayout();
            this.panelSalReceber.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCalculoSal
            // 
            this.panelCalculoSal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCalculoSal.BackColor = System.Drawing.SystemColors.Window;
            this.panelCalculoSal.Controls.Add(this.btnHelpValTrab);
            this.panelCalculoSal.Controls.Add(this.btnHelpHoraTrab);
            this.panelCalculoSal.Controls.Add(this.cbMes);
            this.panelCalculoSal.Controls.Add(this.label9);
            this.panelCalculoSal.Controls.Add(this.lbAlerta);
            this.panelCalculoSal.Controls.Add(this.txtHorTrab);
            this.panelCalculoSal.Controls.Add(this.btnCalcSal);
            this.panelCalculoSal.Controls.Add(this.label1);
            this.panelCalculoSal.Controls.Add(this.label3);
            this.panelCalculoSal.Controls.Add(this.label2);
            this.panelCalculoSal.Controls.Add(this.txtValHor);
            this.panelCalculoSal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCalculoSal.Location = new System.Drawing.Point(0, 0);
            this.panelCalculoSal.Name = "panelCalculoSal";
            this.panelCalculoSal.Size = new System.Drawing.Size(693, 297);
            this.panelCalculoSal.TabIndex = 14;
            // 
            // btnHelpValTrab
            // 
            this.btnHelpValTrab.BackColor = System.Drawing.Color.White;
            this.btnHelpValTrab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelpValTrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpValTrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpValTrab.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelpValTrab.Image = global::CalculoRenda.Properties.Resources.clock;
            this.btnHelpValTrab.Location = new System.Drawing.Point(638, 126);
            this.btnHelpValTrab.Name = "btnHelpValTrab";
            this.btnHelpValTrab.Size = new System.Drawing.Size(29, 30);
            this.btnHelpValTrab.TabIndex = 19;
            this.btnHelpValTrab.UseVisualStyleBackColor = false;
            this.btnHelpValTrab.Visible = false;
            this.btnHelpValTrab.Click += new System.EventHandler(this.btnHelpValTrab_Click);
            // 
            // btnHelpHoraTrab
            // 
            this.btnHelpHoraTrab.BackColor = System.Drawing.Color.White;
            this.btnHelpHoraTrab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelpHoraTrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpHoraTrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpHoraTrab.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelpHoraTrab.Image = global::CalculoRenda.Properties.Resources.calculatorConvHor;
            this.btnHelpHoraTrab.Location = new System.Drawing.Point(638, 81);
            this.btnHelpHoraTrab.Name = "btnHelpHoraTrab";
            this.btnHelpHoraTrab.Size = new System.Drawing.Size(29, 30);
            this.btnHelpHoraTrab.TabIndex = 18;
            this.btnHelpHoraTrab.UseVisualStyleBackColor = false;
            this.btnHelpHoraTrab.Visible = false;
            this.btnHelpHoraTrab.Click += new System.EventHandler(this.btnHelpHoraTrab_Click);
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbMes.Location = new System.Drawing.Point(377, 174);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(144, 33);
            this.cbMes.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(171, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Selecione o mês:";
            // 
            // lbAlerta
            // 
            this.lbAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlerta.ForeColor = System.Drawing.Color.Red;
            this.lbAlerta.Location = new System.Drawing.Point(0, 232);
            this.lbAlerta.Name = "lbAlerta";
            this.lbAlerta.Size = new System.Drawing.Size(646, 54);
            this.lbAlerta.TabIndex = 0;
            this.lbAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAlerta.Visible = false;
            // 
            // txtHorTrab
            // 
            this.txtHorTrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorTrab.Location = new System.Drawing.Point(377, 81);
            this.txtHorTrab.Mask = "000:00";
            this.txtHorTrab.Name = "txtHorTrab";
            this.txtHorTrab.Size = new System.Drawing.Size(144, 30);
            this.txtHorTrab.TabIndex = 1;
            this.txtHorTrab.ValidatingType = typeof(System.DateTime);
            // 
            // btnCalcSal
            // 
            this.btnCalcSal.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalcSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSal.Location = new System.Drawing.Point(527, 81);
            this.btnCalcSal.Name = "btnCalcSal";
            this.btnCalcSal.Size = new System.Drawing.Size(105, 126);
            this.btnCalcSal.TabIndex = 4;
            this.btnCalcSal.Text = "Calcular";
            this.btnCalcSal.UseVisualStyleBackColor = true;
            this.btnCalcSal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quant. horas trabalhadas p/ mês:";
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
            this.label2.Location = new System.Drawing.Point(38, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor da hora trabalhada (R$):";
            // 
            // txtValHor
            // 
            this.txtValHor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValHor.Location = new System.Drawing.Point(377, 126);
            this.txtValHor.Name = "txtValHor";
            this.txtValHor.Size = new System.Drawing.Size(144, 30);
            this.txtValHor.TabIndex = 2;
            this.txtValHor.TextChanged += new System.EventHandler(this.txtValHor_TextChanged);
            // 
            // panelSalReceber
            // 
            this.panelSalReceber.BackColor = System.Drawing.SystemColors.Window;
            this.panelSalReceber.Controls.Add(this.label6);
            this.panelSalReceber.Controls.Add(this.label4);
            this.panelSalReceber.Controls.Add(this.txtSal);
            this.panelSalReceber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSalReceber.Location = new System.Drawing.Point(0, 317);
            this.panelSalReceber.Name = "panelSalReceber";
            this.panelSalReceber.Size = new System.Drawing.Size(693, 207);
            this.panelSalReceber.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sálario a receber:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "R$";
            // 
            // txtSal
            // 
            this.txtSal.CausesValidation = false;
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal.Location = new System.Drawing.Point(252, 121);
            this.txtSal.Multiline = true;
            this.txtSal.Name = "txtSal";
            this.txtSal.ReadOnly = true;
            this.txtSal.Size = new System.Drawing.Size(209, 29);
            this.txtSal.TabIndex = 4324;
            // 
            // CalcSal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelCalculoSal);
            this.Controls.Add(this.panelSalReceber);
            this.Name = "CalcSal";
            this.Size = new System.Drawing.Size(693, 524);
            this.panelCalculoSal.ResumeLayout(false);
            this.panelCalculoSal.PerformLayout();
            this.panelSalReceber.ResumeLayout(false);
            this.panelSalReceber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCalculoSal;
        private System.Windows.Forms.Button btnCalcSal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValHor;
        private System.Windows.Forms.Panel panelSalReceber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAlerta;
        private System.Windows.Forms.ComboBox cbMes;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHelpValTrab;
        private System.Windows.Forms.Button btnHelpHoraTrab;
        public System.Windows.Forms.MaskedTextBox txtHorTrab;
        public System.Windows.Forms.TextBox txtSal;
    }
}

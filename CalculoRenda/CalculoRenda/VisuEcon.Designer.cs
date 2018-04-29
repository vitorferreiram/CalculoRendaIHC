namespace CalculoRenda
{
    partial class VisuEcon
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgHoraExtra = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSalario = new System.Windows.Forms.DataGridView();
            this.dgTxtMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcHoraExtraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calcHoraExtraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.calcSalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgHoraExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcHoraExtraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcHoraExtraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcSalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Página em manutenção :(";
            // 
            // dgHoraExtra
            // 
            this.dgHoraExtra.AllowUserToAddRows = false;
            this.dgHoraExtra.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHoraExtra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgHoraExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHoraExtra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mes,
            this.horaExtra});
            this.dgHoraExtra.Location = new System.Drawing.Point(321, 104);
            this.dgHoraExtra.Name = "dgHoraExtra";
            this.dgHoraExtra.ReadOnly = true;
            this.dgHoraExtra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgHoraExtra.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgHoraExtra.RowTemplate.Height = 24;
            this.dgHoraExtra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHoraExtra.Size = new System.Drawing.Size(283, 379);
            this.dgHoraExtra.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hora Extra";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgSalario
            // 
            this.dgSalario.AllowUserToAddRows = false;
            this.dgSalario.AllowUserToOrderColumns = true;
            this.dgSalario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtMes,
            this.dgTxtSal});
            this.dgSalario.Location = new System.Drawing.Point(47, 104);
            this.dgSalario.Name = "dgSalario";
            this.dgSalario.ReadOnly = true;
            this.dgSalario.RowTemplate.Height = 24;
            this.dgSalario.Size = new System.Drawing.Size(243, 379);
            this.dgSalario.TabIndex = 12;
            // 
            // dgTxtMes
            // 
            this.dgTxtMes.HeaderText = "Mês";
            this.dgTxtMes.Name = "dgTxtMes";
            this.dgTxtMes.ReadOnly = true;
            // 
            // dgTxtSal
            // 
            this.dgTxtSal.HeaderText = "Salário";
            this.dgTxtSal.Name = "dgTxtSal";
            this.dgTxtSal.ReadOnly = true;
            // 
            // mes
            // 
            this.mes.FillWeight = 150F;
            this.mes.HeaderText = "Mês";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // horaExtra
            // 
            this.horaExtra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.horaExtra.FillWeight = 118F;
            this.horaExtra.HeaderText = "Valor de Hora Extra";
            this.horaExtra.Name = "horaExtra";
            this.horaExtra.ReadOnly = true;
            this.horaExtra.Width = 160;
            // 
            // calcHoraExtraBindingSource
            // 
            this.calcHoraExtraBindingSource.DataSource = typeof(CalculoRenda.CalcHoraExtra);
            // 
            // calcHoraExtraBindingSource1
            // 
            this.calcHoraExtraBindingSource1.DataSource = typeof(CalculoRenda.CalcHoraExtra);
            // 
            // calcSalBindingSource
            // 
            this.calcSalBindingSource.DataSource = typeof(CalculoRenda.CalcSal);
            // 
            // VisuEcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dgSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgHoraExtra);
            this.Controls.Add(this.label3);
            this.Name = "VisuEcon";
            this.Size = new System.Drawing.Size(693, 524);
            ((System.ComponentModel.ISupportInitialize)(this.dgHoraExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcHoraExtraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcHoraExtraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcSalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource calcHoraExtraBindingSource;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgHoraExtra;
        private System.Windows.Forms.BindingSource calcHoraExtraBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource calcSalBindingSource;
        public System.Windows.Forms.DataGridView dgSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtSal;
    }
}

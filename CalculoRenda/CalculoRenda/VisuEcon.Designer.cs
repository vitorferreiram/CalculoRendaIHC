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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgHoraExtra = new System.Windows.Forms.DataGridView();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSalario = new System.Windows.Forms.DataGridView();
            this.dgTxtMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTxtSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.btnExcelSalario = new System.Windows.Forms.Button();
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
            this.label3.Location = new System.Drawing.Point(182, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Visualizar relatório";
            // 
            // dgHoraExtra
            // 
            this.dgHoraExtra.AllowUserToAddRows = false;
            this.dgHoraExtra.AllowUserToDeleteRows = false;
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
            this.dgHoraExtra.Location = new System.Drawing.Point(321, 93);
            this.dgHoraExtra.Name = "dgHoraExtra";
            this.dgHoraExtra.ReadOnly = true;
            this.dgHoraExtra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgHoraExtra.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgHoraExtra.RowTemplate.Height = 24;
            this.dgHoraExtra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHoraExtra.Size = new System.Drawing.Size(283, 359);
            this.dgHoraExtra.TabIndex = 8;
            // 
            // mes
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mes.DefaultCellStyle = dataGridViewCellStyle2;
            this.mes.FillWeight = 150F;
            this.mes.HeaderText = "Mês";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Width = 80;
            // 
            // horaExtra
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.horaExtra.DefaultCellStyle = dataGridViewCellStyle3;
            this.horaExtra.HeaderText = "Valor de Hora Extra";
            this.horaExtra.Name = "horaExtra";
            this.horaExtra.ReadOnly = true;
            this.horaExtra.Width = 159;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hora Extra";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgSalario
            // 
            this.dgSalario.AllowUserToAddRows = false;
            this.dgSalario.AllowUserToDeleteRows = false;
            this.dgSalario.AllowUserToOrderColumns = true;
            this.dgSalario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgTxtMes,
            this.dgTxtSal});
            this.dgSalario.Location = new System.Drawing.Point(47, 93);
            this.dgSalario.Name = "dgSalario";
            this.dgSalario.ReadOnly = true;
            this.dgSalario.RowTemplate.Height = 24;
            this.dgSalario.Size = new System.Drawing.Size(250, 359);
            this.dgSalario.TabIndex = 12;
            // 
            // dgTxtMes
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgTxtMes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgTxtMes.HeaderText = "Mês";
            this.dgTxtMes.Name = "dgTxtMes";
            this.dgTxtMes.ReadOnly = true;
            this.dgTxtMes.Width = 90;
            // 
            // dgTxtSal
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.dgTxtSal.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgTxtSal.HeaderText = "Salário";
            this.dgTxtSal.Name = "dgTxtSal";
            this.dgTxtSal.ReadOnly = true;
            this.dgTxtSal.Width = 116;
            // 
            // btnGrafico
            // 
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.Image = global::CalculoRenda.Properties.Resources.graph;
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.Location = new System.Drawing.Point(321, 458);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(283, 45);
            this.btnGrafico.TabIndex = 14;
            this.btnGrafico.Text = "Exportar para gráfico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // btnExcelSalario
            // 
            this.btnExcelSalario.BackColor = System.Drawing.Color.Transparent;
            this.btnExcelSalario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcelSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelSalario.Image = global::CalculoRenda.Properties.Resources.excel__1_;
            this.btnExcelSalario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelSalario.Location = new System.Drawing.Point(47, 458);
            this.btnExcelSalario.Name = "btnExcelSalario";
            this.btnExcelSalario.Size = new System.Drawing.Size(250, 45);
            this.btnExcelSalario.TabIndex = 13;
            this.btnExcelSalario.Text = "   Exportar para o Excel";
            this.btnExcelSalario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelSalario.UseVisualStyleBackColor = false;
            this.btnExcelSalario.Click += new System.EventHandler(this.btnExcelSalario_Click);
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
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.btnExcelSalario);
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
        private System.Windows.Forms.Button btnExcelSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTxtSal;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaExtra;
    }
}

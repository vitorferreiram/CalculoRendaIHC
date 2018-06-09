using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelGraf = Microsoft.Office.Interop.Excel;

namespace CalculoRenda
{
    public partial class VisuEcon : UserControl
    {
        public event DataGridViewCellEventHandler CellValueChanged;
        public event DataGridViewRowEventHandler UserDeletedRow;

        Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

        

        public VisuEcon()
        {
            InitializeComponent();
            dgSalario.CellValueChanged += (s, e) => this.CellValueChanged?.Invoke(this, e);
            dgSalario.UserDeletedRow += (s, e) => this.UserDeletedRow?.Invoke(this, e);

            TXTCalcSal();
            TXTCalcHoraExtra();

            //dgSalario.Update();
        }

        public void TXTCalcSal()
        {
            string path = @"salario.txt";
            string[] Linha = System.IO.File.ReadAllLines(path);
            CalcSal cSal = new CalcSal();

            if (Linha.Length == 0)
            {
                return;
            }

            for (int i = 0; i < Linha.Length; i++)
            {
                string[] valores = Linha[i].Split(';');

                dgSalario.Rows.Add(valores[0], valores[1]);
            }
            
        }

        public void TXTCalcHoraExtra()
        {
            string path = @"horaextra.txt";
            string[] Linha = System.IO.File.ReadAllLines(path);
            CalcSal cSal = new CalcSal();

            if (Linha.Length == 0)
            {
                return;
            }

            for (int i = 0; i < Linha.Length; i++)
            {
                string[] valores = Linha[i].Split(';');

                dgHoraExtra.Rows.Add(valores[0], valores[1]);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExcelSalario_Click(object sender, EventArgs e)
        {
            
            if (dgSalario.Rows.Count > 0)
            {
                try
                {
                    Excel.Application.Workbooks.Add(Type.Missing);

                    //cabeçalho
                    for (int i = 1; i < dgHoraExtra.Columns.Count + 1; i++)
                    {
                        Excel.Cells[1, i] = dgHoraExtra.Columns[i - 1].HeaderText;
                    }
                    //preencher valores
                    for (int i = 0; i < dgHoraExtra.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgHoraExtra.Columns.Count; j++)
                        {
                            Excel.Cells[i + 2, j + 1] = dgHoraExtra.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //ajustar tamanho colunas
                    Excel.Columns.AutoFit();

                    //--------------------------------------------------------

                    Excel.Application.Worksheets.Add(Type.Missing);


                    //cabeçalho
                    for (int i = 1; i < dgSalario.Columns.Count + 1; i++)
                    {
                        Excel.Cells[1, i] = dgSalario.Columns[i - 1].HeaderText;
                    }
                    //preencher valores
                    for (int i = 0; i < dgSalario.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgSalario.Columns.Count; j++)
                        {
                            Excel.Cells[i + 2, j + 1] = dgSalario.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //ajustar tamanho colunas
                    Excel.Columns.AutoFit();

                    Excel.Worksheets[1].Name = "Sálario";
                    Excel.Worksheets[2].Name = "Hora extra";
                    //abrir planilha
                    Excel.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    Excel.Quit();
                }
            }
        }


        private void btnGrafico_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelGraf.Application xlApp;
                ExcelGraf.Workbook xlWorkBook;
                ExcelGraf.Worksheet xlWorkSheet;// xlWorkSheet2;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new ExcelGraf.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (ExcelGraf.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                           
                //-------------------------------------arquivo
                string path = @"salario.txt";
                string[] Linha = System.IO.File.ReadAllLines(path);
                                
                if (Linha.Length == 0)
                {
                    return;
                }
                int g = 2;
                
                for (int i = 0; i < Linha.Length; i++)
                {
                    string[] valores = Linha[i].Split(';');
                    
                    xlWorkSheet.Cells[g, 1] = valores[0];
                    xlWorkSheet.Cells[g, 2] = double.Parse(valores[1]);
                    g++;
                   
                }
                //---------------------------------------

                ExcelGraf.Range chartRange;

                ExcelGraf.ChartObjects xlCharts = (ExcelGraf.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
                ExcelGraf.ChartObject myChart = (ExcelGraf.ChartObject)xlCharts.Add(1, 1, 600, 250);
                ExcelGraf.Chart chartPage = myChart.Chart;

                chartRange = xlWorkSheet.get_Range("A1", "D10");
                chartPage.SetSourceData(chartRange, misValue);
                chartPage.ChartType = ExcelGraf.XlChartType.xlColumnClustered;

                xlWorkBook.Worksheets.Add(Type.Missing);
                xlWorkBook.Worksheets[1].Name = "Hora extra";

                //---------------------------------------hora extra
                

                xlWorkBook.Worksheets[2].Name = "Sálario";


                //xlWorkSheet2 = (ExcelGraf.Worksheet)xlWorkBook.Worksheets.get_Item(2);

                


                //chartRange = xlWorkSheet2.get_Range("A1", "D10");
                //chartPage.SetSourceData(chartRange, misValue);
                //chartPage.ChartType = ExcelGraf.XlChartType.xlColumnClustered;



                //abrir gráfico
                xlWorkBook.Application.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                Excel.Quit();
            }

        }

       
    }
}

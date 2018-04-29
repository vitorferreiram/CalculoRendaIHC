using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoRenda
{
    public partial class VisuEcon : UserControl
    {
        public event DataGridViewCellEventHandler CellValueChanged;
        public event DataGridViewRowEventHandler UserDeletedRow;
        public VisuEcon()
        {
            InitializeComponent();
            dgSalario.CellValueChanged += (s, e) => this.CellValueChanged?.Invoke(this, e);
            dgSalario.UserDeletedRow += (s, e) => this.UserDeletedRow?.Invoke(this, e);
        }

        public void TXT()
        {
            string path = @"documento.txt";
            string[] Linha = System.IO.File.ReadAllLines(path);
            CalcSal cSal = new CalcSal();

            if (Linha.Length == 0)
            {
                return;
            }

            for (int i = 0; i < Linha.Length; i++)
            {
                string[] valores = Linha[i].Split(';');
                
                dgSalario.Rows.Add(valores[0],valores[1]);
            }

        }

        public void apagarDataGrid()
        {
            dgSalario.Rows.Clear();
            dgSalario.Refresh();
        }

        public void PassaListaSal(List<string> lista)
        {
            // dgSalario.DataSource = lista;
            //dgSalario.Update();
            //dgSalario.Refresh();


            //foreach (string linha in lista)
            //{
            //    string[] horas = linha.Split(';');
            //    string mes = horas[0];
            //    string valor = horas[1];
            //    //dgHoraExtra.Rows.Add(mes, valor);

            
            dgSalario.Rows.Add("ab", "cd");

            //}


        }

        public void PassaListaExtra(List<string> lista)
        {

            foreach (string linha in lista)
            {
                string[] horasExtras = linha.Split(';');
                string mes = horasExtras[0];
                string valor = horasExtras[1];
                dgHoraExtra.Rows.Add(mes, valor);
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

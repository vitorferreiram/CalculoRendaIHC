using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoRenda
{
    public partial class HelpValorHora : Form
    {
        public HelpValorHora()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsHorConv_Click(object sender, EventArgs e)
        {
            CalcSal cs = new CalcSal();

            
        }

        private void txtValDia_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValDia.Text, "[^0-9-.]"))
            {
                lbAlerta.Visible = true;
                lbAlerta.Text = "Atenção! Use somente números. Separe com ponto para usar um número não inteiro.";
                txtValDia.Text = txtValDia.Text.Substring(0, txtValDia.Text.Length - 1);
                txtValDia.Select(txtValDia.Text.Length, 0);
            }
        }

        private void btnCalcConv_Click(object sender, EventArgs e)
        {
            double dia = 0;
            double resultHora = 0;

            lbAlerta.Visible = false;

            if (txtValDia.Text == "")
            {
                lbAlerta.Visible = true;
                lbAlerta.Text = "Atenção! Informe a quantidade de horas!";
                txtValDia.Focus();
                return;
            }
            else
            {
                dia = double.Parse(txtValDia.Text);
                resultHora = dia / 24;

                txtResultConv.Text = resultHora.ToString();
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CalculoRenda
{
    public partial class CalcHoraExtra : UserControl
    {
        public CalcHoraExtra()
        {
            InitializeComponent();
            cbMes.SelectedIndex = DateTime.Now.Month - 1;
        }


        public void Mensagem(string msg, bool status)
        {
            if (status)
                lbAlerta.ForeColor = Color.Green;
            else
                lbAlerta.ForeColor = Color.Red;

            lbAlerta.Text = msg;
            lbAlerta.Visible = true;
        }

        private void btnCalcHorExt_Click(object sender, EventArgs e)
        {
            double result = 0;
            double horaTrab = 0 ;
            double minuto = 0;
            double hora = 0;
            string mes = cbMes.SelectedItem.ToString();
            lbAlerta.Visible = false;

            if (vazio(txtPercHor) || vazio(txtHorExt) || vazio(txtValHorEx)) { }
            else
            {
                string[] splitHora = txtHorExt.Text.Split(':');
                
                if (!double.TryParse(splitHora[0], out hora))
                {
                    Mensagem("Atenção! Informe a quantidade de horas!", false);
                    txtHorExt.Focus();
                    return;
                }
                else if (!double.TryParse(splitHora[1], out minuto))
                {
                    Mensagem("Atenção! Informe os minutos!", false);
                    txtHorExt.Focus();
                    return;
                }
                horaTrab = minuto / 60 + hora;
                result = horaTrab * double.Parse(txtValHorEx.Text) * (double.Parse(txtPercHor.Text) /100);

                result = Math.Round(result, 2);
                txtResultHoraExt.Text = result.ToString();

                //salvar arquivo txt

                string path = @"horaextra.txt";
                Stream f = File.Open(path, FileMode.Append);
                StreamWriter file = new StreamWriter(f);

                file.WriteLine(mes + ';' + result);
                file.Close();

                txtHorExt.Clear();
                txtValHorEx.Clear();
                txtPercHor.Clear();

                Mensagem("Valor de hora extra adicionado ao histórico.", true);
            }
        }

        private bool vazio(TextBox txb)
        {
            if (string.IsNullOrEmpty(txb.Text))
            {
                Mensagem("Atenção! Informe todos os campos necessários para o cálculo!", false);
                txb.Focus();
                return true;
            }
            return false;
        }

        private bool vazio(MaskedTextBox txb)
        {
            if (string.IsNullOrEmpty(txb.Text))
            {
                Mensagem("Atenção! Informe todos os campos necessários para o cálculo!", false);
                txb.Focus();
                return true;
            }
            return false;
        }

        private void somenteNumeros(TextBox txb)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txb.Text, "[^0-9-,]"))
            {
                Mensagem("Atenção! Use somente números. Separe com virgula para usar um número não inteiro.", false);
                txb.Text = txb.Text.Substring(0, txb.Text.Length - 1);
                txb.Select(txb.Text.Length, 0);
            }
        }

        private void txtValHorEx_TextChanged(object sender, EventArgs e)
        {
            somenteNumeros(txtValHorEx);
        }

        private void txtPercHor_TextChanged(object sender, EventArgs e)
        {
            somenteNumeros(txtPercHor);
        }

        private void txtPercHor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}

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
    public partial class CalcSal : UserControl
    {
        public List<string> lstSalario = new List<string>();
        VisuEcon relatorio = new VisuEcon();
       
        public void Mensagem (string msg, bool status)
        {
            if (status)
                lbAlerta.ForeColor = Color.Green;
            else
                lbAlerta.ForeColor = Color.Red;

            lbAlerta.Text = msg;
            lbAlerta.Visible = true;
        }

        string txtTest;


        public void HoraConv(string txtHoraConv)//receber valor da conversão da carga horaria no mes
        {

            txtTest = txtHoraConv;
            txtHorTrab.Text = txtHoraConv;
            //MessageBox.Show(txtHoraConv);//teste variavel de outra classe

        }

        string txtValHora;
        public void DiaConv(string txtDia)//receber valor da conversão do dia por hora
        {

            txtValHora = txtDia;
            txtValHor.Text = txtValHora;//não funciona :(
        }

       
        public CalcSal()
        {
            InitializeComponent();
            cbMes.SelectedIndex = DateTime.Now.Month - 1;
                        
        }

        public void button1_Click(object sender, EventArgs e)
        {
            double result = 0;
            double horaTrab = 0;
            double minuto = 0;
            double hora = 0;
            string mes = cbMes.SelectedItem.ToString();
            lbAlerta.Visible = false;

            if (vazio(txtHorTrab) || vazio(txtValHor)) { }
            else
            {
                string[] splitHora = txtHorTrab.Text.Split(':');
                if (!double.TryParse(splitHora[0], out hora))
                {
                    Mensagem("Atenção! Informe a quantidade de horas!", false);
                    txtHorTrab.Focus();
                    return;
                }
                else if (!double.TryParse(splitHora[1], out minuto))
                {
                    Mensagem("Atenção! Informe os minutos!", false);
                    txtHorTrab.Focus();
                    return;
                }
                horaTrab = minuto / 60 + hora;
                result = horaTrab * double.Parse(txtValHor.Text);
                // conta errada
                

                lstSalario.Add(mes + ";" + result.ToString("n2"));
                relatorio.PassaListaSal(lstSalario);

                txtSal.ReadOnly = true;
                txtSal.Text = result.ToString("n2");

                //salvar arquivo txt

                string path = @"documento.txt";
                Stream f = File.Open(path, FileMode.Append);
                StreamWriter file = new StreamWriter(f);

                file.WriteLine(mes + ';' + result);
                file.Close();

                txtHorTrab.Clear();
                txtValHor.Clear();

                Mensagem("Valor do salário adicionado ao histórico.", true);
            }
        }

        private void txtHorTrab_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtHorTrab.Clear();
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

        public bool vazio(MaskedTextBox txb)
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

        private void txtValHor_TextChanged(object sender, EventArgs e)
        {
            somenteNumeros(txtValHor);
        }

        private void btnHelpHoraTrab_Click(object sender, EventArgs e)
        {
            HelpHoraTrab FrmHelpHoraTrab = new HelpHoraTrab();
            FrmHelpHoraTrab.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHelpValTrab_Click(object sender, EventArgs e)
        {
            HelpValorHora FrmHelpValorHora = new HelpValorHora();
            FrmHelpValorHora.Show();
        }
    }
}

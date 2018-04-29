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
    public partial class HelpHoraTrab : Form
    {
        public HelpHoraTrab()
        {
            InitializeComponent();
            txtHorTrabConv.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnCalcConv_Click(object sender, EventArgs e)
        {
            double result = 0;
            double tempoHora = 0;
            double minuto = 0;
            double hora = 0;

            lbAlerta.Visible = false;

            if (txtHorTrabConv.Text == ":") { }
            else
            {
                string[] splitHora = txtHorTrabConv.Text.Split(':');
                if (!double.TryParse(splitHora[0], out hora))
                {
                    lbAlerta.Visible = true;
                    lbAlerta.Text = "Atenção! Informe a quantidade de horas!";
                    txtHorTrabConv.Focus();
                    return;
                }
                else if (!double.TryParse(splitHora[1], out minuto))
                {
                    lbAlerta.Visible = true;
                    lbAlerta.Text = "Atenção! Informe os minutos!";
                    txtHorTrabConv.Focus();
                    return;
                }
                tempoHora = ((hora * 60) + minuto);
                result = (tempoHora * 30) / 60;
                txtResultConv.Text = result.ToString();
            }
        }
        private void btnInsHoraConv_Click(object sender, EventArgs e)
        {
            CalcSal cs = new CalcSal();

            cs.HoraConv(txtResultConv.Text);
            //cs.txtHorTrab.Text = txtResultConv.Text;
            
            Close();
            
            
        }

        private void txtHorTrabConv_TextChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}

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
    public partial class Form1 : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);        

        public Form1()
        {
            InitializeComponent();
            panelMen.Height = btnCalcSal.Height;
            panelMen.Top = btnCalcSal.Top;
            calcSal1.BringToFront();

        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCalcSal_Click(object sender, EventArgs e)
        {
            panelMen.Height = btnCalcSal.Height;
            panelMen.Top = btnCalcSal.Top;
            calcSal1.BringToFront();
                        
        }

        private void btnCalcHoraExtra_Click(object sender, EventArgs e)
        {
            panelMen.Height = btnCalcHoraExtra.Height;
            panelMen.Top = btnCalcHoraExtra.Top;
            calcHoraExtra2.BringToFront();
          
        }
        
        private void btnVisuEcon_Click(object sender, EventArgs e)
        {
            panelMen.Height = btnVisuEcon.Height;
            panelMen.Top = btnVisuEcon.Top;
            visuEcon1.BringToFront();

           //inicializar ele denovo para atualizar lista
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {




        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void calcSal1_Load(object sender, EventArgs e)
        {

        }
    }
}

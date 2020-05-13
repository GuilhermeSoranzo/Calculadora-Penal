using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcJean
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

    }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPorcentos16_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btnFracaoUmDois_Click(object sender, EventArgs e)
        {
            decimal dia, mes, ano, resto;
            dia = 0;
            mes = 0;
            ano = 0;


            ano = Math.Floor(numAno.Value / 2);
            resto = numAno.Value % 2;


            mes = Math.Floor(((resto * 12) + numMes.Value) / 2);

            dia = Math.Floor((((((resto * 12) + numMes.Value) % 2) * 30) + numDia.Value) / 2);

            numAno.Value = ano;
            numMes.Value = mes;
            numDia.Value = dia;

            dia = 0;
            mes = 0;
            ano = 0;
        }

        private void btnFracaoUmTres_Click(object sender, EventArgs e)
        {
            decimal dia, mes, ano, resto;
            dia = 0;
            mes = 0;
            ano = 0;


            ano = Math.Floor(numAno.Value / 3);
            resto = numAno.Value % 3;


            mes = Math.Floor(((resto * 12) + numMes.Value) / 3);

            dia = Math.Floor((((((resto * 12) + numMes.Value) % 3) * 30) + numDia.Value) / 3);

            numAno.Value = ano;
            numMes.Value = mes;
            numDia.Value = dia;

            dia = 0;
            mes = 0;
            ano = 0;
        }

        private void btnFracaoUmQuatro_Click(object sender, EventArgs e)
        {
            decimal dia, mes, ano, resto;
            dia = 0;
            mes = 0;
            ano = 0;


            ano = Math.Floor(numAno.Value / 4);
            resto = numAno.Value % 4;


            mes = Math.Floor(((resto * 12) + numMes.Value) / 4);

            dia = Math.Floor((((((resto * 12) + numMes.Value) % 4) * 30) + numDia.Value) / 4);

            numAno.Value = ano;
            numMes.Value = mes;
            numDia.Value = dia;

            dia = 0;
            mes = 0;
            ano = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal dia, mes, ano, resto;
            dia = 0;
            mes = 0;
            ano = 0;


            ano = Math.Floor(numAno.Value / 5);
            resto = numAno.Value % 5;


            mes = Math.Floor(((resto * 12) + numMes.Value) / 5);

            dia = Math.Floor((((((resto * 12) + numMes.Value) % 5) * 30) + numDia.Value) / 5);

            numAno.Value = ano;
            numMes.Value = mes;
            numDia.Value = dia;

            dia = 0;
            mes = 0;
            ano = 0;
        }
    }
}

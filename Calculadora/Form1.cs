using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "x";
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textResultado.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                textResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if(operacao == "SUBTRACAO")
            {
                textResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                textResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISAO" && valor1 == 0 || valor2 == 0)
            {
                textResultado.Text = "Divisão por 0 igual infinito";
            }
            else if (operacao == "DIVISAO" && valor1 != 0 || valor2 != 0)
            {
                textResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
            }
  
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "DIVISAO";
                lblOperacao.Text = "/";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }

        }
    }
}

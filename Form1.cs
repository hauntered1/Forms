using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularAreaPerimetro_Click(object sender, EventArgs e)
        {
            double lado = double.Parse(txtLado.Text);
            double area = lado * lado;
            double perimetro = 4 * lado;

            lblAreaPerimetro.Text = $"Área: {area}\nPerímetro: {perimetro}";
        }

        private void btnCalcularValorReal_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            double valorDolar = double.Parse(txtValorDolar.Text);
            double cotacaoDolar = 5.45;
            double valorReal = valorDolar * cotacaoDolar;

            lblValorReal.Text = $"O valor do produto {produto} em reais é R$ {valorReal}";
        }

        private void btnExibirDataAtual_Click(object sender, EventArgs e)
        {
            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
            lblDataAtual.Text = $"Data atual = {dataAtual}";
        }
    }
}

    }
}
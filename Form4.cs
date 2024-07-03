using System;
using System.Windows.Forms;

namespace CalculadoraRetangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double largura = Convert.ToDouble(txtLargura.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            double area = largura * altura;
            double perimetro = 2 * (largura + altura);

            lblAreaResultado.Text = "Área: " + area.ToString();
            lblPerimetroResultado.Text = "Perímetro: " + perimetro.ToString();
        }
    }
}

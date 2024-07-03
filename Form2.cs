using System;
using System.Windows.Forms;

namespace CalculadoraQuadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            double lado = double.Parse(txtLado.Text);

           
            double area = Math.Pow(lado, 2);
            double perimetro = 4 * lado;

            
            lblResultado.Text = "Área: {area}\nPerímetro: {perimetro}";
        }
    }
}

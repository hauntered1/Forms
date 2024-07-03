using System;
using System.Windows.Forms;

namespace ExibirDataAtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExibirDataAtual_Click(object sender, EventArgs e)
        {
            
            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");

           
            lblDataAtual.Text = $"Data atual = {dataAtual}";
        }
    }
}

using System.Windows.Forms;
namespace CalcArea
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));  //usei gpt pra ver isso de colocar cores aleatorias
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbTriangulo.Checked)
            {
                this.BackColor = GetRandomColor();
                pictureBox1.Image = Image.FromFile(@"C:\Users\joao.hfgoncalves\Desktop\aa\triangulo-5_xl.jpeg");
                lblFormula.Text = "b*h/2";
                lblf1.Text = " lado ";
                lblf2.Text = " altura ";
                btnb2.Visible = true;
                btnb1.Visible = true;
                btnb3.Visible = false;
                lblf3.Text = "";
                btnb2.Focus();
            }
        }

        private void RadioQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbQuadrado.Checked)
            {
                this.BackColor = GetRandomColor();
                pictureBox1.Image = Image.FromFile(@"C:\Users\joao.hfgoncalves\Desktop\aa\quadrado.jfif");
                lblFormula.Text = "l²";
                lblf2.Text = " lado ";
                btnb2.Visible = true;
                lblf1.Text = "";
                lblf3.Text = "";
                btnb1.Visible = false;
                btnb3.Visible = false;
            }
        }

        private void RadioRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbRetangulo.Checked)
            {
                this.BackColor = GetRandomColor();
                pictureBox1.Image = Image.FromFile(@"C:\Users\joao.hfgoncalves\Desktop\aa\retangulo-roxo-claro.jpg");
                lblFormula.Text = "b*h";
                lblf3.Text = "";
                lblf1.Text = " base ";
                lblf2.Text = " altura ";
                btnb2.Visible = true;
                btnb1.Visible = true;
                btnb3.Visible = false;
            }
        }

        private void RadioCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbCirculo.Checked)
            {
                this.BackColor = GetRandomColor();
                pictureBox1.Image = Image.FromFile(@"C:\Users\joao.hfgoncalves\Desktop\aa\250px-Circle_-_black_simple.svg.png");
                lblFormula.Text = "πr²";
                lblf1.Text = "";
                lblf3.Text = "";
                lblf2.Text = " raio ";
                btnb1.Visible = false;
                btnb2.Visible = true;
                btnb3.Visible = false;
            }
        }

        private void RadioTrapezio_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbTrapezio.Checked)
            {
                this.BackColor = GetRandomColor();
                pictureBox1.Image = Image.FromFile(@"C:\Users\joao.hfgoncalves\Desktop\aa\download.png");
                lblFormula.Text = "((B+b)*h/2)";
                lblf1.Text = " base (B)";
                lblf2.Text = " base (b) ";
                lblf3.Text = " altura ";
                btnb2.Visible = true;
                btnb1.Visible = true;
                btnb3.Visible = true;
            }
        }

        private void btnfazer_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


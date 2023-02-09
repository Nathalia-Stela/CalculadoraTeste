using System.Globalization;
using System.Windows.Forms;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "0";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
               TxtResultado.Text = Convert.ToString (valor1 + valor2);
            } 
            else if (operacao == "SUB")
            {
                TxtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                TxtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                TxtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {

                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Digite um valor.");
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Digite um valor.");
            }
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Digite um valor.");
            }
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text !="")
            { 
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Digite um valor.");
            }
        }
    }
}
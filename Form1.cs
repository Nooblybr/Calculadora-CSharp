using System.Data;
using System.Linq.Expressions;

namespace Calculadora_CSharp;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void PressionarBotao(object sender, EventArgs e)
    {
        Button button = sender as Button;

        if (button != null)
        {
            if (button.Text == "x")
            {
                txtVisor.Text += "*";
            }
            else
            {
                txtVisor.Text += button.Text;
            }
        }
    }

    private void LimparVisor(object sender, EventArgs e)
    {
        txtVisor.Clear();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        string expressao = txtVisor.Text.Replace(",", ".");

        DataTable dt = new DataTable();
        try
        {
            var resultado = Convert.ToDouble(dt.Compute(expressao, null));

            txtVisor.Text = resultado.ToString();
        }
        catch (Exception ex)
        {
            txtVisor.Text = "ERRO";
        }

    }

    private void btn_raizQuadrada_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        string expressao = txtVisor.Text.Replace(",", ".");

        try
        {
            double num = Convert.ToDouble(dt.Compute(expressao, null));
            double resultado = Math.Sqrt(num);
            txtVisor.Text = resultado.ToString();
        }
        catch (Exception ex) 
        {
            txtVisor.Text = "ERRO";
        }
    }
}

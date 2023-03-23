using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Equação_do_Segundo_Grau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double[] Calcular(double a, double b, double c)
        {
            double[] raizes = new double[2];

            if (a == 0)
            {
                return raizes;
            }

            double delta = (Math.Pow(b, 2)) - (4 * a * c);
            if (delta < 0)
            {
                return raizes;
            }
            else if (delta >= 0)
            {
                raizes[0] = (-b + Math.Sqrt(delta)) / (2 * a);
                raizes[1] = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            return raizes;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            List<TextBox> parametros = new List<TextBox>();
            parametros.AddRange(grpBoxEqc.Controls.OfType<TextBox>());

            foreach (TextBox tb in parametros)
            {
                if (tb.Text != string.Empty)
                {
                    if (tb.Name.Contains("A"))
                    {
                        a = Convert.ToDouble(tb.Text);
                    }
                    else if (tb.Name.Contains("Be"))
                    {
                        b = Convert.ToDouble(tb.Text);
                    }
                    else if (tb.Name.Contains("C"))
                    {
                        c = Convert.ToDouble(tb.Text);
                    }
                }
            }
            double[] resposta = Calcular(a, b, c);
            if (resposta.Contains(0))
            {
                txtBoxRes.Text = "Não possui raiz real.";
            }
            else
            {
                txtBoxRes.Text = "X₁ = " + String.Format("{0:0.00}",resposta[0]) + "  |  " + "X₂ = " + String.Format("{0:0.00}", resposta[1]);
            }
            
        }
    }
}

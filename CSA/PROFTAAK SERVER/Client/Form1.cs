using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace Client
{
    public partial class Form1 : Form
    {
        private MyCalculator.CalculatorClient proxy;

        public Form1()
        {
            proxy = new MyCalculator.CalculatorClient();

            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtN1.Text);
            double number2 = Convert.ToDouble(txtN2.Text);
            double answer = proxy.Add(number1, number2);
            txtAnswer.Text = answer.ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtN1.Text);
            double number2 = Convert.ToDouble(txtN2.Text);
            double answer = proxy.Substract(number1, number2);
            txtAnswer.Text = answer.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtN1.Text);
            double number2 = Convert.ToDouble(txtN2.Text);
            double answer = proxy.Multiply(number1, number2);
            txtAnswer.Text = answer.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtN1.Text);
            double number2 = Convert.ToDouble(txtN2.Text);
            double answer = proxy.Divide(number1, number2);
            txtAnswer.Text = answer.ToString();
        }

        private void btnNrOfCalculations_Click(object sender, EventArgs e)
        {
            int nr = proxy.getNrOfCalculations();
            txtNrOfCalculations.Text = nr.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primer = 0;
        double segun = 0;
        string operador; 

        public Form1()
        {
            InitializeComponent();
        }

        Clases.clsSuma obj = new Clases.clsSuma();
        Clases.clsResta obj2 = new Clases.clsResta();
        Clases.clsMulti obj3 = new Clases.clsMulti();
        Clases.clsDiv obj4 = new Clases.clsDiv(); 
        

        private void btn0_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "9";
        }

        private void btnDeci_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int inicial = 0;
            txtscreen.Text = inicial.ToString();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operador = "+";
            primer = double.Parse(txtscreen.Text);
            txtscreen.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primer = double.Parse(txtscreen.Text);
            txtscreen.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            primer = double.Parse(txtscreen.Text);
            txtscreen.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primer = double.Parse(txtscreen.Text);
            txtscreen.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segun = double.Parse(txtscreen.Text);

            double sum;
            double res;
            double mul;
            double div;

            switch (operador)
            {
                case "+":
                    sum = obj.Sumar(primer, segun);
                    txtscreen.Text = sum.ToString();
                    break;
                case "-":
                    res = obj2.Restar(primer, segun);
                    txtscreen.Text = res.ToString();
                    break;
                case "*":
                    mul = obj3.Multi(primer, segun);
                    txtscreen.Text = mul.ToString();
                    break;
                case "/":
                    div = obj4.Div(primer, segun);
                    txtscreen.Text = div.ToString();
                    break;
            }
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtscreen.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtscreen.Text.Length == 1)
                    txtscreen.Text = "";
                else
                    txtscreen.Text = txtscreen.Text.Substring(0, txtscreen.Text.Length - 1);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay datos para borrar");
            }
           
        }
    }
}

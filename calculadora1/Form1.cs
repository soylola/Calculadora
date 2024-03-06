using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora1
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }


        // VARIABLES

        string operador = "";
        double num1 = 0; //OPERADOR 1
        double num2 = 0; //OPERADOR 2

       
        private void btnCE_Click(object sender, EventArgs e)
        {
            // BOTÓN CLEAR: LIMPIA LA PANTALLA, se resetean los valores

            txtIngreso.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void btnBA_Click(object sender, EventArgs e)
        {
            // BOTÓN BACK: VUELVE HACIA ATRÁS, limpia 1 caracter
            try
            {
                if (txtIngreso.Text == "Error")
                {
                    txtIngreso.ForeColor = Color.Black;
                    txtIngreso.Text = "";
                }
                else if (txtIngreso.TextLength == 1)
                {
                    txtIngreso.Text = "0";
                }
                else
                {
                    // utilizo el método Substring para eliminar el último caracter
                    txtIngreso.Text = txtIngreso.Text.Substring(0, txtIngreso.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                txtIngreso.Text = "";
            }
            
        }

        private void btnUno_Click(object sender, EventArgs e)
        {

            if (txtIngreso.Text == "0" || txtIngreso.Text == "Error")
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }

            txtIngreso.Text = txtIngreso.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (txtIngreso.Text == "0" || txtIngreso.Text == "Error")
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }

            txtIngreso.Text = txtIngreso.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtIngreso.Text == "0" || txtIngreso.Text == "Error")
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }

            txtIngreso.Text = txtIngreso.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (txtIngreso.Text == "0" || txtIngreso.Text == "Error")
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }

            txtIngreso.Text = txtIngreso.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtIngreso.Text == "0" || txtIngreso.Text == "Error")
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }

            txtIngreso.Text = txtIngreso.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtIngreso.Text == "0" || txtIngreso.Text == "Error")
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }

            txtIngreso.Text = txtIngreso.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (txtIngreso.Text == "0" || txtIngreso.Text == "Error")
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }

            txtIngreso.Text = txtIngreso.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (txtIngreso.Text == "0" || txtIngreso.Text == "Error")
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }

            txtIngreso.Text = txtIngreso.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (txtIngreso.Text == "0" || txtIngreso.Text == "Error")
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }

            txtIngreso.Text = txtIngreso.Text + "9";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtIngreso.ForeColor = Color.Black;
            txtIngreso.Text = txtIngreso.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {

            if (txtIngreso.Text != "Error" && txtIngreso.Text != "")
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = txtIngreso.Text + ",";
            }
            
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "+";
                num1 = Convert.ToDouble(txtIngreso.Text);
                txtIngreso.Text = "";
            }
            catch (Exception ex)
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }
            

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "-";
                num1 = Convert.ToDouble(txtIngreso.Text);
                txtIngreso.Text = "";
            }
            catch (Exception ex)
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "*";
                num1 = Convert.ToDouble(txtIngreso.Text);
                txtIngreso.Text = "";
            }
            catch (Exception ex)
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "/";
                num1 = Convert.ToDouble(txtIngreso.Text);
                txtIngreso.Text = "";
            }
            catch (Exception ex)
            {
                txtIngreso.ForeColor = Color.Black;
                txtIngreso.Text = "";
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtIngreso.Text);

            switch (operador)
            {
                case "+":
                    txtIngreso.Text = $"{num1 + num2}";
                    break;

                case "-":
                    txtIngreso.Text = $"{num1 - num2}";
                    break;

                case "*":
                    txtIngreso.Text = $"{num1 * num2}";
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        txtIngreso.Text = $"{num1 / num2}";
                    }
                    else
                    {
                        txtIngreso.ForeColor = Color.Red;
                        txtIngreso.Text = "Error";           
                    }
                    
                    break;
                 
            }
        }

        //private bool NoOtraOcurrencia(char coma, TextBox txtIngreso)
        //{
        //    int contador = 0;

        //    foreach (char c in txtIngreso.Text)
        //    {
        //        if (c == coma)
        //        {
        //            contador++;
        //        }
        //    }

        //    // Si el contador es 1, significa que no hay otra ocurrencia del carácter
        //    return contador == 1;
        //}

    }
}

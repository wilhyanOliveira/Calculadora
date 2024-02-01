using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{

    public partial class Calculadora : Form
    {

        decimal calculo;
        bool resultado;
        bool adicao = false;
        bool subtracao = false;
        bool multiplica = false;
        bool divisao = false;
        bool raiz = false;
        bool porcentagem = false;
        
        public Calculadora()
        {
            InitializeComponent();
        }
        #region passagem de parametros dos botões numericos
        private void btnN0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
            txtOperacao.Text += "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
            txtOperacao.Text += "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
            txtOperacao.Text += "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
            txtOperacao.Text += "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
            txtOperacao.Text += "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
            txtOperacao.Text += "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
            txtOperacao.Text += "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
            txtOperacao.Text += "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
            txtOperacao.Text += "8";
        }

        private void BtnN9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
            txtOperacao.Text += "9";
        }
        #endregion

        #region Passagem de parametros botões de Operações
        private void btnAdicao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(txtResult.Text);

                txtOperacao.Text += "+";
                txtResult.Text = "";

                adicao = true;
                subtracao = false;
                multiplica = false;
                divisao = false;

            }
            catch (Exception) { }
        }
        private void btnSub_Click(object sender, EventArgs e)
        {

            try
            {
                calculo = Convert.ToDecimal(txtResult.Text);

                txtOperacao.Text += "-";
                txtResult.Text = "";

                subtracao = true;
                adicao = false;
                multiplica = false;
                divisao = false;
            }
            catch (Exception) { }
        }
        private void btnMultip_Click(object sender, EventArgs e)
        {

            try
            {
                calculo = Convert.ToDecimal(txtResult.Text);

                txtOperacao.Text += "X";
                txtResult.Text = "";

                multiplica = true;
                subtracao = false;
                adicao = false;
                divisao = false;
                raiz = false;

            }
            catch (Exception) { }
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {

                calculo = Convert.ToDecimal(txtResult.Text);

                txtOperacao.Text += "/";
                txtResult.Text = "";

                divisao = true;
                multiplica = false;
                subtracao = false;
                adicao = false;
                raiz = false;
                porcentagem = false;
            }
            catch (Exception) { }
        }
        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (subtracao == true)
            {
                try
                {
                    double valor1 = Convert.ToDouble(calculo);
                    double percentual = Convert.ToDouble(txtResult.Text) / 100;

                    txtResult.Text = Convert.ToString(valor1 - (percentual * valor1));

                    txtOperacao.Text += "% = ";
                    txtOperacao.Text += txtResult.Text;
                }
                catch (Exception) { }
            }

            if (adicao == true)
            {
                try
                {
                    double valor1 = Convert.ToDouble(calculo);
                    double percentual = Convert.ToDouble(txtResult.Text) / 100;

                    txtResult.Text = Convert.ToString(valor1 + (percentual * valor1));

                    txtOperacao.Text += "% = ";
                    txtOperacao.Text += txtResult.Text;
                }
                catch (Exception) { }
            }

            if (multiplica == true)
            {
                try
                {
                    double valor1 = Convert.ToDouble(calculo);
                    double percentual = Convert.ToDouble(txtResult.Text) / 100;

                    txtResult.Text = Convert.ToString(valor1 * (percentual * valor1));

                    txtOperacao.Text += "% = ";
                    txtOperacao.Text += txtResult.Text;
                }
                catch (Exception) { }
            }

            if (divisao == true)
            {
                try
                {
                    double valor1 = Convert.ToDouble(calculo);
                    double percentual = Convert.ToDouble(txtResult.Text) / 100;

                    txtResult.Text = Convert.ToString(valor1 / (percentual * valor1));

                    txtOperacao.Text += "% = ";
                    txtOperacao.Text += txtResult.Text;
                }
                catch (Exception) { }
            }
        }
        
        private void BtnRaiz_Click (object sender, EventArgs e)
        {

            try
            {
                double raiz = Convert.ToDouble(txtResult.Text);

                if (raiz < 0)
                {
                    MessageBox.Show("Valor invalido para operação");
                }
                else
                {
                    raiz = Math.Sqrt(raiz);

                    txtOperacao.Text = raiz.ToString();
                    
                }
            }
            catch (Exception) { }
        }
        #endregion

        private void btnIgual_Click(object sender, EventArgs e)
        {
            resultado = true;

            txtOperacao.Text = "=";

            decimal validador = Convert.ToDecimal(txtResult.Text);

            //verificador de operação com valor 0
            if (validador == 0 && calculo == 0 )
            {
                txtResult.Text = "";
                txtOperacao.Text = "";
                MessageBox.Show("Toda operação efetuada com valor 0 será igual a 0");
            }
            
            // calculos operações básicas
            try
            {

                if (adicao == true)
                {
                    txtResult.Text = Convert.ToString(Convert.ToDecimal(txtResult.Text) + calculo);
                }

                if (subtracao == true)
                {
                    txtResult.Text = Convert.ToString(Convert.ToDecimal(txtResult.Text) - calculo);
                }

                if (multiplica == true)
                {
                    txtResult.Text = Convert.ToString(Convert.ToDecimal(txtResult.Text) * calculo);
                }
                if (divisao == true)
                {
                    txtResult.Text = Convert.ToString(Convert.ToDecimal(txtResult.Text) / calculo);
                }
            }
            catch (Exception) { }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "";
            txtResult.Text += "";
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {

            if (txtResult.Text == "")
            {
                txtOperacao.Text += "0,";
                txtResult.Text += "0,";
            }
            else
            {
                txtOperacao.Text += ",";
                txtResult.Text += ",";
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            try
            {
                string apagar = txtResult.Text;
                apagar = apagar.Remove(apagar.Length - 1);

                txtResult.Text = apagar;
                txtOperacao.Text = apagar;
            }
            catch (Exception) { }
        }
    }
}


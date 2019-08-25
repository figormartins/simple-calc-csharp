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
    public partial class From_Calculadora : Form
    {
        public bool operacao_clicada = false;
        public double numero_inicial = 0;
        public bool mostrar_calculo = false;
        public double calculo = 0;
        public string operacao = "";

        public From_Calculadora()
        {
            InitializeComponent();
        }

        public void LerNumero(int numero_lido)
        {
            if (!operacao_clicada)
                tb_numero.Text += numero_lido;
            else
                tb_numero.Text = numero_lido.ToString();

            operacao_clicada = false;
        }

        public void CalcularMostrar()
        {
            if (operacao == "+")
                calculo = numero_inicial + double.Parse(tb_numero.Text);
            else if (operacao == "-")
                calculo = numero_inicial - double.Parse(tb_numero.Text);
            else if (operacao == "/")
                calculo = numero_inicial / double.Parse(tb_numero.Text);
            else if (operacao == "x")
                calculo = numero_inicial * double.Parse(tb_numero.Text);

            tb_numero.Text = calculo.ToString();
        }

        public void BotoesOperacao(string operacao)
        {
            operacao_clicada = true;

            if (mostrar_calculo)
                CalcularMostrar();

            this.operacao = operacao;
            numero_inicial = double.Parse(tb_numero.Text);
            mostrar_calculo = true;
        }

        private void Tb_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_zero_Click(object sender, EventArgs e)
        {
            LerNumero(0);
        }

        private void Btn_um_Click(object sender, EventArgs e)
        {
            LerNumero(1);
        }

        private void Btn_dois_Click(object sender, EventArgs e)
        {
            LerNumero(2);
        }

        private void Btn_tres_Click(object sender, EventArgs e)
        {
            LerNumero(3);
        }

        private void Tbn_quatro_Click(object sender, EventArgs e)
        {
            LerNumero(4);
        }

        private void Btn_cinco_Click(object sender, EventArgs e)
        {
            LerNumero(5);
        }

        private void Btn_seis_Click(object sender, EventArgs e)
        {
            LerNumero(6);
        }

        private void Btn_sete_Click(object sender, EventArgs e)
        {
            LerNumero(7);
        }

        private void Btn_oito_Click(object sender, EventArgs e)
        {
            LerNumero(8);
        }

        private void Tbn_nove_Click(object sender, EventArgs e)
        {
            LerNumero(9);
        }

        private void Btn_dividir_Click(object sender, EventArgs e)
        {
            BotoesOperacao("/");
        }

        private void Tbn_multiplicar_Click(object sender, EventArgs e)
        {
            BotoesOperacao("x");
        }

        private void Btn_subtrair_Click(object sender, EventArgs e)
        {
            BotoesOperacao("-");
        }

        private void Btn_somar_Click(object sender, EventArgs e)
        {
            BotoesOperacao("+");
        }

        private void Btn_backspace_Click(object sender, EventArgs e)
        {
            int tamanho = tb_numero.Text.Length;

            if (tamanho > 0)
                tb_numero.Text = tb_numero.Text.Substring(0, tamanho - 1);
        }

        private void Btn_ce_Click(object sender, EventArgs e)
        {
            tb_numero.Text = "";
            mostrar_calculo = false;
        }

        private void Btn_ponto_Click(object sender, EventArgs e)
        {
            tb_numero.Text += ".";
        }

        private void Btn_igual_Click(object sender, EventArgs e)
        {
            CalcularMostrar();
            mostrar_calculo = false;
        }
    }
}

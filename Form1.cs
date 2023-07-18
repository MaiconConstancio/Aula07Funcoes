using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula07Funcoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //criar minhas funções aqui

        void mostraMensagem()
        {
            MessageBox.Show("Olá, sejá bem-vindo!");
        }

        void mostraNome()
        {
            string nome = txtNome.Text;
            MessageBox.Show($"Olá {nome}");
        }

        void ConverteDinheiro(Label dimdim)
        {
            //double saldo;
            //double valor;

            //valor = Double.Parse(textBox1.Text); //Caixinha de texto
            //saldo = Double.Parse(lblDinheiro.Text.Replace("R$:", ""));  // É ONDE TA O R$ e converte em numero

            double valor = double.Parse(dimdim.Text.Replace("R$:", ""));

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostraMensagem();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            mostraNome();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConverteDinheiro();
        }
    }
}

using BibliotecaClass;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aula01
{
    public partial class FrmVariaves : Form
    {
        public FrmVariaves()
        {
            InitializeComponent();
        }

        private void btNumero_Click(object sender, EventArgs e)
        {
            int numero1 = 4, numero2 = 3;
            int soma = numero1 + numero2;
            int divisao = numero1 / numero2;
            int subtracao = numero1 - numero2;
            int multiplicacao = numero1 * numero2;
        }
        private void btTexto_Click(object sender, EventArgs e)
        {
            string nome = "RHAEL";
            string sobrenome = "ANDRADE";
            string idade = "31";
            string sexo = "MASCULINO";
            string cep = "6595-0000";
            string datacadastro = "07-02-2024";
        }
        private void btBoleean_Click(object sender, EventArgs e)
        {
            bool boleean = false; 
            if(boleean == true)
            {       
                //Mensagem de aviso para o usuario
                MessageBox.Show("Verdadeiro");
            }
            else
            {       
                //Mensagem de aviso para o usuario
                MessageBox.Show("Falso");
            }
        }
        private void btData_Click(object sender, EventArgs e)
        {
            DateTime dateAtual = DateTime.Now;//Data atual do sistema
            DateTime dateVencimento = DateTime.Parse("08-02-2024");//Data do vencimento de uma parcel
            /*Compara se a data do vencimento  
             * esta vencinda 
             * ex: se a data do vencimento dor menor que a 
             * data atual a parcela esta vencida
             */ 
            if (dateVencimento < dateAtual)
            {
                //Mensagem de aviso para o usuario
                MessageBox.Show("A parcela está vencida");
            }
            else
            {
                //Mensagem de aviso para o usuario
                MessageBox.Show("A parcela está em dias");
            }

        }
        private void btParImpar_Click(object sender, EventArgs e)
        {
            int resultado = int.Parse(txtParImpar.Text);
            if(resultado % 2 == 0)
            {
                MessageBox.Show("Par");
            }
            else
            {
                MessageBox.Show("Impar");
            }
        }
        private void btBemVindo_Click(object sender, EventArgs e)
        {
            int hora = int.Parse(txtBemVindo.Text);
            if(hora < 12)
            {
                MessageBox.Show("Bom Dia");
            }
            else if(hora < 18)
            {
                MessageBox.Show("Boa Tarde");
            }
            else
            {
                MessageBox.Show("Boa Noite");
            }
        }
        private void btMaior_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtN01.Text);
            int numero2 = int.Parse(txtN02.Text);
            int numero3 = int.Parse(txtN03.Text);
            int resuldo;

            if (numero1 > numero2 && numero1 > numero3)
            {
                resuldo = numero1;
            }
            else if (numero2 > numero3)
            {
                resuldo = numero2;
            }
            else
            {
                resuldo = numero3;
            }
            MessageBox.Show("O número maior é " + resuldo);
        }
        private void While_Click(object sender, EventArgs e)
        {
            int resulto = 10;
            int situacao = 0;
            /*Se resultado for verdaderio cai no while se não sair */
            while (resulto != situacao) 
            {
                situacao++;
            }
        }
        private void btFor_Click(object sender, EventArgs e)
        {
            int length = 15;
            for (int i = 0; i < length; i++)
            {
                if(i == 10)
                {
                    //condição
                    MessageBox.Show("Ok!");
                }
            }
        }
        private void btForCliente_Click(object sender, EventArgs e)
        {
            List<Cliente> listaDados = new List<Cliente>();
            for (int i = 0; i < 1000; i++)
            {
                Cliente cliente = new Cliente();
                cliente.codigo = (i + 1);
                cliente.nome = "CLIENTE " + (i + 1);
                cliente.sobreNome = "SILVA";
                cliente.sexo = true;
                cliente.serasa = false;
                cliente.endereco = "RUA TEFE";
                cliente.situacao = 1;
                cliente.dataCadastro = DateTime.Now;
                listaDados.Add(cliente);
            }

            dgvListaCliente.DataSource = listaDados;
        }
    }
}

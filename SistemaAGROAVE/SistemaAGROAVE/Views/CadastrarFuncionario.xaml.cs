﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SistemaAGROAVE.Models;


namespace SistemaAGROAVE.Views
{
    /// <summary>
    /// Lógica interna para CadastrarFuncionario.xaml
    /// </summary>
    public partial class CadastrarFuncionario : Window
    {
        public CadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtSalvar(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = txtNome.Text;
                funcionario.Rg = txtCpf.Text;
                funcionario.Cpf = txtRg.Text;
                funcionario.Telefone = txtTelefone.Text;
                funcionario.CarteiraTrabalho = txtCarteira.Text;
                funcionario.Funcao = txtFuncao.Text;
                funcionario.Setor = txtSetor.Text;
                funcionario.Numero = txtNumero.Text;
                funcionario.Rua = txtRua.Text;
                funcionario.Bairro = txtBairro.Text;
                funcionario.Municipio = txtMunicipio.Text;
                funcionario.Estado = txtEstado1.Text;
                funcionario.Salario = Convert.ToDouble(txtSalario.Text);

                FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                funcionarioDAO.Insert(funcionario);

                MessageBox.Show("O funcionário foi adicionado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
               var result = MessageBox.Show("Deseja continuar?","", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(result == MessageBoxResult.No)
                {
                    this.Close();
                }
                else
                {
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    txtRg.Text = "";
                    txtTelefone.Text = "";
                    txtCarteira.Text = "";
                    txtFuncao.Text ="";
                    txtSetor.Text = "";
                    txtNumero.Text = "";
                    txtRua.Text = "";
                    txtBairro.Text = "";
                    txtMunicipio.Text = "";
                    txtEstado1.Text = "";
                    txtSalario.Text = "";
                }
            }
            catch (Exception ex)
            { 

                MessageBox.Show(ex.Message,"Não Executado", MessageBoxButton.OK,MessageBoxImage.Error);

            }





        }
    }
}

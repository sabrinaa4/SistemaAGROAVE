using System;
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


        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = txtNome.Text;
                funcionario.Rg = txtRg.Text;
                funcionario.Cpf = txtCpf.Text;
                funcionario.Telefone = txtTelefone.Text;
                funcionario.CarteiraTrabalho = txtCarteiraTrabalho.Text;
                funcionario.Funcao = txtFuncao.Text;
                funcionario.Setor = txtSetor.Text;
                funcionario.Numero = txtNumero.Text;
                funcionario.Rua = txtRua.Text;
                funcionario.Bairro = txtBairro.Text;
                funcionario.Municipio = txtMunicipio.Text;
                funcionario.Estado = cbEstado.Text;
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
                    txtRg.Text = "";
                    txtCpf.Text = "";
                    txtTelefone.Text = "";
                    txtCarteiraTrabalho.Text = "";
                    txtFuncao.Text ="";
                    txtSetor.Text = "";
                    txtNumero.Text = "";
                    txtRua.Text = "";
                    txtBairro.Text = "";
                    txtMunicipio.Text = "";
                    cbEstado.Text = "";
                    txtSalario.Text = "";
                }
            }
            catch (Exception ex)
            { 

                MessageBox.Show(ex.Message,"Não Executado", MessageBoxButton.OK,MessageBoxImage.Error);

            }
        }

        private void btnConsultarFun_Click(object sender, RoutedEventArgs e)
        {
            ConsultarFuncionario form = new ConsultarFuncionario();
            form.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Cadastrar Funcionário", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Cancelar?", "App - Cadastrar Funcionário", MessageBoxButton.YesNo, MessageBoxImage.Question);

            txtNome.Text = " ";
            txtRg.Text = " ";
            txtCpf.Text = " ";
            txtTelefone.Text = " ";
            txtCarteiraTrabalho.Text = " ";
            txtFuncao.Text = " ";
            txtSetor.Text = " ";
            txtNumero.Text = " ";
            txtRua.Text = " ";
            txtBairro.Text = " ";
            txtMunicipio.Text = " ";
            cbEstado.Text = " ";
        }
    }
}

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
    /// Lógica interna para CadastrarFornecedor.xaml
    /// </summary>
    public partial class CadastrarFornecedor : Window
    {
        public CadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.NomeFantasia = txtNomeFant.Text;
                fornecedor.RazaoSocial = txtRazao.Text;
                fornecedor.Cnpj = txtCnpj.Text;
                fornecedor.Telefone = txtTelefone.Text;
                fornecedor.Email = txtEmail.Text;
                fornecedor.Numero = txtNumero.Text;
                fornecedor.Rua = txtRua.Text;
                fornecedor.Bairro = txtBairro.Text;
                fornecedor.Municipio = txtMunicipio.Text;
                fornecedor.Estado = cbEstado.Text;

                FornecedorDAO funcionarioDAO = new FornecedorDAO();
                funcionarioDAO.Insert(fornecedor);

                MessageBox.Show("O fornecedor foi adicionado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }
                else
                {
                    txtNomeFant.Text = ";";
                    txtRazao.Text = ";";
                    txtCnpj.Text = ";";
                    txtTelefone.Text = ";";
                    txtEmail.Text = ";";
                    txtNumero.Text = ";";
                    txtRua.Text = ";";
                    txtBairro.Text = ";";
                    txtMunicipio.Text = ";";
                    cbEstado.Text = ";";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }

        private void btnConsultarFor_Click(object sender, RoutedEventArgs e)
        {
            ConsultarFornecedor form = new ConsultarFornecedor();
            form.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Cancelar?", "App - Cadastrar Fornecedor", MessageBoxButton.YesNo, MessageBoxImage.Question);

            txtNomeFant.Text = " ";
            txtRazao.Text = " ";
            txtCnpj.Text = " ";
            txtTelefone.Text = " ";
            txtEmail.Text = " ";
            txtNumero.Text = " ";
            txtRua.Text = " ";
            txtBairro.Text = " ";
            txtMunicipio.Text = " ";
            cbEstado.Text = " ";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Cadastrar Fornecedor", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }
    }
}

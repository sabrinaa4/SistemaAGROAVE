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
    /// Lógica interna para CadastrarCliente.xaml
    /// </summary>
    public partial class CadastrarCliente : Window
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = txtNome.Text;
                cliente.Email = txtEmail.Text;
                cliente.Cpf = txtCpf.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Numero = Convert.ToInt16(txtNumero.Text);
                cliente.Rua = txtRua.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Municipio = txtMunicipio.Text;
                cliente.Estado = cbEstado.Text;
               
                ClienteDAO clienteDAO = new ClienteDAO();
                clienteDAO.Insert(cliente);
                
                MessageBox.Show("O cliente foi adicionado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }
                else
                {
                    txtNome.Text = "";
                    txtEmail.Text = "";
                    txtCpf.Text = "";
                    txtTelefone.Text = "";
                    txtNumero.Text = "";
                    txtRua.Text = "";
                    txtBairro.Text = "";
                    txtMunicipio.Text = "";
                    cbEstado.Text = "";
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void btnConsultarCli_Click(object sender, RoutedEventArgs e)
        {
            ConsultarCliente form = new ConsultarCliente();
            form.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Cancelar?", "App - Cadastrar Cliente - Jurídico", MessageBoxButton.YesNo, MessageBoxImage.Question);

            txtNome.Text = "";
            txtEmail.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtNumero.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtMunicipio.Text = "";
            cbEstado.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Cadastrar Cliente - Jurídico", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

    }
}

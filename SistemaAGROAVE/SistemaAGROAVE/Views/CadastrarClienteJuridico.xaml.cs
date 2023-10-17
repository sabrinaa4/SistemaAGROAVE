using SistemaAGROAVE.Models;
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

namespace SistemaAGROAVE.Views
{
    /// <summary>
    /// Lógica interna para CadastrarClienteJuridico.xaml
    /// </summary>
    public partial class CadastrarClienteJuridico : Window
    {
        public CadastrarClienteJuridico()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Cadastrar Cliente - Jurídico", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                ClienteJuridico clienteJuridico = new ClienteJuridico();
                clienteJuridico.NomeFantasia = txtNomeFantasia.Text;
                clienteJuridico.Email = txtEmail.Text;
                clienteJuridico.Cnpj = txtCnpj.Text;
                clienteJuridico.Telefone = txtTelefone.Text;
                clienteJuridico.Numero = Convert.ToInt16(txtNumero.Text);
                clienteJuridico.Rua = txtRua.Text;
                clienteJuridico.Bairro = txtBairro.Text;
                clienteJuridico.Municipio = txtMunicipio.Text;
                clienteJuridico.Estado = cbEstado.Text;

                ClienteJuridicoDAO clienteJuridicoDAO = new ClienteJuridicoDAO();
                clienteJuridicoDAO.Insert(clienteJuridico);

                MessageBox.Show("O cliente foi adicionado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }
                else
                {
                    txtNomeFantasia.Text = "";
                    txtEmail.Text = "";
                    txtCnpj.Text = "";
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Cancelar?", "App - Cadastrar Cliente - Jurídico", MessageBoxButton.YesNo, MessageBoxImage.Question);

            txtNomeFantasia.Text = "";
            txtEmail.Text = "";
            txtCnpj.Text = "";
            txtTelefone.Text = "";
            txtNumero.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtMunicipio.Text = "";
            cbEstado.Text = "";
        }

        private void btnConsultarCli_Click(object sender, RoutedEventArgs e)
        {
            ConsultarClienteJuridico form = new ConsultarClienteJuridico();
            form.ShowDialog();
        }
    }
}

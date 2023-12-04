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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace SistemaAGROAVE.Views
{
    /// <summary>
    /// Lógica interna para CadastrarEntrega.xaml
    /// </summary>
    public partial class CadastrarEntrega : Window
    {
        public CadastrarEntrega()
        {
            InitializeComponent();
        }

        private void btnConsultarEnt_Click(object sender, RoutedEventArgs e)
        {
            ConsultarEntrega form = new ConsultarEntrega();
            form.ShowDialog();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Entrega entrega = new Entrega();
                entrega.Nome = txtNome.Text;
                entrega.Status = txtStatus.Text;
                entrega.Taxa = Convert.ToDouble(txtTaxa.Text);
                entrega.ValorTroco = Convert.ToDouble(txtValorTroco.Text);
                entrega.Hora = txtHora.Text;
                entrega.NumCasa = Convert.ToInt16(txtNumero.Text);
                entrega.Rua = txtRua.Text;
                entrega.Bairro = txtBairro.Text;
                entrega.Municipio = txtMunicipio.Text;
                entrega.Estado = cbEstado.Text;


                EntregaDAO entregaDAO = new EntregaDAO();
                entregaDAO.Insert(entrega);

                MessageBox.Show("A entrega foi cadastrada com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }

                else
                {
                    txtNome.Text = "";
                    txtStatus.Text = "";
                    txtTaxa.Text = "";
                    txtValorTroco.Text = "";
                    txtHora.Text = "";
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

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Deseja realmente Cancelar?", "App - Cadastrar Entrega", MessageBoxButton.YesNo, MessageBoxImage.Question);

            txtNome.Text = "";
            txtStatus.Text = "";
            txtTaxa.Text = "";
            txtValorTroco.Text = "";
            txtHora.Text = "";
            txtNumero.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtMunicipio.Text = "";
            cbEstado.Text = "";
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Cadastrar Entrega", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }
    }
}

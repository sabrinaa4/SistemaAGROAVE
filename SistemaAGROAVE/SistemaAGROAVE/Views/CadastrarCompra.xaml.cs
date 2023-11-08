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
    /// Lógica interna para CadastrarCompra.xaml
    /// </summary>
    public partial class CadastrarCompra : Window
    {
        public CadastrarCompra()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {

            ConsultarCompra form = new ConsultarCompra();
            form.ShowDialog();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Compra compra = new Compra();
                compra.Valor = Convert.ToDouble(txtValor.Text);
                compra.TipoPag = txtTipoPag.Text;
                compra.Descricao = txtDescricao.Text;
                compra.Data = txtData.Text;
                compra.Hora = txtHora.Text;
                //compra.Fornecedor = cbFornecedor.Text;
                //compra.Despesa = cbDespesa.Text;


                CompraDAO compraDAO = new CompraDAO();
                compraDAO.Insert(compra);

                MessageBox.Show("A compra foi cadastrada com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }

                else
                {
                    txtValor.Text = "";
                    txtTipoPag.Text = "";
                    txtDescricao.Text = "";
                    txtUnidade.Text = "";
                    txtData.Text = "";
                    txtHora.Text = "";
                    txtDespesa.Text = "";
                    txtFornecedor.Text = "";
                    //cbDespesa.Text = "";
                    //cbFornecedor.Text = "";
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Cadastrar Compra", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Cancelar?", "App - Cadastrar Compra", MessageBoxButton.YesNo, MessageBoxImage.Question);

            txtValor.Text = "";
            txtTipoPag.Text = "";
            txtDescricao.Text = "";
            txtUnidade.Text = "";
            txtData.Text = "";
            txtHora.Text = "";
            txtDespesa.Text = "";
            txtFornecedor.Text = "";
            //cbDespesa.Text = "";
            //cbFornecedor.Text = "";
        }
    }
}

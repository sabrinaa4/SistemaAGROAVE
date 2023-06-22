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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using SistemaAGROAVE.Models;

namespace SistemaAGROAVE.Views
{
    /// <summary>
    /// Lógica interna para CadastrarProduto.xaml
    /// </summary>
    public partial class CadastrarProduto : Window
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               Produto produto = new Produto();
                produto.Nome = txtNome1.Text;
                produto.Descricao = txtDescricao.Text;
                produto.DataFabricacao = txtDataFab.Text;
                produto.DataVencimento = txtDataVal.Text;
                produto.Codigo = txtCodigo.Text;
                produto.Origem = txtOrigem.Text;
                produto.Valor = Convert.ToDouble(txtValor.Text);
               
               

                ProdutoDAO produtoDAO = new ProdutoDAO();
                produtoDAO.Insert(produto);

                MessageBox.Show("O produto foi adicionado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }
                else
                {
                    txtNome1.Text = "";
                    txtDescricao.Text = "";
                    txtDataFab.Text = "";
                    txtDataVal.Text = "";
                    txtCodigo.Text = "";
                    txtOrigem.Text = "";
                    txtValor.Text = "";
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }





        }

        private void btnConsutarProd_Click(object sender, RoutedEventArgs e)
        {
            ConsultarProduto form = new ConsultarProduto();
            form.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Cancelar?", "App - Cadastrar Produto", MessageBoxButton.YesNo, MessageBoxImage.Question);

            txtNome1.Text = "";
            txtDescricao.Text = "";
            txtDataFab.Text = "";
            txtDataVal.Text = "";
            txtCodigo.Text = "";
            txtOrigem.Text = "";
            txtValor.Text = ""; ;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Cadastrar Produto", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }
    }
}

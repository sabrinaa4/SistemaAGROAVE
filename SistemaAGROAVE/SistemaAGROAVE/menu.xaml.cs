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
using SistemaAGROAVE.Interface;
using SistemaAGROAVE.Views;

namespace SistemaAGROAVE
{
    /// <summary>
    /// Lógica interna para menu.xaml
    /// </summary>
    public partial class menu : Window
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnCadastrarFun_Click(object sender, RoutedEventArgs e)
        {
            FuncionarioEscolher form = new FuncionarioEscolher();
            form.ShowDialog();
        }

        private void btnCadastrarProd_Click(object sender, RoutedEventArgs e)
        {
            CadastrarProduto form = new CadastrarProduto();
            form.ShowDialog();
        }

        private void btnCadastrarFor_Click(object sender, RoutedEventArgs e)
        {
            CadastrarFornecedor form = new CadastrarFornecedor();
            form.ShowDialog();
        }

        private void btnDespesa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            CadastrarClienteEscolher form = new CadastrarClienteEscolher();
            form.ShowDialog();
        }

        private void btnCadastrarPro_Click(object sender, RoutedEventArgs e)
        {
            RegistrarProducao form = new RegistrarProducao();
            form.ShowDialog();
        }

        private void btnCadastrarAve_Click(object sender, RoutedEventArgs e)
        {
            RegistrarAves form = new RegistrarAves();
            form.ShowDialog();
        }

        private void btnVoltar(object sender, RoutedEventArgs e) {
            //MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - AGROAVE", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //if (result == MessageBoxResult.Yes)
            //    this.Close();
        }

        private void btnCadastrarCai_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCaixa form = new CadastrarCaixa();
            form.ShowDialog();
        }
    }
}

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
            CadastrarFuncionario form = new CadastrarFuncionario();
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
            CadastrarCliente form = new CadastrarCliente();
            form.ShowDialog();
        }

        private void btnCadastrarPro_Click(object sender, RoutedEventArgs e)
        {
            CadastrarProduto form = new CadastrarProduto();
            form.ShowDialog();
        }

        private void btnCadastrarAve_Click(object sender, RoutedEventArgs e)
        {
            RegistrarAves form = new RegistrarAves();
            form.ShowDialog();
        }
    }
}

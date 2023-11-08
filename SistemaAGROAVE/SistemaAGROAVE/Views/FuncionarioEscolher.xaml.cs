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
    /// Lógica interna para FuncionarioEscolher.xaml
    /// </summary>
    public partial class FuncionarioEscolher : Window
    {
        public FuncionarioEscolher()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Cadastrar Cliente", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void btAvancar(object sender, RoutedEventArgs e)
        {
            if (RbTipoCadastrar.IsChecked == true)
            {
                this.Close();
                var formulario = new CadastrarFuncionario();
                formulario.ShowDialog();
            }
            else if (RbTipoControlar.IsChecked == true)
            {
                this.Close();
                var formulario = new ControlarPerfilFuncionario();
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma opção!");
            }
        }
    }
}

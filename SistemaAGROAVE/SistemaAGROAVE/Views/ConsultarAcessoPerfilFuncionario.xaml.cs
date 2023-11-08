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
    /// Lógica interna para ConsultarAcessoPerfilFuncionario.xaml
    /// </summary>
    public partial class ConsultarAcessoPerfilFuncionario : Window
    {
        public ConsultarAcessoPerfilFuncionario()
        {
            InitializeComponent();
            Loaded += ConsultarAcessoPerfilFuncionario_Loaded;
        }

        private void ConsultarAcessoPerfilFuncionario_Loaded(object sender, RoutedEventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            try
            {
                var dao = new PerfilFuncionarioDAO();

                dataGridPerfilFuncionario.ItemsSource = dao.List();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Execeção", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

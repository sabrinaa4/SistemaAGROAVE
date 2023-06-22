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
    /// Lógica interna para ConsultarFornecedor.xaml
    /// </summary>
    public partial class ConsultarFornecedor : Window
    {
        public ConsultarFornecedor()
        {
            InitializeComponent();
            Loaded += ConsultarFornecedor_Loaded;
        }

        private void ConsultarFornecedor_Loaded(object sender, RoutedEventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            try
            {
                var dao = new FornecedorDAO();

                dataGridFornecedor.ItemsSource = dao.List();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Execeção", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

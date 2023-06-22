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
    /// Lógica interna para ConsultarAves.xaml
    /// </summary>
    public partial class ConsultarAves : Window
    {
        public ConsultarAves()
        {
            InitializeComponent();
            Loaded += ConsultarAves_Loaded;
        }

        private void ConsultarAves_Loaded(object sender, RoutedEventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            try
            {
                var dao = new AvesDAO();

                dataGridAves.ItemsSource= dao.List();
                

                

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Execeção", MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

    }
}

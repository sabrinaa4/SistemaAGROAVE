//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Shapes;
//using SistemaAGROAVE.Models;


//namespace SistemaAGROAVE.Views
//{
//    /// <summary>
//    /// Lógica interna para ConsultarAves.xaml
//    /// </summary>
//    public partial class ConsultarAves : Window
//    {
//    //    public ConsultarAves()
//    //    {
//    //        InitializeComponent();
//    //        ListaAves();
//    //    }

//    //    public void ListaAves(){
//    //        CarregarListagem();
//    //    }

//    //    private void CarregarListagem()
//    //    {
//    //        try
//    //        {
//    //            var dao = new AvesDAO();
//    //            List<Aves> listaAves = dao.List();

//    //            dataGridAves.ItemsSource = listaAves;
//    //        }
//    //        catch (Exception ex)
//    //        {
//    //            MessageBox.Show(ex.Message, "Falha na listagem");
//    //        }
//    //    }

//    //    private void Button_Click(object sender, RoutedEventArgs e)
//    //    {
//    //        var aveSelecionada = dataGridAves.SelectedItem as aveSelecionada;

//    //        var resultado = MessageBox.Show($"Deseja realmente excluir '{aveSelecionada.Observacao}' ?", "Confirmação de Exclusão",
//    //            MessageBoxButton.YesNo, MessageBoxImage.Warning);

//    //        try
//    //        {
//    //            if (resultado == MessageBoxResult.Yes)
//    //            {
//    //                var dao = new AvesDAO();
//    //                dao.Delete(aveSelecionada);

//    //                MessageBox.Show("Registro Apagado!");
//    //            }
//    //            CarregarListagem();
//    //        }
//    //        catch (Exception ex)
//    //        {
//    //            throw ex;
//    //        }
//    //    }
//    //}
//}

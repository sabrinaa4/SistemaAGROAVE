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
using SistemaAGROAVE.DataBase;
using SistemaAGROAVE.Interface;
using SistemaAGROAVE.Properties;

namespace SistemaAGROAVE.Views
{
    /// <summary>
    /// Lógica interna para RegistrarAves.xaml
    /// </summary>
    public partial class RegistrarAves : Window
    {
        public RegistrarAves()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                Aves aves = new Aves();
                aves.Observacoes = txtObservacao.Text;
                aves.CorIdentificacao = cbCor.Text;
                aves.QuantObito = Convert.ToInt16(txtQtdMortes.Text);
                aves.Raca = txtRaca.Text;
                aves.DataEntrada = txtDataEntrada.Text;
                aves.Lote = txtLote.Text;
                aves.NumeroGalpao = Convert.ToInt16(txtGalpao.Text);
                

                AvesDAO avesDAO = new AvesDAO();
                avesDAO.Insert(aves);

                MessageBox.Show("O funcionário foi adicionado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }
                else
                {
                    txtObservacao.Text = "";
                    cbCor.Text = "";
                    txtQtdMortes.Text = "";
                    txtRaca.Text = "";
                    txtDataEntrada.Text = "";
                    txtLote.Text = "";
                    txtGalpao.Text = "";

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Registro de Aves", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Cancelar?", "App - Registro de Aves", MessageBoxButton.YesNo, MessageBoxImage.Question);

            txtObservacao.Text = "";
            cbCor.Text = "";
            txtQtdMortes.Text = "";
            txtRaca.Text = "";
            txtDataEntrada.Text = "";
            txtLote.Text = "";
            txtGalpao.Text = "";
        }

        private void btnConsultarAves_Click(object sender, RoutedEventArgs e)
        {
            ConsultarAves form = new ConsultarAves();
            form.ShowDialog();
        }
    }
}

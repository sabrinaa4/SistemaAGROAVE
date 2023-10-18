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
    /// Lógica interna para RegistrarProducao.xaml
    /// </summary>
    public partial class RegistrarProducao : Window
    {
        public RegistrarProducao()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Producao producao = new Producao();
                producao.Nome = txtNomee.Text;
                producao.Quantidade = txtQuantidade.Text;
                producao.Data = txtData.Text;
                producao.Descricao = txtDescricao.Text;
                producao.ProducaoDiaria = txtProducaoDiaria.Text;
                producao.ProducaoSemanal = txtProducaoSemanal.Text;
                producao.ProducaoMensal = txtProducaoMensal.Text;
                producao.ProducaoEsperada = txtProducaoEsperada.Text;
                producao.ProducaoReal = txtProducaoReal.Text;

                ProducaoDAO producaoDAO = new ProducaoDAO();
                producaoDAO.Insert(producao);

                MessageBox.Show("O cliente foi adicionado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }
                else
                {
                    txtNomee.Text = "";
                    txtQuantidade.Text = "";
                    txtData.Text = "";
                    txtDescricao.Text = "";
                    txtProducaoDiaria.Text = "";
                    txtProducaoSemanal.Text = "";
                    txtProducaoMensal.Text = "";
                    txtProducaoEsperada.Text = "";
                    txtProducaoReal.Text = "";

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Cancelar?", "App - Registrar Produção", MessageBoxButton.YesNo, MessageBoxImage.Question);

            txtNomee.Text = "";
            txtQuantidade.Text = "";
            txtData.Text = "";
            txtDescricao.Text = "";
            txtProducaoDiaria.Text = "";
            txtProducaoSemanal.Text = "";
            txtProducaoMensal.Text = "";
            txtProducaoEsperada.Text = "";
            txtProducaoReal.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Registrar Produção", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void btnConsutarProd_Click(object sender, RoutedEventArgs e)
        {
            ConsultarProducao form = new ConsultarProducao();
            form.ShowDialog();
        }
    }
}

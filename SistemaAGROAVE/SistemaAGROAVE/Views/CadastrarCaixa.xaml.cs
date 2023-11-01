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

namespace SistemaAGROAVE.Views
{
    /// <summary>
    /// Lógica interna para CadastrarCaixa.xaml
    /// </summary>
    public partial class CadastrarCaixa : Window
    {
        public CadastrarCaixa()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Caixa caixa = new Caixa();
                caixa.Numero = Convert.ToInt16(txtNumero.Text);
                caixa.Data = txtData.Text;
                caixa.HoraAbertura = txtHoraAbertura.Text;
                caixa.HoraFechamento = txtHoraFechamento.Text;
                caixa.ValorInicial = Convert.ToDouble(txtValorInicial.Text);
                caixa.ValorFinal = Convert.ToDouble(txtValorFinal.Text);
                caixa.Funcionario = cbFuncionario.Text;

                CaixaDAO caixaDAO = new CaixaDAO();
                caixaDAO.Insert(caixa);

                MessageBox.Show("O caixa foi cadastrado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }

                else
                {
                    txtNumero.Text = "";
                    txtData.Text = "";
                    txtHoraAbertura.Text = "";
                    txtHoraFechamento.Text = "";
                    txtValorInicial.Text = "";
                    txtValorFinal.Text = "";
                    cbFuncionario.Text = "";
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Cancelar?", "App - Cadastrar Caixa", MessageBoxButton.YesNo, MessageBoxImage.Question);

            txtNumero.Text = "";
            txtData.Text = "";
            txtHoraAbertura.Text = "";
            txtHoraFechamento.Text = "";
            txtValorInicial.Text = "";
            txtValorFinal.Text = "";
            cbFuncionario.Text = "";
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Cadastrar Caixa", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void cbFuncionario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            if (cbFuncionario.SelectedItem.ToString() == "Consulta de Funcionário")
            {
                CadastrarFuncionario employeeQueryPage = new CadastrarFuncionario();
                employeeQueryPage.Show();
            }
        }
    }
}
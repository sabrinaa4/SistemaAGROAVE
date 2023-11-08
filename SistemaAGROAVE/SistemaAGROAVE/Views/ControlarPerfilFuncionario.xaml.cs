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
    /// Lógica interna para ControlarPerfilFuncionario.xaml
    /// </summary>
    public partial class ControlarPerfilFuncionario : Window
    {
        public ControlarPerfilFuncionario()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PerfilFuncionario perfilFuncionario = new PerfilFuncionario();
                perfilFuncionario.Nome = txtNome.Text;
                perfilFuncionario.Cpf = txtCpf.Text;
                perfilFuncionario.Telefone = txtTelefone.Text;
                perfilFuncionario.Rg = txtRg.Text;
                perfilFuncionario.Email = txtEmail.Text;
                perfilFuncionario.Funcao = cbFuncao.Text;
                perfilFuncionario.Setor = txtSetor.Text;

                PerfilFuncionarioDAO perfilFuncionarioDAO = new PerfilFuncionarioDAO();
                perfilFuncionarioDAO.Insert(perfilFuncionario);

                MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }

                else
                {
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    txtTelefone.Text = "";
                    txtRg.Text = "";
                    txtEmail.Text = "";
                    cbFuncao.Text = "";
                    txtSetor.Text = "";
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Cancelar?", "App - Controlar Acesso de Perfil do Funcionário", MessageBoxButton.YesNo, MessageBoxImage.Question);

            txtNome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtRg.Text = "";
            txtEmail.Text = "";
            cbFuncao.Text = "";
            txtSetor.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja realmente Voltar?", "App - Controlar Acesso de Perfil do Funcionário", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void btnConsultarPerfilFuncionario_Click(object sender, RoutedEventArgs e)
        {
            ConsultarAcessoPerfilFuncionario form = new ConsultarAcessoPerfilFuncionario();
            form.ShowDialog();
        }
    }
}

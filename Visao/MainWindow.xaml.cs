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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Visao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, RoutedEventArgs e)
        {

            new Negocio.Contato().Insert(new Modelo.Contato
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Fone = txtFone.Text
            });               
        }

        private void buttonListar_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = new Negocio.Contato().Select();
        }
    }
}

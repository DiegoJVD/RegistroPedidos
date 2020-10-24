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
using RegistroPedidos.UI.Registro;
using RegistroPedidos.UI.Consulta;

namespace RegistroPedidos
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

        public void rOrdenesMenuItem_CLick(object render, RoutedEventArgs e)
        {
            rOrdenes registroOrdenes = new rOrdenes();
            registroOrdenes.Show();
        }
         public void cOrdenesMenuItem_CLick(object render, RoutedEventArgs e)
        {
            cOrdenes ConsultaOrdenes = new cOrdenes();
            ConsultaOrdenes.Show();
        }

    }

        
}

using System;
using System.Windows;
using RegistroPedidos.DAL;
using RegistroPedidos.Entidades;
using RegistroPedidos.BLL;
using RegistroPedidos.UI.Consulta;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RegistroPedidos.UI.Consulta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class cOrdenes : Window
    {
        public cOrdenes()
        {
            InitializeComponent();
            
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            
             var listado = new List<Ordenes>();

            
            
                listado = OrdenesBLL.GetList(c => true);         

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        } 
        public int ToInt(string valor)
        {
            int retorno = 0;

            int.TryParse(valor,out retorno);

            return retorno;
        }



    }
}

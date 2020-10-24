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

        // private void BuscarButton_Click(object sender, RoutedEventArgs e)
        // {
            
        //      var listado = new List<Personas>();

        //     if (CriterioTextBox.Text.Trim().Length > 0)
        //     {
        //         switch (FiltroComboBox.SelectedIndex)
        //         {
        //             case 0: 
        //                 listado = PersonaBLL.GetList(e => e.PersonaId == this.ToInt(CriterioTextBox.Text));
        //                 break;

        //             case 1:    
        //                 listado = PersonaBLL.GetList(e => e.Nombres == this. CriterioTextBox.Text);
        //                 break;
        //         }
        //     }
        //     else
        //     {
        //         listado = PersonaBLL.GetList(c => true);
        //     }          

        //     DatosDataGrid.ItemsSource = null;
        //     DatosDataGrid.ItemsSource = listado;
        // } 
        // public int ToInt(string valor)
        // {
        //     int retorno = 0;

        //     int.TryParse(valor,out retorno);

        //     return retorno;
        // }



    }
}

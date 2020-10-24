using System.Windows;
using RegistroPedidos.Entidades;
using RegistroPedidos.BLL;
using System.Linq;
using System.Windows.Documents;
using System.Collections.Generic;
using System;
using RegistroPedidos.UI.Registro;


namespace RegistroPedidos.UI.Registro
{
    public partial class rOrdenes : Window 
    {
        Ordenes orden;
        public rOrdenes(){
            InitializeComponent();
            orden = new Ordenes();
            this.DataContext = orden;

            // ProductoComboBox.ItemsSource = ProductosBLL.GetList(p => true);
            // ProductoComboBox.SelectedValuePath = "PrestamoId ";
            // ProductoComboBox.DisplayMemberPath = "Concepto";
        }

        private void Limpiar()
        {
            orden = new Ordenes();
            Actualizar();
        }

        private void Actualizar()
        {
            this.DataContext = null;
            this.DataContext = orden;
        }

        private bool ExisteDB()
        {
            orden= OrdenesBLL.Buscar(orden.OrdenId);

            return (orden != null);
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
         {
        //     orden anterior = MorasBLL.Buscar(Utilidades.ToInt(IdTextBox.Text));

        //     if(anterior != null)
        //     {
        //         mora = anterior;
        //         Actualizar();
        //     }
        //     else
        //     {
        //         MessageBox.Show("Mora no encontrada.", "Error al buscar Mora");
        //     }
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            if(!ValidarDetalle()){
                return;
            }
                
             
                OrdenesDetalle detalle = new OrdenesDetalle(
                orden.OrdenId,
                Convert.ToInt32(ProductoComboBox.SelectedValue.ToString()),
                Utilidades.ToInt(CantidadTextBox.Text),
                Convert.ToDecimal(CostoTextBox.Text)

               // DetalleDataGrid.row
           );

            orden.Detalle.Add(detalle);
            //orden.Total += detalle.Valor;

            Actualizar();

            // PrestamoComboBox.SelectedIndex = -1;
            // ValorTextBox.Clear();
            CostoTextBox.Clear();
            CantidadTextBox.Clear();
        }

        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {
            // if(DetalleDataGrid.Items.Count > 0 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            // {
            //     MorasDetalle detalle = (MorasDetalle)DetalleDataGrid.SelectedItem;

            //     mora.Total -= detalle.Valor;
            //     mora.Detalle.Remove(detalle);
                
            //     Actualizar();
            // }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if(!ValidarMora())
                return;

            bool paso = false;

            //if (string.IsNullOrWhiteSpace(IdTextBox.Text) || IdTextBox.Text == "0")
                paso = OrdenesBLL.Guardar(orden);

           
            // else
            // {
            //     if(!ExisteDB())
            //     {
            //         MessageBox.Show("  porque no existe.", "Error al modificar ", MessageBoxButton.OK, MessageBoxImage.Error);
            //         return;
            //     }

            //     paso = MorasBLL.Modificar(mora);
            // }

            if(paso)
            {
                Limpiar();
                MessageBox.Show("Mora guardada ", "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Revise los datos e intente de nuevo", "Error al Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            // if( paso){
            // var prestamo = PrestamoBLL.Buscar(Convert.ToInt32(PrestamoComboBox.SelectedValue.ToString()));

            // foreach (var item in mora.Detalle)
            // {
            //         MorasDetalle detalle =  new MorasDetalle(
            //             mora.MoraId,
            //             Convert.ToInt32(PrestamoComboBox.SelectedValue.ToString()),
            //             Convert.ToInt32(ValorTextBox.Text) 
            //         );

            //         mora.Detalle.Add(detalle);
            //         mora.Total += detalle.Valor;

            //         prestamo.Balance += Convert.ToInt32(ValorTextBox.Text);
            //         PrestamoBLL.Guardar(prestamo);
            //         Actualizar();
            // }
            // }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            // int id = Utilidades.ToInt(IdTextBox.Text);

            // Limpiar();

            // if (MorasBLL.Eliminar(id))
            //     MessageBox.Show("Mora eliminada", "Registro de moras", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }

        private bool ValidarDetalle()
        {
            // if(!ValorTextBox.Text.All(char.IsNumber))
            // {
            //     MessageBox.Show("Ingrese un valor válido e intente de nuevo", "Registro de moras", MessageBoxButton.OK, MessageBoxImage.Error);
            //     return false;
            // }

            //  if( ValorTextBox.Text.Length  == 0){
            //       MessageBox.Show("Ingrese un valor e intente de nuevo", "Registro de moras", MessageBoxButton.OK, MessageBoxImage.Error);
            //     return false;
            //  }

            // if(ProductoComboBox.SelectedIndex < 0)
            // {
            //     MessageBox.Show("Seleccione un préstamo e intente de nuevo", "Registro de moras", MessageBoxButton.OK, MessageBoxImage.Error);
            //     return false;
            // }

            return true;
        }

        private bool ValidarMora()
        {
            DateTime fecha;

            if(!DateTime.TryParse(FechaDatePicker.Text, out fecha))
            {
                MessageBox.Show("Ingrese una fecha e intente de nuevo", "Registro de moras", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if(orden.Detalle.Count == 0)
            {
                MessageBox.Show("Ingrese  un préstamo e intente de nuevo", "Registro de moras", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }
     }
}
using Prueba_1;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Prueba_1
{

    
    public class EliminarUsuario : ContentPage
    {

        private ListView _listView;
        private Button _button;

        Usuario _usuario = new Usuario();

        String _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");

        public EliminarUsuario()
        {

            this.Title = "ELIMINAR RESERVA";

            var db = new SQLiteConnection(_dbPath);
            StackLayout stackLayout = new StackLayout();

            _listView = new ListView();
            _listView.ItemsSource = db.Table<Usuario>().OrderBy(x => x.Nombre).ToList();

            // Agregar estilos al ListView
            _listView.BackgroundColor = Color.MediumSlateBlue;

            // Crear una plantilla personalizada para las filas
            var dataTemplate = new DataTemplate(() =>
            {
                var viewCell = new ViewCell();
                var grid = new Grid();

                // Agregar títulos a las columnas
                grid.Children.Add(new Label { Text = "Nombre", FontAttributes = FontAttributes.Bold }, 0, 0);
                grid.Children.Add(new Label { Text = "Correo", FontAttributes = FontAttributes.Bold }, 1, 0);
                grid.Children.Add(new Label { Text = "Número de Mesa", FontAttributes = FontAttributes.Bold }, 2, 0);

                var nombreLabel = new Label();
                var correoLabel = new Label();
                var numMesaLabel = new Label();

                nombreLabel.SetBinding(Label.TextProperty, "Nombre");
                correoLabel.SetBinding(Label.TextProperty, "Correo");
                numMesaLabel.SetBinding(Label.TextProperty, "Num_mesa");

                // Añadir los controles a la celda
                grid.Children.Add(nombreLabel, 0, 1);
                grid.Children.Add(correoLabel, 1, 1);
                grid.Children.Add(numMesaLabel, 2, 1);

                viewCell.View = grid;
                return viewCell;
            });

            _listView.ItemTemplate = dataTemplate;


            //Esta línea agrega un controlador de eventos
            _listView.ItemSelected += _listview_ItemSelected;
            stackLayout.Children.Add(_listView);


            _button = new Button();
            _button.Text = "Eliminar";

            _button.Clicked += _button_Clicked;
            stackLayout.Children.Add(_button);

            Content = stackLayout;

        }

        private void _listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            // Obtenemos el elemento de la lista que ha sido seleccionado
            _usuario = (Usuario)e.SelectedItem;
            

        }
        private async void _button_Clicked(object sender, EventArgs e)
        { // Crea conexión a la bd usando la ruta _dbPath.
            var db = new SQLiteConnection(_dbPath);

            // esta línea de código borra el registro de la tabla de la base de datos
            // donde el ID coincide con el ID del usuario seleccionado en la aplicación,
            // utilizando la biblioteca SQLite.

            db.Table<Usuario>().Delete(x => x.Id == _usuario.Id);
            await DisplayAlert(null, _usuario.Nombre + " " + "Eliminado", "Ok");
            await Navigation.PopAsync();
            ;
           
        }
    }
}
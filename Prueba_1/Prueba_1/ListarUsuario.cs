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
    public class ListarUsuario : ContentPage
    {

        private ListView _listView;
        String _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");

        public ListarUsuario()
        {
            this.Title = "LISTA DE RESERVAS";

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
            _listView.SeparatorVisibility = SeparatorVisibility.Default;


            // ListView se mostrará en la interfaz de usuario dentro del StackLayout,

            // y su contenido
            stackLayout.Children.Add(_listView);


            Content = stackLayout;


        }

    }
}
using Prueba_1;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;

using Xamarin.Forms;

namespace Prueba_1
{
    public class EditarUsuario : ContentPage
    {
        private ListView _listView;
        private Entry _idUsuario;
        private Entry _nombreUSuario;
        private Entry _correoUsuario;

        private Entry _dniUsuario;
        private Entry _num_personaUsuario;
        private Entry _num_mesaUsuario;
        private Button _guardarButton;
        private DatePicker _fechaPicker;

        private Button _button;

        Usuario _usuario = new Usuario();

        //ruta
        String _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");


        //constructor
        public EditarUsuario()
        {
            this.Title = "EDITAR RESERVA";

            // Crea conexión a la bd usando la ruta _dbPath.

            var db = new SQLiteConnection(_dbPath);
            StackLayout stackLayout = new StackLayout();


            // nueva instancia _listView". //constructor
            _listView = new ListView();

            // llenar una lista - ordenados por nombre.

            _listView.ItemsSource = db.Table<Usuario>().OrderBy(x => x.Nombre).ToList();

            // Agregar estilos al ListView
            _listView.BackgroundColor = Color.MediumSlateBlue;




            // Crear una plantilla personalizada para las filas
            var dataTemplate = new DataTemplate(() =>
            {
                // Crear una celda de vista para representar una fila

                //Fila Personalizada.
                var viewCell = new ViewCell();
                //Diseño cuadrícula
                var grid = new Grid();

                // Agregar títulos a las columnas
                grid.Children.Add(new Label { Text = "Nombre", FontAttributes = FontAttributes.Bold }, 0, 0);
                grid.Children.Add(new Label { Text = "Correo", FontAttributes = FontAttributes.Bold }, 1, 0);
                grid.Children.Add(new Label { Text = "Número de Mesa", FontAttributes = FontAttributes.Bold }, 2, 0);


                //etiquetas
                var nombreLabel = new Label();
                var correoLabel = new Label();
                var numMesaLabel = new Label();

               
                // la etiqueta basica hace coneccion con el dato que ingresas , entonces en el campo de nombre se actualiza 
                nombreLabel.SetBinding(Label.TextProperty, "Nombre");
                correoLabel.SetBinding(Label.TextProperty, "Correo");
                numMesaLabel.SetBinding(Label.TextProperty, "Num_mesa");

                // Añadir los controles a la celda columnas / filas 
                grid.Children.Add(nombreLabel, 0, 1);
                grid.Children.Add(correoLabel, 1, 1);
                grid.Children.Add(numMesaLabel, 2, 1);

                //celda utilizará el diseño de cuadrícula
                viewCell.View = grid;
                //devolviendo para su uso en la interfaz de usuario.
                return viewCell;
            });


            // cada elemento de la lista se mostrará según el diseño definido en dataTemplate
            _listView.ItemTemplate = dataTemplate;
            //muestra un separador entre los elementos
            _listView.SeparatorVisibility = SeparatorVisibility.Default;



            //Esta línea agrega un controlador de eventos
            _listView.ItemSelected += _listView_ItemSelected;
            stackLayout.Children.Add(_listView);


            // Inicializa y configura un campo de entrada de texto
            _idUsuario = new Entry();
            _idUsuario.Placeholder = "ID";
            _idUsuario.IsVisible = false;
            stackLayout.Children.Add(_idUsuario);

            _nombreUSuario = new Entry();
            _nombreUSuario.Keyboard = Keyboard.Text;
            _nombreUSuario.Placeholder = "Nombre usuario ";
            stackLayout.Children.Add(_nombreUSuario);


            _correoUsuario = new Entry();
            _correoUsuario.Keyboard = Keyboard.Text;
            _correoUsuario.Placeholder = "Correo usuario ";
            stackLayout.Children.Add(_correoUsuario);

            _dniUsuario = new Entry();
            _dniUsuario.Keyboard = Keyboard.Numeric;
            _dniUsuario.Placeholder = "Dni usuario :";
            _dniUsuario.MaxLength = 8;
            stackLayout.Children.Add(_dniUsuario);

            _num_personaUsuario = new Entry();
            _num_personaUsuario.Keyboard = Keyboard.Numeric;
            _num_personaUsuario.Placeholder = "N° personas:";
            _num_personaUsuario.MaxLength = 2;
            stackLayout.Children.Add(_num_personaUsuario);


            _fechaPicker = new DatePicker(); // Agregar el DatePicker
            stackLayout.Children.Add(_fechaPicker); // Agregarlo al StackLayout


            _num_mesaUsuario = new Entry();
            _num_mesaUsuario.Keyboard = Keyboard.Numeric;
            _num_mesaUsuario.Placeholder = "N° mesa:";
            _num_mesaUsuario.MaxLength = 3;
            stackLayout.Children.Add(_num_mesaUsuario);



            _button = new Button();
            _button.Text = "Editar";

            _button.Clicked += _button_Clicked;
            stackLayout.Children.Add(_button);

            Content = stackLayout;


        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false; // Si el correo está en blanco o es nulo, no es válido.
            }

            try
            {
                var mailAddress = new MailAddress(email);
                return mailAddress.Address == email;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        private async void _button_Clicked(object sender, EventArgs e)
        {

            // Inicializa y abre una conexión a la base de datos SQLite.s
            var db = new SQLiteConnection(_dbPath);

            // Crea un objeto Usuario con los datos ingresados
            Usuario usuario = new Usuario()


            {

               // se asigna a la propiedad el valor que se a ingresado
                Id = Convert.ToInt32(_idUsuario.Text),
                Nombre = _nombreUSuario.Text,
                Correo = _correoUsuario.Text,

                Dni = Convert.ToInt32(_dniUsuario.Text),
                Num_persona = Convert.ToInt32(_num_personaUsuario.Text),
                Fecha = _fechaPicker.Date,
                Num_mesa = Convert.ToInt32(_num_mesaUsuario.Text),
            };


           


            if (string.IsNullOrWhiteSpace(_nombreUSuario.Text) ||
                string.IsNullOrWhiteSpace(_correoUsuario.Text) ||
                string.IsNullOrWhiteSpace(_dniUsuario.Text) ||
                string.IsNullOrWhiteSpace(_num_personaUsuario.Text) ||
                string.IsNullOrWhiteSpace(_num_mesaUsuario.Text))
            {
                await DisplayAlert("Error", "Todos los campos deben estar completos.", "OK");
                return; // Detener la ejecución si algún campo está en blanco o es nulo.
            }


            if (!IsValidEmail(usuario.Correo))
            {
                await DisplayAlert("Error", "El correo electrónico debe terminar en @gmail.", "OK");
                return;
            }


            if (_dniUsuario.Text.Length != 8)
            {
                await DisplayAlert("Error", "El campo DNI debe contener exactamente 8 dígitos.", "OK");
                return;
            }

           


            db.Update(usuario);
            await DisplayAlert(null, usuario.Nombre + " " + "Editado", "Ok");
            await Navigation.PopAsync();
        }

        
        private  void _listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {


            // Obtenemos el elemento de la lista que ha sido seleccionado
            _usuario = (Usuario)e.SelectedItem;

            // Actualizamos el campo de texto seleccionada / cada uno
            _idUsuario.Text = _usuario.Id.ToString();
            _nombreUSuario.Text = _usuario.Nombre;
            _correoUsuario.Text = _usuario.Correo;

            _dniUsuario.Text = _usuario.Dni.ToString();
            _num_personaUsuario.Text = _usuario.Num_persona.ToString();
            _fechaPicker.Date = _usuario.Fecha; // Asignar la fecha al DatePicker
            _num_mesaUsuario.Text = _usuario.Num_mesa.ToString();

            // Validar el correo aquí antes de permitir la edición
           


        }
    

    }
}
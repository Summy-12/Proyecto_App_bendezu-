using Prueba_1;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

using Xamarin.Forms;

namespace Prueba_1
{
    public class AgregarUsuario : ContentPage
    {
        private Entry _nombreUsuario;
        private Entry _correoUsuario;
        private Entry _dniUsuario;
        private Entry _num_personaUsuario;
        private Entry _num_mesaUsuario;
        private Button _guardarButton;
        private DatePicker _fechaPicker;

        // Ruta de la base de datos SQLite.
        String _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");


        // Constructor de la clase AgregarUsuario.
        public AgregarUsuario()
        {
            this.Title = "AGREGAR RESERVA";

            // Inicializa un DatePicker.
            _fechaPicker = new DatePicker();

            // Crea un diseño apilado vertical (StackLayout).
            StackLayout stackLayout = new StackLayout();
           ;

            // Inicializa y configura un campo de entrada de texto
            _nombreUsuario = new Entry();
            _nombreUsuario.Keyboard = Keyboard.Text;
            _nombreUsuario.Placeholder = "Nombre usuario : ";
            stackLayout.Children.Add(_nombreUsuario);

            _correoUsuario = new Entry();
            _correoUsuario.Keyboard = Keyboard.Text;
            _correoUsuario.Placeholder = "Correo usuario : ";
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



            _guardarButton = new Button();
            _guardarButton.Text = "Agregar";
            _guardarButton.Clicked += _guardarButton_Clicked;
            stackLayout.Children.Add(_guardarButton);

            Content = stackLayout;
        }



        // Método botton

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
      


        private async void _guardarButton_Clicked(object sender, EventArgs e)
        {

            // Inicializa y abre una conexión a la base de datos SQLite.
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<Usuario>();

            // Obtiene el ID máximo
            var maxPk = db.Table<Usuario>().OrderByDescending(u => u.Id).FirstOrDefault();



            // Crea un objeto Usuario con los datos ingresados
            Usuario usuario = new Usuario()
            {
                Id = (maxPk == null ? 1 : maxPk.Id + 1),
                Nombre = _nombreUsuario.Text,
                Correo = _correoUsuario.Text,
   
                Dni = Convert.ToInt32(_dniUsuario.Text),
                Num_persona = Convert.ToInt32(_num_personaUsuario.Text),
                Fecha = _fechaPicker.Date,
                Num_mesa = Convert.ToInt32(_num_mesaUsuario.Text),

            };

            // Verificar si todos los campos están completos
            if (string.IsNullOrWhiteSpace(_nombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(_correoUsuario.Text) ||
                string.IsNullOrWhiteSpace(_dniUsuario.Text) ||
                string.IsNullOrWhiteSpace(_num_personaUsuario.Text) ||
                string.IsNullOrWhiteSpace(_num_mesaUsuario.Text))
            {
                await DisplayAlert("Error", "Todos los campos deben estar completos.", "OK");
                return;
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

            db.Insert(usuario);
            await DisplayAlert(null, usuario.Nombre + " " + "Guardado", "Ok");

            // Realiza una acción de navegación para volver a la página anterior.
            await Navigation.PopAsync();

        }

        // metodo Valida - correo electrónico 
        
    }
}
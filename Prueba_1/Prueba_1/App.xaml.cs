using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Prueba_1
{
    public partial class App : Application
    {
        public static SQLiteConnection DatabaseConnection { get; private set; }

        public static MasterDetailPage MAsterDet { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            // Obtener la ruta de la base de datos
            String _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");


            // Crear una conexión a la base de datos
            DatabaseConnection = new SQLiteConnection(_dbPath);

            // Crear la tabla Usuario si no existe
            DatabaseConnection.CreateTable<Usuario>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

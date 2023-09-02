using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Prueba_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

       

        private async void Button_Clicked(object sender, EventArgs e)
        {
            App.MAsterDet.IsPresented = false;
            await App.MAsterDet.Detail.Navigation.PushAsync(new AgregarUsuario());

        }

        private async void Button_Get_Clicked(object sender, EventArgs e)
        {

            App.MAsterDet.IsPresented = false;

            await App.MAsterDet.Detail.Navigation.PushAsync(new ListarUsuario());
        }

        private async void Button_Edit_Clicked(object sender, EventArgs e)
        {

            App.MAsterDet.IsPresented = false;
            await App.MAsterDet.Detail.Navigation.PushAsync(new EditarUsuario());
        }


        private async void Button_Eliminar_Clicked(object sender, EventArgs e)
        {
            App.MAsterDet.IsPresented = false;
            await App.MAsterDet.Detail.Navigation.PushAsync(new EliminarUsuario());
        }

    }



        
}
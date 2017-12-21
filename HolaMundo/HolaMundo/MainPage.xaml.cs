using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HolaMundo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs args)
        {
            string nombreUsuario = nombreEntry.Text;
            DisplayAlert("Hola", $"Hola {nombreUsuario}", "Hola!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sampletest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void NextPage_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new FirstPage());
        }
    }
}

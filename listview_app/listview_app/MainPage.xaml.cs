using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace listview_app
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void OpenList(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
	}
}

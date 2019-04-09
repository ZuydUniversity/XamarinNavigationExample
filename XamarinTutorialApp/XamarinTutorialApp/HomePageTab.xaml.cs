using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTutorialApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePageTab : TabbedPage
	{
		public HomePageTab ()
		{
			InitializeComponent ();
		}

	    private void MenuItem_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new ProfilePage());
        }
	}
}
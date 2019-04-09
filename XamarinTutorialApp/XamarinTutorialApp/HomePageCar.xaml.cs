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
	public partial class HomePageCar : CarouselPage
	{
		public HomePageCar ()
		{
			InitializeComponent ();
		}
	}
}
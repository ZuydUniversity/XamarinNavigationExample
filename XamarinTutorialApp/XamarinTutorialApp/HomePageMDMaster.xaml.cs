using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTutorialApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageMDMaster : ContentPage
    {
        public ListView ListView;

        public HomePageMDMaster()
        {
            InitializeComponent();

            BindingContext = new HomePageMDMasterViewModel();
            ListView = MenuItemsListView;
        }

        class HomePageMDMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomePageMDMenuItem> MenuItems { get; set; }
            
            public HomePageMDMasterViewModel()
            {
                MenuItems = new ObservableCollection<HomePageMDMenuItem>(new[]
                {
                    new HomePageMDMenuItem { Id = 0, Title = "Detail", TargetType = typeof(MasterDetailPageDetail)},
                    new HomePageMDMenuItem { Id = 1, Title = "Map", TargetType = typeof(MapPage) },
                    new HomePageMDMenuItem { Id = 2, Title = "Profile", TargetType = typeof(ProfilePage) }
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTutorialApp
{
    public partial class MainPage : ContentPage
    {
        private bool IsEmailEmpty;
        private bool IsPasswordEmpty;
        private string NavChoice;

        public MainPage()
        {
            InitializeComponent();
            NavPicker.SelectedIndex = 0;
        }

        private void LoginButton_OnClicked(object sender, EventArgs e)
        {
            IsEmailEmpty = string.IsNullOrEmpty(UserEntry.Text);
            IsPasswordEmpty = string.IsNullOrEmpty(PasswordEntry.Text);
            NavChoice = NavPicker.SelectedItem.ToString();

            if (IsEmailEmpty || IsPasswordEmpty)
            {
                //throw new System.ArgumentException("Provide correct Username and Password");
                DisplayAlert("Alert", "You have been alerted", "OK");
            }
            else
            {
                if (NavChoice == "Tabbed")
                {
                    Navigation.PushAsync(new HomePageTab());
                }
                else if (NavChoice == "Carousel")
                {
                    Navigation.PushAsync(new HomePageCar());
                }
                else if (NavChoice == "MasterDetail")
                {
                    Navigation.PushAsync(new HomePageMD());
                }
            }
        }
    }
}

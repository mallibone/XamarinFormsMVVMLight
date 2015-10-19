using Microsoft.Practices.ServiceLocation;
using Xamarin.Forms;
using XamarinFormsMVVMLight.Model;
using XamarinFormsMVVMLight.ViewModel;

namespace XamarinFormsMVVMLight
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Main;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            PeopleListView.SelectedItem = null;
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            Navigation.PushAsync(new DetailPage((Person) e.SelectedItem));
        }
    }
}

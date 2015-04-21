using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinFormsMVVMLight.Model;

namespace XamarinFormsMVVMLight
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Person person)
        {
            InitializeComponent();
            var viewModel = App.Locator.Detail;
            viewModel.Person = person;
            
            BindingContext = viewModel;

            viewModel.ClickMeCallBackAction = () => DisplayAlert("Hello", viewModel.Person.FullName, "Ok");
        }
    }
}

using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using XamarinFormsMVVMLight.Model;

namespace XamarinFormsMVVMLight.ViewModel
{
    public class DetailViewModel : ViewModelBase
    {
        public DetailViewModel()
        {
            ClickMeCallBackAction = () => { };
            ClickMeCommand = new RelayCommand(ClickMeCallBackAction);
        }

        public ICommand ClickMeCommand { get; set; }
        public Person Person { get; set; }

        public Action ClickMeCallBackAction { get; set; }
    }
}
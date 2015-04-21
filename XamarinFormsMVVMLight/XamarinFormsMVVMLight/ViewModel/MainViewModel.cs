using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using XamarinFormsMVVMLight.Model;
using XamarinFormsMVVMLight.Services.Person;

namespace XamarinFormsMVVMLight.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IPeopleService _peopleService;
        ObservableCollection<Person> People { get; set; }

        public MainViewModel(IPeopleService peopleService)
        {
            if (peopleService == null) throw new ArgumentNullException("peopleService");
            _peopleService = peopleService;
        }

        public async Task Init()
        {
            if (People != null) return;

            People = new ObservableCollection<Person>(await _peopleService.GetPeople());
        }
    }
}
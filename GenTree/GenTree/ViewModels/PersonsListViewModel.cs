using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using GenTree.Views;

namespace GenTree.ViewModels
{
     public class PersonsListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MainViewModel> Persons { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CreatePersonCommand { protected set; get; }
        public ICommand DeletePersonCommand { protected set; get; }
        public ICommand SavePersonCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        MainViewModel selectedPerson;

        public INavigation Navigation { get; set; }

        public PersonsListViewModel()
        {
            Persons = new ObservableCollection<MainViewModel>();
            CreatePersonCommand = new Command(CreatePerson);
            DeletePersonCommand = new Command(DeletePerson);
            SavePersonCommand = new Command(SavePerson);
            BackCommand = new Command(Back);
        }

        public MainViewModel SelectedFriend
        {
            get { return selectedPerson; }
            set
            {
                if (selectedPerson != value)
                {
                    MainViewModel tempPerson = value;
                    selectedPerson = null;
                    OnPropertyChanged("SelectedPerson");
                    Navigation.PushAsync(new PersonPage(tempPerson));
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private void CreatePerson()
        {
            Navigation.PushAsync(new PersonPage(new MainViewModel() { ListViewModel = this }));
        }
        private void Back()
        {
            Navigation.PopAsync();
        }
        private void SavePerson(object friendObject)
        {
            MainViewModel friend = friendObject as MainViewModel;
            if (friend != null && friend.IsValid)
            {
                Persons.Add(friend);
            }
            Back();
        }
        private void DeletePerson(object friendObject)
        {
            MainViewModel friend = friendObject as MainViewModel;
            if (friend != null)
            {
               Persons.Remove(friend);
            }
            Back();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using GenTree.Views;
using System.Linq;
using GenTree.Models;

namespace GenTree.ViewModels
{
     public class PersonsListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<MainViewModel> _persons;
        public ObservableCollection<MainViewModel> Persons
        {
            get => _persons;
            set
            {
                _persons = value;
                OnPropertyChanged("Persons");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CreatePersonCommand { protected set; get; }
        public ICommand DeletePersonCommand { protected set; get; }
        public ICommand SavePersonCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        public ICommand SearchPersonsCommand { protected set; get; }
        MainViewModel selectedPerson;

        public INavigation Navigation { get; set; }

        public string MySearchText { get; set; }

        public PersonsListViewModel()
        {
            Persons = new ObservableCollection<MainViewModel>();
            CreatePersonCommand = new Command(CreatePerson);
            DeletePersonCommand = new Command(DeletePerson);
            SavePersonCommand = new Command(SavePerson);
            BackCommand = new Command(Back);
            SearchPersonsCommand = new Command(SearchPersons);
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
        private void SavePerson(object personObject)
        {
            MainViewModel person = personObject as MainViewModel;
            if (person != null && person.IsValid)
            {
                Persons.Add(person);
            }
            Back();
        }
        private void DeletePerson(object personObject)
        {
            MainViewModel person = personObject as MainViewModel;
            if (person != null)
            {
               Persons.Remove(person);
            }
            Back();
        }

        private void SearchPersons()
        {
            var tempRecords = Persons.Where(p => p.Name.Contains(MySearchText));
            Persons = new ObservableCollection<MainViewModel>(tempRecords);
        }
    }
}

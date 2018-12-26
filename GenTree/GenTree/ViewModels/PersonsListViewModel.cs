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
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;
using Plugin.Settings;

namespace GenTree.ViewModels
{
     public class PersonsListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<MainViewModel> _persons;
        private List<Person> rela = new List<Person>();

        public ObservableCollection<MainViewModel> Persons
        {
            get => _persons;
            set
            {
                _persons = value;
                OnPropertyChanged("Persons");
            }
        }

        public ObservableCollection<MainViewModel> Temp;

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
            Persons = JsonConvert.DeserializeObject<ObservableCollection<MainViewModel>>(CrossSettings.Current.GetValueOrDefault("Relatives", ""));
            rela = JsonConvert.DeserializeObject<List<Person>>(CrossSettings.Current.GetValueOrDefault("Relatives", ""));
            Temp = new ObservableCollection<MainViewModel>(Persons);
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

                rela.Add(person.returnPerson());
                CrossSettings.Current.AddOrUpdateValue("Relatives", JsonConvert.SerializeObject(rela, Formatting.Indented));
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
            Persons = new ObservableCollection<MainViewModel>(Temp.Where(p => p.Name.ToLower().Contains(MySearchText.ToLower())));
            Debug.WriteLine(MySearchText);

            //var tempRecords = Persons.Where(p => p.Name.Contains(MySearchText));
        }
    }
}

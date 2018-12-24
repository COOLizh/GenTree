using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GenTree.Models;
using System.IO;
using GenTree.ViewModels;

namespace GenTree.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Person person { get; private set; }
        PersonsListViewModel pvm;

        public MainViewModel()
        {
            person = new Person();
        }

        public PersonsListViewModel ListViewModel
        {
            get { return pvm; }
            set
            {
                if (pvm != value)
                {
                    pvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        //простите :(
        public Person returnPerson()
        {
            return person;
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())) ||
                    (!string.IsNullOrEmpty(Surname.Trim())) ||
                    (!string.IsNullOrEmpty(Gender.Trim())) ||
                    (!string.IsNullOrEmpty(DoB.Trim())));
            }
        }

        public string Name
        {
            get { return person.Name; }
            set
            {
                if (person.Name != value)
                {
                    person.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Surname
        {
            get { return person.Surname; }
            set
            {
                if (person.Surname != value)
                {
                    person.Surname = value;
                    OnPropertyChanged("Surname");
                }
            }
        }

        public string DoB
        {
            get { return person.DoB; }
            set
            {
                if (person.DoB != value)
                {
                    person.DoB = value;
                    OnPropertyChanged("DoB");
                }
            }
        }

        public string Gender
        {
            get { return person.Gender; }
            set
            {
                if (person.Gender != value)
                {
                    person.Gender = value;
                    OnPropertyChanged("Gender");
                }
            }
        }

        public string Id
        {
            get { return person.Id; }
            set
            {
                if (person.Id != value)
                {
                    person.Id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}

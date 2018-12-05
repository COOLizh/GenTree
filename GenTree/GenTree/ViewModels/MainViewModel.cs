using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GenTree.Models;

namespace GenTree.ViewModels
{
    class MainViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Person person;

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

        public bool Gender
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


        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        //private int _Clicks;

        //public int Clicks
        //{
        //    get { return _Clicks; }
        //    set
        //    {
        //        _Clicks = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public MainViewModel()
        //{
        //    Task.Factory.StartNew(() =>
        //    {
        //        while (true)
        //        {
        //            Task.Delay(1000).Wait();

        //            Clicks++;
        //        }
        //    });
        //}
    }
}

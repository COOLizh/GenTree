using System;
using System.Collections.Generic;
using System.Linq;
using GenTree.ViewModels;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using GenTree.Models;
using Plugin.Settings;
using System.Collections.ObjectModel;

namespace GenTree.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Relatives : ContentPage
	{
        //ObservableCollection<MainViewModel> Persons = new ObservableCollection<MainViewModel>();


        public Relatives()
        {
            InitializeComponent();
            BindingContext = new PersonsListViewModel() { Navigation = this.Navigation };
            //personsList.ItemsSource= JsonConvert.DeserializeObject<List<Person>>(CrossSettings.Current.GetValueOrDefault("Relatives", ""));
        }

        private void PersonsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var a = e.Item as MainViewModel;
            Navigation.PushAsync(new ShowPersonPage(a.Name, a.Surname, a.DoB, a.Id, a));
        }

        //private void MainSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    personsList.ItemsSource = new ObservableCollection<MainViewModel>(Persons.Where(p => p.Name.ToLower().Contains(e.NewTextValue.ToLower())));
        //}

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new PersonPage(new MainViewModel()));
        //}
    }
}
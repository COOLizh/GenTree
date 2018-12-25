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

namespace GenTree.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Relatives : ContentPage
	{
		public Relatives ()
		{
			InitializeComponent ();
            BindingContext = new PersonsListViewModel(){ Navigation = this.Navigation};
            personsList.ItemsSource= JsonConvert.DeserializeObject<List<Person>>(CrossSettings.Current.GetValueOrDefault("Relatives", ""));

        }
    }
}
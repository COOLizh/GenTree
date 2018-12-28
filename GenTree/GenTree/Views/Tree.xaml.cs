using GenTree.Models;
using GenTree.ViewModels;
using Newtonsoft.Json;
using Plugin.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GenTree.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tree : ContentPage
	{
		public Tree ()
		{
			InitializeComponent ();

            BindingContext = new PersonsListViewModel() { Navigation = this.Navigation };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var a = JsonConvert.DeserializeObject<List<Person>>(CrossSettings.Current.GetValueOrDefault("Relatives", ""));


            listChildrens.ItemsSource = a.Where(p => p.Id.Contains("Child"));

            listParents.ItemsSource = a.Where(p => (p.Id.Contains("Mother") || p.Id.Contains("Father")));

            listOthers.ItemsSource = a.Where(p => (p.Id.Contains("Husband") || p.Id.Contains("Sister") || p.Id.Contains("Brother") || p.Id.Contains("Wife")));
        }
    }
}
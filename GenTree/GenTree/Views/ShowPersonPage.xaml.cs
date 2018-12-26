using GenTree.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GenTree.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShowPersonPage : ContentPage
	{
        public MainViewModel ViewModel { get; private set; }

        public ShowPersonPage (string name, string surname, string dob, string id, MainViewModel vm)
		{

			InitializeComponent ();
            NameSurname.Text = "Name : " + name + " Surname : " + surname;
            DobId.Text = "Birthday : " + dob + " Kind of relative : " + id;
            vm.Name = name;
            vm.Surname = surname;
            vm.DoB = dob;
            vm.Id = id;
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using GenTree.ViewModels;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GenTree.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Relatives : ContentPage
	{
		public Relatives ()
		{
			InitializeComponent ();
            BindingContext = new PersonsListViewModel(){ Navigation = this.Navigation};
		}
    }
}
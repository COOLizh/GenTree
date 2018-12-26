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
		public ShowPersonPage (string name, string surname, string dob, string id)
		{
			InitializeComponent ();
            NameSurname.Text = name + " " + surname;
            DobId.Text = dob + " " + id;
        }
	}
}
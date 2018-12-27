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
    public partial class PersonPage : ContentPage
    {
        public MainViewModel ViewModel { get; private set; }
        public PersonPage(MainViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            id.Text = picker.Items[picker.SelectedIndex];
        }
    }
}
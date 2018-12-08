using System.ComponentModel;
using Xamarin.Forms;
using System.Windows;
using GenTree.ViewModels;
using BottomBar;
using BottomBar.XamarinForms;
using GenTree.Views;

namespace GenTree
{
    public partial class MainPage : BottomBarPage
	{
		public MainPage()
		{
			InitializeComponent();
            //BindingContext = new MainViewModel();
		}
	}
}

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GenTree.Views;
using BottomBar;
using BottomBar.XamarinForms;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GenTree.Models;
using System.Collections.Generic;
using Plugin.Settings;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace GenTree
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("20B2AA") };
        }

		protected override void OnStart ()
		{
            // Handle when your app starts
                
        }

        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

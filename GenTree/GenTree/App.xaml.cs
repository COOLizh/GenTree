using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GenTree.Views;
using System.Threading.Tasks;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace GenTree
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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

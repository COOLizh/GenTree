using Android.OS;
using Android.Runtime;
using GenTree.ViewModels;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
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
            NameSurname.Text = "Name :                " + name + "\nSurname :           " + surname;
            DobId.Text = "Birthday :             " + dob + "\nKind of relative : " + id;
            //vm.Name = name;
            //vm.Surname = surname;
            //vm.DoB = dob;
            //vm.Id = id;
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }

        

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //await CrossMedia.Current.Initialize();

            //if(!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            //{
            //    await DisplayAlert("No camera", "No camera is available","ROFL");
            //    return;
            //}

            //var file = await CrossMedia.Current.TakePhotoAsync(
            //    new StoreCameraMediaOptions
            //    {
            //        SaveToAlbum = true,
            //    });

            //pers.Source = ImageSource.FromStream(() =>
            //{
            //    var stream = file.GetStream();
            //    file.Dispose();
            //    return stream;
            //});

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("oops", "Pick photo is not supported", "ROFL");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();

            if (file == null)
                return;

            Path.Text = "Photo path : " + file.Path;

            pers.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });


        }

        private async void SetPhButton_Clicked(object sender, EventArgs e)
        {
            //await CrossMedia.Current.Initialize();

            //if (!CrossMedia.Current.IsPickPhotoSupported)
            //{
            //    await DisplayAlert("oops", "Pick photo is not supported", "ROFL");
            //    return;
            //}

            //var file = await CrossMedia.Current.PickPhotoAsync();

            //if (file == null)
            //    return;

            //Path.Text = "Photo path : " + file.Path;

            //pers.Source = ImageSource.FromStream(() =>
            //{
            //    var stream = file.GetStream();
            //    file.Dispose();
            //    return stream;
            //});
        }
    }
}
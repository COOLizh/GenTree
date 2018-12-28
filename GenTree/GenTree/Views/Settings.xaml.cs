using Plugin.Media;
using Plugin.Media.Abstractions;
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
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();
		}

        //private async void TakePhotoButton_OnCicked(object sender, EventArgs e)
        //{
        //    await CrossMedia.Current.Initialize();

        //    if(!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
        //    {
        //        await DisplayAlert("No camera", "No camera avaible.", "OK");
        //        return;
        //    }

        //    var file = await CrossMedia.Current.TakePhotoAsync(
        //        new StoreCameraMediaOptions
        //        {
        //            SaveToAlbum = true,
        //        });

        //    if (file == null)
        //        return;

        //    await DisplayAlert("Path of photo", "Sved to : {0}", file.AlbumPath, "OK");

        //    //MainImage.Source
        //}

        
    }
}
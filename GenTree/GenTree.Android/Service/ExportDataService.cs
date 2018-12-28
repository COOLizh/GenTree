using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using GenTree.Models;
using GenTree.Service;
using Newtonsoft.Json;
using Xamarin.Forms;

[assembly: Dependency(typeof(GenTree.Droid.Service.ExportDataService))]
namespace GenTree.Droid.Service
{

    public class ExportDataService : IExportDataService
    {
        public void ExportData(List<Person> personList)
        {
            var json = JsonConvert.SerializeObject(personList);
            
            var email = new Intent(Intent.ActionSend);
            email.PutExtra(Intent.ExtraEmail, "coolizh228@gmail.com");
            email.PutExtra(Intent.ExtraSubject, "Application");
            email.PutExtra(Intent.ExtraText, json);
            email.PutExtra(Intent.ExtraHtmlText, true);
            email.SetType("message/rfc822");
            Forms.Context.StartActivity(email);


        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GenTree.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class wb : ContentPage
	{
		public wb ()
		{
			InitializeComponent ();
            srch.Source = "http://www.vgd.ru/";
        }
	}
}
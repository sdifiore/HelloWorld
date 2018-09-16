﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
        private int _index = 0;
        private string[] _quotes = new string[]
        {
            "1. Imagination is more important than knowledge.",
            "2. Life is like riding a bicycle. To keep your balance you must keep moving.",
            "3 .Look deep into nature, and then you will understand everything better."
        };

		public QuotesPage ()
		{
			InitializeComponent ();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _index++;
            if (_index >= _quotes.Length) _index = 0;
            currentQuote.Text = _quotes[_index];
        }
    }
}
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UKCostsCalculator
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

		void OnSettingsBtnClicked(object sender, EventArgs args) {
			DisplayAlert ("Settings", "Settings have not yet been implemented", "OK");
		}

		void OnTaxBtnClicked(object sender, EventArgs args) {
			DisplayAlert ("Tax Calculation", "Tax Calculation has not yet been implemented", "OK");
		}
	}
}


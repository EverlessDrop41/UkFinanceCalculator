using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UKCostsCalculator
{
	public partial class TaxCalculator : ContentPage
	{
		public TaxCalculator ()
		{
			InitializeComponent ();
		}

		void OnCalculateBtnClicked(object sender, EventArgs args) {
			DisplayAlert ("Tax Calculation", "Tax Calculation has not yet been implemented", "OK");
		}
	}
}


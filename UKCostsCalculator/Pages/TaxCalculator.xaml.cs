using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UKCostsCalculator
{
	public partial class TaxCalculator : ContentPage
	{
		public IncomeTaxCalculator calc;

		public TaxCalculator ()
		{
			InitializeComponent ();
			calc = new IncomeTaxCalculator (0);
		}

		void OnCalculateBtnClicked(object sender, EventArgs args) {
			string inputData = AnnualInput.Text;
			int annualIncome = int.Parse (inputData);
			calc.AnnualIncome = annualIncome;
			int netIncome = calc.CalculateIncomeTax ();
			DisplayAlert ("Tax Calculation", "Your net income is: £" + netIncome.ToString(), "OK");
		}
	}
}


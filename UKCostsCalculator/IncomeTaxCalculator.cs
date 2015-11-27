using System;

namespace UKCostsCalculator
{
	public class IncomeTaxCalculator
	{
		public static int BasicRateMax = 31785;
		public static int HigherRateMax = 150000;

		public IncomeTaxCalculator (int annualIncome)
		{
			AnnualIncome = annualIncome;
		}

		public int AnnualIncome;

		public int PersonalAllowance = 10600;

		public static float BasicRate = 0.2f;
		public static float HigherRate = 0.4f;
		public static float AdditionalRate = 0.45f;

		public int CalculateIncomeTax() {
			if (AnnualIncome >= PersonalAllowance) {
				int AfterAllowance = AnnualIncome - PersonalAllowance;
				TaxRates rate = getTaxRate (AfterAllowance);

				int TaxToPay = 0;

				if (rate == TaxRates.Basic) {
					TaxToPay = GetBasicTaxAmount(AfterAllowance);
				}

				if (rate == TaxRates.Higher) {
					TaxToPay = GetBasicTaxAmount (AfterAllowance);
					TaxToPay += GetHigherTaxAmount (AfterAllowance - BasicRateMax);
				}

				if (rate == TaxRates.Advanced) {
					TaxToPay = GetBasicTaxAmount (AfterAllowance);
					TaxToPay += GetHigherTaxAmount (AfterAllowance - BasicRateMax);
					TaxToPay += GetAdditionalTaxAmount (AfterAllowance - HigherRateMax);
				}

				return AnnualIncome - TaxToPay;
			} else {
				return AnnualIncome;
			}
		}

		int GetBasicTaxAmount(int Amount){
			return (int)(Amount * BasicRate);
		}

		int GetHigherTaxAmount(int Amount){
			return (int)(Amount * HigherRate);
		}

		int GetAdditionalTaxAmount(int Amount){
			return (int)(Amount * AdditionalRate);
		}

		public TaxRates getTaxRate(int NoAllowanceAmount) {
			if (NoAllowanceAmount <= BasicRateMax) {
				return TaxRates.Basic;
			} else if (NoAllowanceAmount <= HigherRateMax) {
				return TaxRates.Higher;
			} else {
				return TaxRates.Advanced;
			}
		}
	}

	public enum TaxRates {
		Basic,
		Higher,
		Advanced
	}
}


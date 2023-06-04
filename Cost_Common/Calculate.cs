using System;

namespace Cost_Common
{
	public static class Calculate
	{
		public static double GetUnitPrice(double Amount, string UoM, double Price)
		{
			return Price / (Amount * UtilitiesUoM.GetFactorbyUoMName(UoM));
        }

        public static double GetUnitWastagePrice(double Amount, string UoM, double Price, double Wastage)
        {
            return (Price / (Amount * UtilitiesUoM.GetFactorbyUoMName(UoM))) * 100 / (100 - Wastage);
        }

        public static double GetProductComponentPrice(string UoM, double UoMPrice, double Amount)
        {
            double Factor = UtilitiesUoM.GetFactorbyUoMName(UoM);
            return UoMPrice * Factor * Amount;
        }

        public static double UnitConverter(string FromUoM, string ToUoM)
        {
            double FromFactor = UtilitiesUoM.GetFactorbyUoMName(FromUoM);
            double ToFactor = UtilitiesUoM.GetFactorbyUoMName(ToUoM);
            return ToFactor / FromFactor;
        }
    }
}


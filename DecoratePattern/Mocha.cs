using System;

namespace DecoratePattern
{
	public class Mocha:CondimentDecorate
	{
		private Beverage beverage;
		public Mocha (Beverage beverage)
		{
			beverage = beverage;
		}


		public string GetDescripition()
		{
			return this.beverage.GetDescripition () + " Mocha";
		}

		public double Cost()
		{
			return 0.2 + beverage.Cost ();
		}
	}
}


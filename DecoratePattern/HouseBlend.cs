using System;

namespace DecoratePattern
{
	public class HouseBlend:Beverage
	{
		public HouseBlend ()
		{
			descripition = "House Blend Coffee";
		}

		public double Cost()
		{
			return 0.89;
		}
	}
}


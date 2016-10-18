using System;

namespace DecoratePattern
{
	public class Espresso:Beverage
	{
		public Espresso ()
		{
			descripition = "Espresso";
		}

		public double Cost()
		{
			return 1.99;
		}
	}
}


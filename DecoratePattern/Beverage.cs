using System;

namespace DecoratePattern
{
	public abstract class Beverage
	{
		protected string descripition = "Unknown Beverage";

		public string GetDescripition()
		{
			return this.descripition;
		}


		public abstract double Cost ();
	

	}
}


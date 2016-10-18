using System;

namespace ObserverPattern
{
	public class CurrentConditionsBoard:IObserver,IDisplay
	{
		private double temperature;
		private double humidity;
		private ISubject weatherData;
		public CurrentConditionsBoard (ISubject subject)
		{
			this.weatherData = subject;
			//缺少了订阅
			subject.RegisterObserver(this);
		}

		public void Update(double temperature,double humidity,double pressure)
		{
			this.temperature = temperature;
			this.humidity = humidity;
			Display ();
		}


		public void Display()
		{
			Console.WriteLine ("Current Conditions:"+ temperature+" F degrees and "+ humidity + "% humidity");
		}
	}
}


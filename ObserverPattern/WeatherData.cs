using System;
using System.Collections.Generic;

namespace ObserverPattern
{

	/// <summary>
	/// 示例 天气信息数据，可通知给注册的观察者
	/// </summary>
	public class WeatherData:ISubject
	{

		private List<IObserver> observers;

		// 示例数据类型  温度 湿度 压力
		private double temperature;
		private double humidity;
		private double pressure;
	



		public double GetTemperature()
		{
			return this.temperature;
		}

		public double GetHumidity()
		{
			return this.humidity;
		}

		public double GetPressure()
		{
			return this.pressure;
		}

		public WeatherData ()
		{
			observers = new List<IObserver> ();

		}

		public void RegisterObserver(IObserver observer)
		{
			observers.Add (observer);
		}

		public void UnRegisterObserver(IObserver observer)
		{
			observers.Remove (observer);
		}

		public void NodityObserver()
		{
			observers.ForEach (p=>p.Update(temperature,humidity,pressure));
		}



		//提供三个数据更新
		public void SetMeasurements(double temperature,double humidity,double pressure)
		{
			this.temperature = temperature;
			this.humidity = humidity;
			this.pressure = pressure;
			MeasurementsChanged ();
		}

		/// <summary>
		/// 数据跟新之后 通知观察者
		/// </summary>
		public void MeasurementsChanged()
		{
			NodityObserver ();
		}


	}
}


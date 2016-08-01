using System;

namespace ObserverPattern
{
	/// <summary>
	/// 观察者接口，为演示目的，提供跟新方法
	/// </summary>
	public interface IObserver
	{
		void Update(double temperature,double humidity,double pressure);
	}
}


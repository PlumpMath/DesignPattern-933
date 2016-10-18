using System;

namespace ObserverPattern
{
	/// <summary>
	/// 主题接口，提供连个注册相关方法，一个通知方法
	/// </summary>
	public interface ISubject
	{
		void RegisterObserver(IObserver observer);

		void UnRegisterObserver(IObserver observer);

		void NodityObserver();
	}
}


using System;
using ObserverPattern;

namespace Console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//测试观察者模式
			TestObserverPattern();
		}



		public static void TestObserverPattern()
		{
   			WeatherData subject = new WeatherData ();

			CurrentConditionsBoard currentConditionBoard = new CurrentConditionsBoard (subject);

			subject.SetMeasurements (36.6, 34, 55);

			System.Console.ReadKey ();
		}


	}
}

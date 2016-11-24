using System;

using Xamarin.Forms;

namespace DexExpTest
{
	public class App : Application
	{
		public App()
		{
			this.MainPage = GetMainPage();
		}

		public static Page GetMainPage()
		{
			return new DevTestMain();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

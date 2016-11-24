using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DexExpTest
{
	public partial class DevTestMain : ContentPage
	{
		public DevTestMain()
		{
			InitializeComponent();

			TestOrdersRepository model = new TestOrdersRepository();
			BindingContext = model;
		}

	}
}

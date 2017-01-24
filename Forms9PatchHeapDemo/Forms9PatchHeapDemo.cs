using System;

using Xamarin.Forms;

namespace Forms9PatchHeapDemo
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			var content = new ContentPage
			{
				Title = "Forms9Patch Demo",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Forms9Patch.ImageButton
						{
							DefaultState = new Forms9Patch.ImageButtonState
							{
								BackgroundImage = new Forms9Patch.Image
								{
									Source = Forms9Patch.ImageSource.FromMultiResource("Forms9PatchHeapDemo.Resources.delay")
								},
							},
							SelectedState = new Forms9Patch.ImageButtonState
							{
								BackgroundImage = new Forms9Patch.Image
								{
									Source = Forms9Patch.ImageSource.FromMultiResource("Forms9PatchHeapDemo.Resources.tick")
								},
							},
							WidthRequest = 150,
							HeightRequest = 150,
							HorizontalOptions = LayoutOptions.Center, // needed for WidthRequest
							ToggleBehavior = true,
						}
					}
				}
			};

			MainPage = new NavigationPage(content);
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

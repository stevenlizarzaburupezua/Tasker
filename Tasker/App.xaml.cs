using Android.Content.Res;
using Tasker.MVVM.Views;

namespace Tasker;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainView());
	}
}

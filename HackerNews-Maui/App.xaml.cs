using HackerNews_Maui.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Application = Microsoft.Maui.Controls.Application;

namespace HackerNews_Maui
{
    public partial class App : Application
	{
		public App(IServiceProvider service)
		{
			InitializeComponent();

			var viewModel = service.GetRequiredService<TopStoriesViewModel>();

			MainPage = new MainPage(viewModel);
		}
	}
}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Refit;
using HackerNews_Maui.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using HackerNews_Maui.ViewModels;

[assembly: XamlCompilationAttribute(XamlCompilationOptions.Compile)]

namespace HackerNews_Maui
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				})
				.ConfigureServices(services =>
				{
					services.AddRefitClient<IHackerNewsApi>()
						.ConfigureHttpClient(client => client.BaseAddress = new Uri("https://hacker-news.firebaseio.com/v0"));

					services.AddSingleton<IHackerNewsRepository, HackerNewsRepository>();
					services.AddTransient<TopStoriesViewModel>();
				});
		}
	}
}
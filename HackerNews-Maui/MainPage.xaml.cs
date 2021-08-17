using HackerNews_Maui.ViewModels;
using Microsoft.Maui.Controls;

namespace HackerNews_Maui
{
    public partial class MainPage : ContentPage
	{
		public MainPage(TopStoriesViewModel viewModel)
		{
			InitializeComponent();

			BindingContext = viewModel;
		}
	}
}

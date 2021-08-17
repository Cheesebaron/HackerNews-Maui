using HackerNews_Maui.Infrastructure;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using Microsoft.Maui.Essentials;
using System.Reactive.Concurrency;

namespace HackerNews_Maui.ViewModels
{
    public class TopStoriesViewModel : BaseViewModel
    {
        private readonly CompositeDisposable _disposables
            = new CompositeDisposable();

        public ObservableCollection<ItemViewModel> TopStories { get; }
            = new ObservableCollection<ItemViewModel>();

        public Command GetTopStoriesCommand { get; }

        public TopStoriesViewModel(IHackerNewsRepository repository)
        {
            var topStoriesObservable = repository
                .GetTopStories()
                .ToObservable()
                .Select(item => new ItemViewModel(item));

            var topStoriesSubscription =
                topStoriesObservable
                    .ObserveOn(DefaultScheduler.Instance)
                    .Subscribe(item => TopStories.Add(item));

            _disposables.Add(topStoriesSubscription);

            GetTopStoriesCommand = new Command(() =>
            {
                TopStories.Clear();
                topStoriesObservable.Repeat(1);
            });
        }
    }
}

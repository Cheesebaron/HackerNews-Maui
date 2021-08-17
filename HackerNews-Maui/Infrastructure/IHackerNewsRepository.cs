using HackerNews_Maui.Models;

namespace HackerNews_Maui.Infrastructure
{
    public interface IHackerNewsRepository
    {
        IAsyncEnumerable<Item> GetTopStories();
    }
}

using HackerNews_Maui.Models;
using Refit;

namespace HackerNews_Maui.Infrastructure
{
    public interface IHackerNewsApi
    {
        [Get("/item/{id}.json")]
        Task<Item> GetItem([AliasAs("id")] long id);

        [Get("/topstories.json")]
        Task<IEnumerable<long>> GetTopStories();
    }
}

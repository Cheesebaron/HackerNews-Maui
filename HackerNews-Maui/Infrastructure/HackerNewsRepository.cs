using HackerNews_Maui.Models;

namespace HackerNews_Maui.Infrastructure
{
    public class HackerNewsRepository : IHackerNewsRepository
    {
        private readonly IHackerNewsApi api;

        public HackerNewsRepository(IHackerNewsApi api)
        {
            this.api = api;
        }

        public async IAsyncEnumerable<Item> GetTopStories()
        {
            var storyIds = await api.GetTopStories().ConfigureAwait(false);
            var itemsTasks = storyIds.Select(id => api.GetItem(id));
            foreach(var itemTask in itemsTasks)
            {
                yield return await itemTask.ConfigureAwait(false);
            }
        }
    }
}

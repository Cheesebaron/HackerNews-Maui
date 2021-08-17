using HackerNews_Maui.Extensions;
using HackerNews_Maui.Models;

namespace HackerNews_Maui.ViewModels
{
    public class ItemViewModel
    {
        private readonly Item model;

        public ItemViewModel(Item model)
        {
            this.model = model;
        }

        public string Title => model.Title ?? string.Empty;
        public string Text => (model.Text ?? string.Empty).Left(280);
        public string By => model.By ?? string.Empty;
        public int Score => model.Score;
    }
}

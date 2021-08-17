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
        public string Text => model.Text ?? string.Empty;
        public int Score => model.Score;
    }
}

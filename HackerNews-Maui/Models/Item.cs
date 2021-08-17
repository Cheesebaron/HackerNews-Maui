using System.Text.Json.Serialization;

namespace HackerNews_Maui.Models
{
    public class Item
    {
        [JsonPropertyName("by")]
        public string By { get; set; }

        [JsonPropertyName("descendants")]
        public long Descendants { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("parent")]
        public long Parent { get; set; }

        [JsonPropertyName("poll")]
        public long Poll { get; set; }

        [JsonPropertyName("kids")]
        public long[] Kids { get; set; }

        [JsonPropertyName("parts")]
        public long[] Parts { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("time")]
        public long Time { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}

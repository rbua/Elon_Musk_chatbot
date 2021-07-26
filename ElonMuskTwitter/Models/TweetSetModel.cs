using System.Text.Json.Serialization;

namespace ElonMuskTwitter.Models
{
    public class TweetSetModel
    {
        [JsonPropertyName("data")]
        public TweetItem[] Payload {get;set;}

        [JsonPropertyName("meta")]
        public SetInfo Info { get; set; }
    }

    public class TweetItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class SetInfo
    {
        [JsonPropertyName("oldest_id")]
        public string OldestTweetId { get; set; }

        [JsonPropertyName("newest_id")]
        public string NewestTweetId { get; set; }

        [JsonPropertyName("result_count")]
        public int ResultCount { get; set; }
    }
}

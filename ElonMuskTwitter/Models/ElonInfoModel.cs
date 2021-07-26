using System.Text.Json.Serialization;

namespace ElonMuskTwitter.Models
{
    public class ElonInfoModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("public_metrics")]
        public Metrics PublicMetrics { get; set; }

        [JsonPropertyName("profile_image_url")]
        public string ProfileImageUrl { get; set; }
    }

    public class Metrics
    {
        [JsonPropertyName("followers_count")]
        public int FollowersCount {get;set;}

        [JsonPropertyName("following_count")]
        public int FollowingCount {get;set; }

        [JsonPropertyName("tweet_count")]
        public int TweetCount { get; set; }

        [JsonPropertyName("listed_count")]
        public int ListedCount { get; set; }
    }

    internal class ElonInfoViewModel
    {
        [JsonPropertyName("data")]
        public ElonInfoModel[] Data { get; set; }
    }
}

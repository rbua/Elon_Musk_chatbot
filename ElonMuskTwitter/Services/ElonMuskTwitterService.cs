using ElonMuskTwitter.Models;
using RestSharp;
using System.Text.Json;
using System.Linq;
using Microsoft.Extensions.Options;

namespace ElonMuskTwitter.Services
{
    public class ElonMuskTwitterService : IElonMuskTwitterService
    {
        private readonly IOptions<AuthConfig> _authConfig;

        public ElonMuskTwitterService(IOptions<AuthConfig> config)
        {
            _authConfig = config;
        }

        public ElonInfoModel GetElonInfo()
        {
            var client = new RestClient("https://api.twitter.com/2/users?ids=44196397&user.fields=public_metrics,profile_image_url");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {_authConfig.Value.BearerToken}");
            var response = client.Execute(request);

            var output = JsonSerializer.Deserialize<ElonInfoViewModel>(response.Content);

            return output.Data.Single();
        }

        public TweetSetModel GetLatestElonTweets()
        {

            var client = new RestClient("https://api.twitter.com/2/users/44196397/tweets?max_results=50");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {_authConfig.Value.BearerToken}");
            var response = client.Execute(request);

            var output = JsonSerializer.Deserialize<TweetSetModel>(response.Content);

            return output;
        }

        public TweetSetModel GetTweetsByKeyword(string keyword)
        {
            var client = new RestClient($"https://api.twitter.com/2/tweets/search/recent?query={keyword}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {_authConfig.Value.BearerToken}");
            var response = client.Execute(request);

            var output = JsonSerializer.Deserialize<TweetSetModel>(response.Content);

            return output;
        }
    }
}

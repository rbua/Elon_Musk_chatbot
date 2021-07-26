using ElonMuskTwitter.Models;

namespace ElonMuskTwitter.Services
{
    public interface IElonMuskTwitterService
    {
        public TweetSetModel GetLatestElonTweets();

        public TweetSetModel GetTweetsByKeyword(string keyword);

        public ElonInfoModel GetElonInfo();
    }
}

using System.Threading.Tasks;

namespace ElonMuskTwitter.Services
{
    public interface IElonMuskTwitterService
    {
        public Task<string> GetLatestTweet();

        public Task<string> GetTweetsByKeyword(string keyword);
    }
}

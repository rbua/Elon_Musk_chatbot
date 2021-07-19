using System;
using System.Threading.Tasks;

namespace ElonMuskTwitter.Services
{
    public class ElonMuskTwitterService : IElonMuskTwitterService
    {
        public Task<string> GetLatestTweet()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetTweetsByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}

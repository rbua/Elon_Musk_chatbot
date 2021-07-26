using ElonMuskTwitter.Models;
using ElonMuskTwitter.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElonMuskTwitter.Controllers
{
    [ApiController]
    public class ElonMuskTwitterController : ControllerBase
    {
        private IElonMuskTwitterService _elonMuskTwitterService;
        
        public ElonMuskTwitterController(IElonMuskTwitterService elonMuskTwitterService)
        {
            _elonMuskTwitterService = elonMuskTwitterService;
        }

        [HttpGet("Elon/lates")]
        public TweetSetModel GetLatest()
        {
            return  _elonMuskTwitterService.GetLatestElonTweets();
        }

        [HttpGet("Elon/info")]
        public ElonInfoModel GetInfo2()
        {
            return _elonMuskTwitterService.GetElonInfo();
        }

        [HttpGet("Tweets/{keyword}")]
        public TweetSetModel GetByKeyword(string keyword)
        {
            return _elonMuskTwitterService.GetTweetsByKeyword(keyword);
        }
    }
}

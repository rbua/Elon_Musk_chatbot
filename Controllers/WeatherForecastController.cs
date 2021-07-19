using System.Threading.Tasks;
using ElonMuskTwitter.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElonMuskTwitter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElonMuskTwitterController : ControllerBase
    {
        private IElonMuskTwitterService _elonMuskTwitterService;
        
        public ElonMuskTwitterController(IElonMuskTwitterService elonMuskTwitterService)
        {
            _elonMuskTwitterService = elonMuskTwitterService;
        }

        [HttpGet("v1")]
        public async Task<string> GetLatest()
        {
            return await _elonMuskTwitterService.GetLatestTweet();
        }

        [HttpGet("v1/{keyword}")]
        public async Task<string> GetByKeyword(string keyword)
        {
            return await _elonMuskTwitterService.GetTweetsByKeyword(keyword);
        }
    }
}

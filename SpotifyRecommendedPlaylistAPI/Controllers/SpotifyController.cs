using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Text;

namespace SpotifyRecommendedPlaylistAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotifyController : Controller
    {
        #region Private Fields     
        IHttpClientFactory _httpClientFactory { get; set; }
        #endregion Private Fields

        #region Constructors
        public SpotifyController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        #endregion Constructors
                
        [HttpPost("GenerateRecommendedPlaylist")]
        public ActionResult GenerateRecommendedPlaylist()
        {      
            //Remove recommended playlist from last week if it exists

            //Create a new playlist

            //Get Recommended Tracks

            //Add Recommended Tracks to playlist

            return Ok();
        }
    }
}

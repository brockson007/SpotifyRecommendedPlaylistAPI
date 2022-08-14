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
            //Relevant Spotify Docs:
            //Get User's Playlists - https://developer.spotify.com/documentation/web-api/reference/#/operations/get-list-users-playlists
            //Delete Playlist - https://developer.spotify.com/documentation/web-api/reference/#/operations/unfollow-playlist

            //Create a new playlist
            //Relevant Spotify Doc: https://developer.spotify.com/documentation/web-api/reference/#/operations/create-playlist

            //Get Recommended Tracks
            //Relevant Spotify Doc: https://developer.spotify.com/documentation/web-api/reference/#/operations/get-recommendations

            //Add Recommended Tracks to playlist
            //Relevant Spotify Doc: https://developer.spotify.com/documentation/web-api/reference/#/operations/add-tracks-to-playlist

            return Ok();
        }
    }
}

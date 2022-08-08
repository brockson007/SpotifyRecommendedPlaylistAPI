using Microsoft.AspNetCore.Mvc;

namespace SpotifyRecommendedPlaylistAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotifyController : Controller
    {
        #region Private Fields      
        #endregion Private Fields

        #region Constructors
        public SpotifyController()
        {       
        }
        #endregion Constructors
        


        [HttpPost("GeneratePlaylist")]
        public ActionResult GeneratePlaylist()
        {

            return Ok();
        }
    }
}

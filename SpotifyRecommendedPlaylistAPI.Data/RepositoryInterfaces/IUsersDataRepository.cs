using SpotifyRecommendedPlaylistAPI.Data.Models;
using System;
using System.Collections.Generic;

namespace SpotifyRecommendedPlaylistAPI.Data.RepositoryInterfaces
{
    public interface IUsersDataRepository
    {
        IEnumerable<User> GetModels();
        User GetModel(Int32 userID);

        Boolean SaveModel(User userModel);

        Boolean RemoveModel(User userModel);        
    }
}

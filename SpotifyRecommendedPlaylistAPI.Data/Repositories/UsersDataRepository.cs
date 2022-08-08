using SpotifyRecommendedPlaylistAPI.Data.Models;
using SpotifyRecommendedPlaylistAPI.Data.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpotifyRecommendedPlaylistAPI.Data.Repositories
{
    public class UsersDataRepository : IUsersDataRepository
    {
        #region Private Fields
        private readonly SpotifyRecommendedPlaylistAPIDataContext _dbContext;
        #endregion Private Fields

        public UsersDataRepository(SpotifyRecommendedPlaylistAPIDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<User> GetModels()
        {
            IEnumerable<User> returnValue;

            returnValue = _dbContext.Users.OrderBy(t => t.UserID).ToList();
           
            return returnValue;
        }

        public User GetModel(Int32 userID)
        {
            User returnValue = new User();

            returnValue = _dbContext.Users.Where(t => t.UserID == userID).FirstOrDefault();

            return returnValue;
        }

        public Boolean SaveModel(User userModel)
        {
            _dbContext.Users.Attach(userModel);

            if (userModel.UserID == 0)
            {
                #region Pre Preserve SetObjectStateAdded
                #endregion Pre Preserve SetObjectStateAdded

                _dbContext.Entry(userModel).State = EntityState.Added;

                #region Post Preserve SetObjectStateAdded
                #endregion Post Preserve SetObjectStateAdded
            }
            else
            {
                #region Pre Preserve SetObjectStateModified
                #endregion Pre Preserve SetObjectStateModified

                _dbContext.Entry(userModel).State = EntityState.Modified;

                #region Post Preserve SetObjectStateModified
                #endregion Post Preserve SetObjectStateModified
            }

            _dbContext.SaveChanges();

            return true;
        }

        public Boolean RemoveModel(User userModel)
        {
            _dbContext.Users.Attach(userModel);
           
            _dbContext.Users.Remove(userModel);
   
            _dbContext.SaveChanges();

            return true;
        }
    }
}

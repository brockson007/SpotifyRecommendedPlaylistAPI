using ExampleService.Data.Models;
using ExampleService.Data.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleService.Data.Repositories
{
    public class UsersDataRepository : IUsersDataRepository
    {
        #region Private Fields
        private readonly ExampleServiceDataContext _dbContext;
        #endregion Private Fields

        public UsersDataRepository(ExampleServiceDataContext dbContext)
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
            Boolean returnValue = false;

            _dbContext.SaveChanges();

            return returnValue;
        }
    }
}

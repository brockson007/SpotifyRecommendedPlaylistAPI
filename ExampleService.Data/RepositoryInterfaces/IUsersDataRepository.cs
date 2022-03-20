using ExampleService.Data.Models;
using System;
using System.Collections.Generic;

namespace ExampleService.Data.RepositoryInterfaces
{
    public interface IUsersDataRepository
    {
        IEnumerable<User> GetModels();
        User GetModel(Int32 userID);

        Boolean SaveModel(User userModel);
    }
}

﻿using SpotifyRecommendedPlaylistAPI.Data.Models;
using SpotifyRecommendedPlaylistAPI.Data.RepositoryInterfaces;
using SpotifyRecommendedPlaylistAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SpotifyRecommendedPlaylistAPI.Controllers
{
    [Route("api/[controller]")]
    public class ExampleController : Controller
    {
        #region Private Fields
        private IUsersDataRepository _usersDataRepository = null;
        #endregion Private Fields

        #region Constructors
        public ExampleController(IUsersDataRepository usersDataRepository)
        {
            _usersDataRepository = usersDataRepository;
        }
        #endregion Constructors

        [HttpPost("CreateUser")]
        public ActionResult CreateUser([FromBody] UserDto userModel)
        {
            User newUser = new User
            {
                Name = userModel.Name,
                UserName = userModel.UserName,
                Email = userModel.Email,
                Phone = userModel.Phone               
            };

            return Ok(_usersDataRepository.SaveModel(newUser));
        }

        [HttpDelete("DeleteUser")]
        public ActionResult DeleteUser([FromBody] UserDto userModel)
        {
            User userToDelete = new User
            {
                UserID = userModel.UserID,
                Name = userModel.Name,
                UserName = userModel.UserName,
                Email = userModel.Email,
                Phone = userModel.Phone
            };

            return Ok(_usersDataRepository.RemoveModel(userToDelete));
        }

        [HttpGet("GetUsers")]
        public ActionResult GetUsers()
        {            
            return Ok(_usersDataRepository.GetModels());
        }

        [HttpGet("GetUserById")]
        public ActionResult GetUserById(Int32 gameId)
        {            
            return Ok(_usersDataRepository.GetModel(gameId));
        }

    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using WealthManagementAdvisory.BusinessLayer.Interfaces;
using WealthManagementAdvisory.Entities;

namespace WealthManagementAdvisory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("/api/user/create")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateUserProfile([FromBody] User userProfile)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/api/user/{userId}")]
        public async Task<IActionResult> GetUserProfile(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/api/user/all")]
        public async Task<IActionResult> GetAllUserProfiles()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("/api/user/update/{userId}")]
        public async Task<IActionResult> UpdateUserProfile(int userId, [FromBody] User updatedDetails)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("/api/user/delete/{userId}")]
        public async Task<IActionResult> DeleteUserProfile(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
    
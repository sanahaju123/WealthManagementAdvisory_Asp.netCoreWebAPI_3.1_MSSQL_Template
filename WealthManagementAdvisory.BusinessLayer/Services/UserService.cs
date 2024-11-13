using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WealthManagementAdvisory.BusinessLayer.Interfaces;
using WealthManagementAdvisory.BusinessLayer.Services.Repository;
using WealthManagementAdvisory.Entities;

namespace WealthManagementAdvisory.BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateUserProfileAsync(User userProfile)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<User> DeleteUserProfileAsync(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllUserProfileAsync()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<User> GetUserProfileAsync(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<User> UpdateUserProfileAsync(int userId, User updatedDetails)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}

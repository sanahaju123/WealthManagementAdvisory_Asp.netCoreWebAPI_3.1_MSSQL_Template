using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using WealthManagementAdvisory.DataLayer;
using WealthManagementAdvisory.Entities;

namespace WealthManagementAdvisory.BusinessLayer.Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly WealthManagementDbContext _dbContext;
        public UserRepository(WealthManagementDbContext dbContext)
        {
            _dbContext = dbContext;
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

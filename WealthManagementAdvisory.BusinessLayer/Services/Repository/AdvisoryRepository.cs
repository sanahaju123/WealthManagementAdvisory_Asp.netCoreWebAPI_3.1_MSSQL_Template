using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WealthManagementAdvisory.DataLayer;
using WealthManagementAdvisory.Entities;

namespace WealthManagementAdvisory.BusinessLayer.Services.Repository
{
    public class AdvisoryRepository : IAdvisoryRepository
    {
        private readonly WealthManagementDbContext _dbContext;
        public AdvisoryRepository(WealthManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Advisory> GetAdvisoryDetailsAsync(int advisoryId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Advisory> GetInvestmentRecommendationsAsync(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Advisory> ScheduleAdvisorySessionAsync(int userId, DateTime preferredDate, string sessionType)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
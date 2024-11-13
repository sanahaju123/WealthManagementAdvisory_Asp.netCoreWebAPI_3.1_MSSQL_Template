using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WealthManagementAdvisory.DataLayer;
using WealthManagementAdvisory.Entities;

namespace WealthManagementAdvisory.BusinessLayer.Services.Repository
{
    public class PortfolioRepository : IPortfolioRepository
    {
        private readonly WealthManagementDbContext _dbContext;
        public PortfolioRepository(WealthManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Portfolio> AddPortfolioAsync(Portfolio portfolio)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Portfolio> RebalancePortfolioAsync(int userId, Portfolio targetAllocation)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Portfolio> ViewPortfolioAsync(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}

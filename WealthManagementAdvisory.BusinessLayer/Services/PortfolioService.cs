using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WealthManagementAdvisory.BusinessLayer.Interfaces;
using WealthManagementAdvisory.BusinessLayer.Services.Repository;
using WealthManagementAdvisory.Entities;

namespace WealthManagementAdvisory.BusinessLayer.Services
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IPortfolioRepository _portfolioRepository;

        public PortfolioService(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
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

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WealthManagementAdvisory.DataLayer;
using WealthManagementAdvisory.Entities;

namespace WealthManagementAdvisory.BusinessLayer.Services.Repository
{
    public class InvestmentRepository : IInvestmentRepository
    {
        private readonly WealthManagementDbContext _dbContext;
        public InvestmentRepository(WealthManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Investment> AddInvestmentAsync(Investment addInvestmentRequest)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<List<Investment>> GetInvestmentsAsync(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}

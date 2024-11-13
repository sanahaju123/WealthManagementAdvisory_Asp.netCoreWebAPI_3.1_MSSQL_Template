using System;
using System.Threading.Tasks;
using WealthManagementAdvisory.BusinessLayer.Interfaces;
using WealthManagementAdvisory.BusinessLayer.Services.Repository;
using WealthManagementAdvisory.Entities;

namespace WealthManagementAdvisory.BusinessLayer.Services
{
    public class AdvisoryService : IAdvisoryService
    {
        private readonly IAdvisoryRepository _advisoryRepository;

        public AdvisoryService(IAdvisoryRepository advisoryRepository)
        {
            _advisoryRepository = advisoryRepository;
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

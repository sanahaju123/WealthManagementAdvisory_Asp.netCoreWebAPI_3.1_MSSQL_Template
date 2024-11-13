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
    public class AdvisoryController : ControllerBase
    {
        private readonly IAdvisoryService _advisoryService;
        public AdvisoryController(IAdvisoryService advisoryService)
        {
            _advisoryService = advisoryService;
        }

        [HttpGet]
        [Route("/api/advisory/recommendations/{userId}")]
        public async Task<IActionResult> GetInvestmentRecommendations(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("/api/advisory/schedule")]
        [AllowAnonymous]
        public async Task<IActionResult> ScheduleAdvisorySession([FromBody] Advisory sessionRequest)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/api/advisory/details/{advisoryId}")]
        public async Task<IActionResult> GetAdvisoryDetails(int advisoryId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
    
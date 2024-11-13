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
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioService _portfolioService;
        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        [HttpPost]
        [Route("/api/portfolio/add")]
        [AllowAnonymous]
        public async Task<IActionResult> AddPortfolio([FromBody] Portfolio portfolio)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

       
        [HttpGet]
        [Route("/api/portfolio/view/{userId}")]
        public async Task<IActionResult> ViewPortfolio(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("/api/portfolio/rebalance/{userId}")]
        public async Task<IActionResult> RebalancePortfolio(int userId, [FromBody] Portfolio targetAllocation)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
    
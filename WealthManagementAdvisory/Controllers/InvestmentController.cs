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
    public class InvestmentController : ControllerBase
    {
        private readonly IInvestmentService _investmentService;
        public InvestmentController(IInvestmentService investmentService)
        {
            _investmentService = investmentService;
        }

        [HttpPost]
        [Route("/api/investment/add")]
        [AllowAnonymous]
        public async Task<IActionResult> AddInvestment([FromBody] Investment addInvestmentRequest)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/api/investment/{userId}")]
        public async Task<IActionResult> GetInvestments(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}

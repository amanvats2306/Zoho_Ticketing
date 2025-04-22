using Microsoft.AspNetCore.Mvc;
using Zoho_Ticketing.Models;
using Zoho_Ticketing.Services;

namespace Zoho_Ticketing.Controllers
{
    public class ZohoController : ControllerBase
    {
        private readonly ZohoDeskService _zohoDeskService;
        public ZohoController(ZohoDeskService zohoDeskService)
        {
            _zohoDeskService = zohoDeskService;
        }

        [HttpPost("create-ticket")]
        public async Task<IActionResult> CreateTicket()
        {
            var accessToken = "1000.0f645217c27247768e21130e6270e653.5dcc3ac6eb682f028eaca19f010e3bcb";
            
            var departmentId = "192560000000256594";

            var ticket = new ZohoTicketRequest
            {
                subject = "Test from .NET API",
                departmentId = departmentId,
                description = "This is a test ticket created via Zoho API"
            };

            var result = await _zohoDeskService.CreateTicketAsync(accessToken, ticket);
            return Ok(result);
        }
    }
}

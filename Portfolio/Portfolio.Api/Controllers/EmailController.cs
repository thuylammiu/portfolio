using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Portfolio.Api.ViewModels;
using Portfolio.Application.Contracts;

namespace Portfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService emailService;

        public EmailController(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        [HttpPost((nameof(SendEmail)))]
        public async Task<ActionResult<string>> SendEmail([FromBody] EmailViewModel model)
        {
            await emailService.SendEmailAsync(model.FromEmail, model.Subject, model.HtmlMessage);
            return "Send Email Successfully!";
        }
    }
}

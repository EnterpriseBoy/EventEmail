using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventEmail.Models;
using EventEmail.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EventEmail.Controllers
{
    [Route("api/emails")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailRepository emailRepository;

        public EmailController(IEmailRepository EmailRepository)
        {
            emailRepository = EmailRepository;
        }

        [Route("SendEmail")]
        [HttpPost]
        public async Task<ActionResult> SendEmailAsync(Email email)
        {
            await emailRepository.SendEmailAsync(new Email());
            return Ok(email.FirstName);
        }
    }
}
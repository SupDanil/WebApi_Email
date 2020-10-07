using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Contracts;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/emails")]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] EmailContract contract)
        {
            
            var emailServece = new EmailService();
            var result = emailServece.SendEmail(new EmailModel());

            return Ok(result);
        }






    }
}

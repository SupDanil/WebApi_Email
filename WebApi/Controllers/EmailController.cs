using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public EmailController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Post([FromBody] EmailContract contract)
        {
            
            var emailServece = new EmailService();
            var model = _mapper.Map<EmailContract>(contract);
            var result = emailServece.SendEmail(model);

            return Ok(result);
        }






    }
}

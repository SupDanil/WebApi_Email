using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [Route("api/emails")]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] EmailContract contract)
        {

        }






    }
}

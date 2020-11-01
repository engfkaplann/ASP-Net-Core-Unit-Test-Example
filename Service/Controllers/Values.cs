using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Values : ControllerBase
    {
        private readonly ILogger<Values> _logger;

        public Values(ILogger<Values> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id > 0)
            {
                return Ok("value" + id.ToString());
            }
            else
            {
                return BadRequest();
            }

        }
    }
}

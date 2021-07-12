using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laudari.Domain.Ultrassom.Abdome;
using Laudari.Domain.Ultrassom.Abdome.Pancreas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laudari.API.Controllers
{
    [Route("usabdome")]
    [ApiController]
    public class UsAbdomeController : ControllerBase
    {
       
        [HttpPost]
        public IActionResult GetCurrent(UsAbdome usAbdomeTotal)
        {
            return Ok(usAbdomeTotal.GeraLaudo());
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueRice.Api.Core.Logic;
using Microsoft.AspNetCore.Mvc;

namespace BlueRice.Api.Lambda.Controllers {
    [Route("api/[controller]")]
    public class StripsController : Controller {

        // GET api/strips/1
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            var logic = new StripLogic();
            var strip = logic.GetStrip(id);

            return Ok(strip);
        }
    }
}

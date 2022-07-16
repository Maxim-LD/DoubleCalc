using DoubleCalc.Logic;
using DoubleCalc.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doublecalc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AoTController : ControllerBase
    {
        private readonly IAreaOfTriangle _AreaOfTriangle;
        public AoTController(IAreaOfTriangle AreaOfTriangle)
        {
            _AreaOfTriangle = AreaOfTriangle;
        }

        [HttpPost]
        public IActionResult TrigArea(AreaOfTriangleViewModel model)
        {
            var result = _AreaOfTriangle.TrigArea(model);
            return Ok(result);
        }
    }
}

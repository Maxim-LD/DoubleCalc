using DoubleCalc.Logic;
using DoubleCalc.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doublecalc.API.Controllers
{
    public class AoSController : Controller
    {
        private readonly IAreaOfSquare _AreaOfSquare;
        public AoSController(IAreaOfSquare AreaOfSquare)
        {
            _AreaOfSquare = AreaOfSquare;
        }

        [HttpPost]
        public IActionResult SquareArea(AreaOfSquareViewModel model)
        {
            var result = _AreaOfSquare.SquareArea(model);
            return Ok(result);
        }
    }
}

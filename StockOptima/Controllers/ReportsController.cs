using StockOptima.Models;
using StockOptima.Operations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StockOptima.Controllers
{
    [Route("reports")]
    public class ReportsController : Controller
    {
        [HttpGet]
        [Authorize(Roles = Role.StockManagerAndAbove)]
        public IActionResult GeneralReports([FromQuery] FilterOperation startEnd)
        {
            return View(startEnd);
        }
    }
}
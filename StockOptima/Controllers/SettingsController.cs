using System.Threading.Tasks;
using StockOptima.Models;
using StockOptima.Operations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StockOptima.Controllers
{
    [Route("settings")]
    public class SettingsController : Controller
    {
        [HttpGet]
        [Authorize(Roles = Role.HrManager)]
        public IActionResult Settings()
        {
            return View(MessageOperation.Empty);
        }

        [HttpPost]
        [Authorize(Roles = Role.HrManager)]
        public async Task<IActionResult> EditSettings()
        {
            return View("Settings", new MessageOperation("Changes saved", MessageSeverity.success));
        }
    }
}
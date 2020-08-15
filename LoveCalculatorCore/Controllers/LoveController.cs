using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoveCalculatorCore.Models;
using LoveCalculatorCore.Interfaces;

namespace LoveCalculatorCore.Controllers
{
    public class LoveController : Controller
    {
        private ILoveHelper _helper;
        public LoveController(ILoveHelper helper)
        {
            _helper = helper;
        }

        public async Task<IActionResult> Calculator()
        {
            return await Task.Run(() =>
            {
                return View();
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Calculator(LoveViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result_1 = _helper.CalculateLove(viewModel.Lover1, viewModel.Lover2);
                var result = new LoveResult(viewModel);
                result.LovePercentage = result_1;
                return View("LoveResult",result);
            }
            ModelState.AddModelError("Server Error", "Internal Server Error Occcured");
            return View(viewModel);

        }
        
    }
}

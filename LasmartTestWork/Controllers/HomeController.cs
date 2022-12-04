using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Models.ViewModels;

namespace LasmartTestWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPointService _pointService;
        public HomeController(IPointService pointService)
        {
            _pointService = pointService;
        }

        public async Task<IActionResult> Index()
        {
            var points = await _pointService.GetPoints();
            return View(points);
        }

    }
}

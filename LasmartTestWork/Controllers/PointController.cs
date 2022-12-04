using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LasmartTestWork.Controllers
{
    public class PointController : Controller
    {
        private readonly IPointService _pointService;
        public PointController(IPointService pointService)
        {
            _pointService = pointService;
        }
        [HttpGet]
        public async Task<JsonResult> GetPoints()
        {
            var points = await _pointService.GetPoints();
            return Json(points);
        }
        [HttpDelete]
        public async Task<IActionResult> DeletePoint(Guid id)
        {
            await _pointService.DeletePoint(id);
            return Ok();
        }
    }
}

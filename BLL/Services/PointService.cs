using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces;
using BLL.Models.ViewModels;
using Common.Exceptions.Point;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class PointService : IPointService
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;
        public PointService(DataContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<PointVM>> GetPoints()
        {
            var points = await _db.Points.Include(x => x.Comments).Select(x => _mapper.Map<PointVM>(x)).ToListAsync();
            return points;
        }
        public async Task DeletePoint(Guid id)
        {
            var point = await GetPointById(id);
            _db.Points.Remove(point);
            await _db.SaveChangesAsync();
        }
        /// <exception cref="PointNotFoundException"></exception>
        private async Task<Point> GetPointById(Guid id)
        {
            var point = await _db.Points.FirstOrDefaultAsync(p => p.Id == id);
            if (point == null) throw new PointNotFoundException();
            return point;
        }
    }
}

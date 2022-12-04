using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models.ViewModels;
using DAL.Entities;

namespace BLL.Interfaces
{
    public interface IPointService
    {
        public Task<List<PointVM>> GetPoints();
        public Task DeletePoint(Guid id);
    }
}

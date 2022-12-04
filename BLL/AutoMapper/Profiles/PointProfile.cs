using AutoMapper;
using BLL.Models.ViewModels;
using DAL.Entities;

namespace BLL.AutoMapper.Profiles
{
    public class PointProfile : Profile
    {
        public PointProfile()
        {
            CreateMap<Point, PointVM>();
        }
    }
}

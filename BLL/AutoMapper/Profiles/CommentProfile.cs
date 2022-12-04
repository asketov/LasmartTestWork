using AutoMapper;
using BLL.Models.ViewModels;
using DAL.Entities;

namespace BLL.AutoMapper.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentVM>();
        }
    }
}

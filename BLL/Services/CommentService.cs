using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAL;

namespace BLL.Services
{
    public class CommentService : ICommentService
    {
        private readonly DataContext _db;
        public CommentService(DataContext db)
        {
            _db = db;
        }
    }
}

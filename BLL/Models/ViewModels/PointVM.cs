using System;
using System.Collections.Generic;

namespace BLL.Models.ViewModels
{
    public class PointVM
    {
        public Guid Id { get; set; }
        public int Radius { get; set; }
        public string Color { get; set; }
        public IEnumerable<CommentVM> Comments { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}

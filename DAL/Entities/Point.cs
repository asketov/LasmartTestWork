using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Point
    {
        public Guid Id { get; set; }
        public int Radius { get; set; }
        public string Color { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}

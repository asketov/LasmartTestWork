using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string BackgroundColor { get; set; }
        public Guid PointId { get; set; }
        public virtual Point Point { get; set; }
    }
}

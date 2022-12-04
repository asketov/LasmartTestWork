using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Exceptions.General;

namespace Common.Exceptions.Point
{
    public class PointNotFoundException : NotFoundException
    {
        public PointNotFoundException()
        {
            NotFoundModel = "Point";
        }
    }
}

using Figuras.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color color { get; set; }

        public abstract double Area();
    }
}

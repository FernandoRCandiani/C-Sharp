
using System.Globalization;

namespace Figuras.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double width { get; set; }
        public double height { get; set; }

        public override double Area()
        {
            return width * height;
        }

        public override string ToString()
        {
            return "Rectangle color = "
                + color
                + ", width = "
                + width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

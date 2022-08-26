using System;
using System.Globalization;

namespace interface_content.Entities
{
    public class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color: " + Color +
                   "\nWidth: " + Width.ToString("F2", CultureInfo.InvariantCulture) +
                   "\nHeigth: " + Height.ToString("F2", CultureInfo.InvariantCulture) +
                   "\nArea: " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


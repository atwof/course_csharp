using System;
using interface_content.Entities;
using System.Globalization;

namespace interface_content.Entities
{
    public class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color: " + Color +
                   "\nRadius: " + Radius.ToString("F2", CultureInfo.InvariantCulture) +
                   "\nArea: " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


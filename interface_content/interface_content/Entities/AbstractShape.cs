using System;
using interface_content.Enums;

namespace interface_content.Entities
{
    public abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}


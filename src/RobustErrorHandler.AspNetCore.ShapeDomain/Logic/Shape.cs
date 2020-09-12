using RobustErrorHandler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobustErrorHandler.AspNetCore.ShapeDomain
{
    public enum ShapeType
    {
        Square = 1,
        Rectangle = 2,
        Triangle = 3
    }

    public abstract class Shape
    {
        public IList<int> Sides { get; }

        public Shape(IList<int> sides)
        {
            this.Sides = sides;
        }

        public virtual int GetPerimeter()
        {
            return Sides.Sum();
        }

    }
}

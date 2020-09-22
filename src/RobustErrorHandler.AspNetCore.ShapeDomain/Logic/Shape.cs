using System.Collections.Generic;
using System.Linq;

namespace RobustErrorHandler.Sample.ShapeDomain
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

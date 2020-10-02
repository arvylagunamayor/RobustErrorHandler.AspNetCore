using RobustErrorHandler.Core;
using RobustErrorHandler.Core.Errors;
using RobustErrorHandler.Core.SuccessCollection;
using System.Collections.Generic;

namespace RobustErrorHandler.Sample.ShapeDomain
{
    public class Rectangle : Shape
    {
        private Rectangle(IList<int> sides) : base(sides)
        {
        }

        public static Either<Error, Success<Rectangle>> Create(IList<int> sides)
        {
            if (sides.Count != 4)
                return Result.Invalid<Success<Rectangle>>(new ErrorMessages.NotEnoughSides(4));
            else
                return Result.Created(new Rectangle(sides));
        }

        public override int GetPerimeter()
        {
            return base.GetPerimeter();
        }
    }
}

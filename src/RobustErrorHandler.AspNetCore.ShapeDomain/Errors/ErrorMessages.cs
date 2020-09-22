using RobustErrorHandler.Core;

namespace RobustErrorHandler.Sample.ShapeDomain
{
    public static class ErrorMessages
    {

        public class NotEnoughSides : IErrorMessage
        {
            private readonly int sides;

            public NotEnoughSides(int sides)
            {
                this.sides = sides;
            }

            public string ErrorCode => "missing_sides";

            public string Description => $"Provide length of {sides} sides.";
        }
    }
}

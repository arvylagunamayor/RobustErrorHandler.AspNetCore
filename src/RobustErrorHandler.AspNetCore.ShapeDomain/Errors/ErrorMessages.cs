using RobustErrorHandler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobustErrorHandler.AspNetCore.ShapeDomain
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

using Microsoft.AspNetCore.Mvc;
using RobustErrorHandler.AspNetCore;
using RobustErrorHandler.Core;
using RobustErrorHandler.Sample.ShapeDomain;
using System.Collections.Generic;

namespace RobustErrorHandler.Sample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RobustErrorHandlerController : ControllerBase
    {
        [HttpPost]
        [Route("/Calculate/{type}/Perimeter")]
        public ActionResult<int> GetShapePiremeter(ShapeType type, [FromBody]IList<int> shapeData)
        {
            switch (type)
            {
                case ShapeType.Rectangle:
                    {
                        var test = Rectangle.Create(shapeData)
                            .FlatMap((success) =>
                            {
                                return Result.Created(success.GetPerimeter());
                            });

                        return test.ToActionResult();
                    }
                default:
                    {
                        break;
                    }
            }

            return null;
        }
    }
}

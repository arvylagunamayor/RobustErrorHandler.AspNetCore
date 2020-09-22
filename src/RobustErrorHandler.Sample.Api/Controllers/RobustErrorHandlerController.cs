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
        public ActionResult<int> GetShapePeremeter(ShapeType type, [FromBody]IList<int> shapeData)
        {
            switch (type)
            {
                case ShapeType.Rectangle:
                    {
                        return Rectangle.Create(shapeData)
                            .Map((data) =>
                            {
                                return data.GetPerimeter();
                            }).ToActionResult();
                    }
                default:
                    {
                        break;
                    }
            }

            return 0;
        }
    }
}

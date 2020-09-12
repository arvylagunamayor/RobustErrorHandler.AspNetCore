using Microsoft.AspNetCore.Mvc;
using RobustErrorHandler.AspNetCore;
using RobustErrorHandler.AspNetCore.Sample.DTO;
using RobustErrorHandler.AspNetCore.ShapeDomain;
using RobustErrorHandler.Core;

namespace RobustErrorHandler.AspNetCore.Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RobustErrorHandlerControllercs : ControllerBase
    {
        [HttpPost]
        [Route("/Calculate/{type}/Perimeter")]
        public ActionResult<bool> GetShapePeremeter(ShapeType type, [FromBody]ShapeDTO shapeData)
        {
            switch (type)
            {
                case ShapeType.Rectangle:
                    {
                        return ShapeDomain.Rectangle.Create(shapeData.Sides)
                            .Map((data) =>
                            {
                                return true;
                            }).ToActionResult();
                    }
                default:
                    {
                        break;
                    }
            }

            return false;
        }
    }
}

/*
MIT License

Copyright (c) 2018 Coding Militia: ASP.NET Core - From 0 to overkill

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using Microsoft.AspNetCore.Mvc;
using RobustErrorHandler.Core;

namespace RobustErrorHandler.AspNetCore
{
    public readonly struct SuccessMappingVisitor<TModel, TValue> : Success<TValue>.ISucessVisitor<ActionResult<TModel>>
    {
        #region HTTP STATUS 2xx

        public ActionResult<TModel> Visit(TValue result)
            => new SuccessObjectResult(result);

        public ActionResult<TModel> Visit(Success<TValue>.Ok result)
            => new SuccessObjectResult(result.Value);

        public ActionResult<TModel> Visit(Success<TValue>.Created result)
            => new CreatedObjectResult(result.Value);

        public ActionResult<TModel> Visit(Success<TValue>.NoContent result)
            => new NoContentResult();

        #endregion
    }
        
}

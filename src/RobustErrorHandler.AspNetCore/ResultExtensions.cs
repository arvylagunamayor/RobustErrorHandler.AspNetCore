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

using MediatR;
using Microsoft.AspNetCore.Mvc;
using RobustErrorHandler.Core;
using RobustErrorHandler.Core.Errors;
using RobustErrorHandler.Core.SuccessCollection;
using System;

namespace RobustErrorHandler.AspNetCore
{
    public static class ResultExtensions
    {

        public static ActionResult<TValue> ToActionResult<TValue>(this Either<Error, Success<TValue>> result)
            => result.Fold(
                left: error => ToErrorResult<TValue>(error),
                right: success => ToSuccessResult(success)
                );
        //    /*public static ActionResult<TValue> ToActionResult<TValue>(this Either<Error, TValue> result)
        //        => result.Fold(
        //            left: error => ToErrorResult<TValue>(error),
        //            right: success => ToSuccessResult(success, value => value));



        //         */
        //    public static ActionResult<TValue> ToActionResult<TValue>(this Either<Error, TValue> result)
        //        => result.Fold(
        //            left: error => ToErrorResult<TValue>(error),
        //            right: success => ToSuccessResult(success, value => value));

        //    public static ActionResult<TValue> ToActionResult<TValue>(this Either<Error, Either<Error, Success<int>>> result)
        //        => result.Fold(left: error => ToErrorResult<TValue>(error),
        //            right: succes => ToSuccessResult();

        //    public static ActionResult<TModel> ToActionResult<TModel, TValue>(this Either<Error, Success<TValue>> result)
        //        => result.Fold(
        //            left: error => ToErrorResult<TModel>(error),
        //            right: success => ToSuccessResult<TModel, TValue>(success));

        //    public static ActionResult<TModel> ToActionResult<TValue, TModel>(
        //        this Either<Error, TValue> result,
        //        Func<TValue, TModel> valueMapper)
        //        => result.Fold(
        //            left: error => ToErrorResult<TModel>(error),
        //            right: success => ToSuccessResult(success, valueMapper)
        //        );

        //    public static ActionResult ToUntypedActionResult<TValue>(
        //        this Either<Error, TValue> result,
        //        Func<TValue, ActionResult> successMapper)
        //        => result.Fold(
        //            left: error => ToErrorResult(error),
        //            right: successMapper);

        //    private static ActionResult<TModel> ToSuccessResult<TValue, TModel>(
        //        TValue result,
        //        Func<TValue, TModel> valueMapper)
        //        => valueMapper(result);

        //    //private static ActionResult<TModel> ToSuccessResult<TValue, TModel>(
        //    //    TValue result,
        //    //    Func<TValue, TModel> valueMapper)
        //    //    => result is Unit
        //    //        ? (ActionResult<TModel>) new NoContentResult()
        //    //        : valueMapper(result);

        //    private static ActionResult<TModel> ToSuccessResult<TModel, TValue>(Success<TValue> success)
        //        => success.Accept<SuccessMappingVisitor<TModel, TValue>, ActionResult<TModel>>(new SuccessMappingVisitor<TModel, TValue>());


        private static ActionResult<TModel> ToSuccessResult<TModel, TValue>(Success<TValue> success)
            => success.Accept<SuccessMappingVisitor<TModel, TValue>, ActionResult<TModel>>(new SuccessMappingVisitor<TModel, TValue>());

        private static ActionResult ToSuccessResult<TValue>(Success<TValue> success)
            => success.Accept<SuccessMappingVisitor<object, TValue>, ActionResult<object>>(new SuccessMappingVisitor<object, TValue>()).Result;

        private static ActionResult<TModel> ToErrorResult<TModel>(Error error)
            => error.Accept<ErrorMappingVisitor<TModel>, ActionResult<TModel>>(new ErrorMappingVisitor<TModel>());

        private static ActionResult ToErrorResult(Error error)
            => error.Accept<ErrorMappingVisitor<object>, ActionResult<object>>(new ErrorMappingVisitor<object>()).Result;
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace RobustErrorHandler.AspNetCore
{

    #region HTTP Status 4xx

    public class PaymentRequiredObjectResult : ObjectResult
    {
        public PaymentRequiredObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status402PaymentRequired;
        }
    }

    public class ForbiddenObjectresult : ObjectResult
    {
        public ForbiddenObjectresult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status403Forbidden;
        }
    }


    public class MethodNotAllowedObjectresult : ObjectResult
    {
        public MethodNotAllowedObjectresult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status405MethodNotAllowed;
        }
    }
    public class NotAcceptableObjectresult : ObjectResult
    {
        public NotAcceptableObjectresult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status406NotAcceptable;
        }
    }

    public class ProxyAuthenticationRequiredObjectResult : ObjectResult
    {
        public ProxyAuthenticationRequiredObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status407ProxyAuthenticationRequired;
        }
    }

    public class RequestTimeOutObjectResult : ObjectResult
    {
        public RequestTimeOutObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status408RequestTimeout;
        }
    }

    public class GoneObjectResult : ObjectResult
    {
        public GoneObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status410Gone;
        }
    }

    public class LengthRequiredObjectResult : ObjectResult
    {
        public LengthRequiredObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status411LengthRequired;
        }
    }

    public class PreConditionFailedObjectResult : ObjectResult
    {
        public PreConditionFailedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status412PreconditionFailed;
        }
    }

    public class PayloadTooLargeObjectResult : ObjectResult
    {
        public PayloadTooLargeObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status413PayloadTooLarge;
        }
    }

    public class RequestURITooLongObjectResult : ObjectResult
    {
        public RequestURITooLongObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status414RequestUriTooLong;
        }
    }

    public class UnsupportedMediaTypeObjectResult : ObjectResult
    {
        public UnsupportedMediaTypeObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status415UnsupportedMediaType;
        }
    }

    public class RequestedRangeNotSatisfiableObjectresult : ObjectResult
    {
        public RequestedRangeNotSatisfiableObjectresult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status416RequestedRangeNotSatisfiable;
        }
    }

    public class ExpectationFailedObjectResult : ObjectResult
    {
        public ExpectationFailedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status417ExpectationFailed;
        }
    }

    public class ImATeaPotObjectResult : ObjectResult
    {
        public ImATeaPotObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status418ImATeapot;
        }
    }

    public class MisdirectedRequestObjectResult : ObjectResult
    {
        public MisdirectedRequestObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status421MisdirectedRequest;
        }
    }

    public class UnProcessableEntityObjectResult : ObjectResult
    {
        public UnProcessableEntityObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status422UnprocessableEntity;
        }
    }

    public class LockedObjectResult : ObjectResult
    {
        public LockedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status423Locked;
        }
    }

    public class FailedDependencyObjectResult : ObjectResult
    {
        public FailedDependencyObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status424FailedDependency;
        }
    }

    public class UpgradeRequiredObjectResult : ObjectResult
    {
        public UpgradeRequiredObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status426UpgradeRequired;
        }
    }

    public class PreConditionRequiredObjectResult : ObjectResult
    {
        public PreConditionRequiredObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status428PreconditionRequired;
        }
    }

    public class TooManyRequestObjectResult : ObjectResult
    {
        public TooManyRequestObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status429TooManyRequests;
        }
    }

    public class RequestHeaderFieldsTooLargeObjectResult : ObjectResult
    {
        public RequestHeaderFieldsTooLargeObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status429TooManyRequests;
        }
    }

    public class UnavailableForLegalReasonsObjectResult : ObjectResult
    {
        public UnavailableForLegalReasonsObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status451UnavailableForLegalReasons;
        }
    }

    #endregion

    #region HTTP Status 5xx

    public class InternalServerErrorObjectResult : ObjectResult
    {
        public InternalServerErrorObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status500InternalServerError;
        }
    }

    public class NotImplementedObjectResult : ObjectResult
    {
        public NotImplementedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status501NotImplemented;
        }
    }

    public class BadBadGatewayObjectResult : ObjectResult
    {
        public BadBadGatewayObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status502BadGateway;
        }
    }

    public class ServiceUnavailableObjectresult : ObjectResult
    {
        public ServiceUnavailableObjectresult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status503ServiceUnavailable;
        }
    }

    public class GatewayTimeoutObjectResult : ObjectResult
    {
        public GatewayTimeoutObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status504GatewayTimeout;
        }
    }

    public class HttpVersionNotSupportedObjectResult : ObjectResult
    {
        public HttpVersionNotSupportedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status505HttpVersionNotsupported;
        }
    }

    public class VariantAlsoNegotiatesObjectResult : ObjectResult
    {
        public VariantAlsoNegotiatesObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status506VariantAlsoNegotiates;
        }
    }

    public class InsufficientStorageObjectResult : ObjectResult
    {
        public InsufficientStorageObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status507InsufficientStorage;
        }
    }

    public class LoopDetectedObjectResult : ObjectResult
    {
        public LoopDetectedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status508LoopDetected;
        }
    }

    public class NotExtendedObjectResult : ObjectResult
    {
        public NotExtendedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status510NotExtended;
        }
    }

    public class NetworkAuthenticationRequiredObjectResult : ObjectResult
    {
        public NetworkAuthenticationRequiredObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status511NetworkAuthenticationRequired;
        }
    }

    public class NetworkConnectionTimeoutErrorObjectResult : ObjectResult
    {
        public NetworkConnectionTimeoutErrorObjectResult(object value) : base(value)
        {
            StatusCode = 599;
        }
    }

    #endregion
}


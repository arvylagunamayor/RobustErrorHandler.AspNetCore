using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobustErrorHandler.AspNetCore
{
    #region HTTP STATUS 1xx

    public class ContinueObjectResult : ObjectResult
    {
        public ContinueObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status100Continue;
        }
    }

    public class SwitchingProtocolsObjectResult : ObjectResult
    {
        public SwitchingProtocolsObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status101SwitchingProtocols;
        }
    }

    public class ProcessingObjectresult : ObjectResult
    {
        public ProcessingObjectresult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status102Processing;
        }
    }

    #endregion

    #region HTTP STATUS 2xx

    public class CreatedObjectResult : ObjectResult
    {
        public CreatedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status201Created;
        }
    }

    public class AcceptedObjectResult : ObjectResult
    {
        public AcceptedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status202Accepted;
        }
    }

    public class NonAuthoritativeInformationObjectResult : ObjectResult
    {
        public NonAuthoritativeInformationObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status203NonAuthoritative;
        }
    }

    public class NoContentObjectResult : ObjectResult
    {
        public NoContentObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status204NoContent;
        }
    }

    public class ResetContentObjectResult : ObjectResult
    {
        public ResetContentObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status205ResetContent;
        }
    }

    public class PartialContentObjectresult : ObjectResult
    {
        public PartialContentObjectresult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status206PartialContent;
        }
    }

    public class MultiStatusObjectResult : ObjectResult
    {
        public MultiStatusObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status207MultiStatus;
        }
    }

    public class AlreadyReportedObjectResult : ObjectResult
    {
        public AlreadyReportedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status208AlreadyReported;
        }
    }

    public class ImUsedObjectResult : ObjectResult
    {
        public ImUsedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status226IMUsed;
        }
    }

    #endregion

    #region HTTP STATUS 3xx


    public class MutipleChoicesObjectResult : ObjectResult
    {
        public MutipleChoicesObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status300MultipleChoices;
        }
    }

    public class MovedPermanentlyObjectResult : ObjectResult
    {
        public MovedPermanentlyObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status301MovedPermanently;
        }
    }

    public class FoundObjectResult : ObjectResult
    {
        public FoundObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status302Found;
        }
    }

    public class SeeOtherObjectResult : ObjectResult
    {
        public SeeOtherObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status303SeeOther;
        }
    }

    public class NotModifiedObjectResult : ObjectResult
    {
        public NotModifiedObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status304NotModified;
        }
    }

    public class UseProxyObjectResult : ObjectResult
    {
        public UseProxyObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status305UseProxy;
        }
    }

    public class TemporaryRedirectObjectResult : ObjectResult
    {
        public TemporaryRedirectObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status307TemporaryRedirect;
        }
    }

    public class PermanentRedirectObjectResult : ObjectResult
    {
        public PermanentRedirectObjectResult(object value) : base(value)
        {
            StatusCode = StatusCodes.Status308PermanentRedirect;
        }
    }

    #endregion

}

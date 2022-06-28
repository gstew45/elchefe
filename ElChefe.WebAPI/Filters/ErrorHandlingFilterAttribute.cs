using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ElChefe.WebAPI.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
	public override void OnException(ExceptionContext context)
	{
		Exception exception = context.Exception;

		var problemDetails = new ProblemDetails
		{
			Title = "An error occurred while processing your request.",
			Status = (int)HttpStatusCode.InternalServerError,
			Detail = exception.Message
		};

		context.Result = new ObjectResult(problemDetails);
		context.ExceptionHandled = true;
	}
}
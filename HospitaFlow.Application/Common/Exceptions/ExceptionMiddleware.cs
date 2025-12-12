using Microsoft.AspNetCore.Http;

namespace HospitaFlow.Application.Common.Exceptions
{
    using Microsoft.AspNetCore.Http;
    using System.Text.Json;

    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";

            var response = ex switch
            {
                NotFoundException nf => new ErrorResponse(StatusCodes.Status404NotFound, nf.Message),
                BusinessException be => new ErrorResponse(StatusCodes.Status400BadRequest, be.Message),
                CustomValidationException ve => new ErrorResponse(StatusCodes.Status422UnprocessableEntity, ve.Message, ve.Errors),

                _ => new ErrorResponse(StatusCodes.Status500InternalServerError, "An unexpected error occurred", ex.Message)
            };

            context.Response.StatusCode = response.StatusCode;

            var json = JsonSerializer.Serialize(response);
            await context.Response.WriteAsync(json);
        }

        public record ErrorResponse(int StatusCode, string Message, object? Details = null);
    }


}

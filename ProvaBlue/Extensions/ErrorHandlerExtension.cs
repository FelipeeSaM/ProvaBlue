
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace ProvaBlue.Extensions {
    public class ErrorHandlerExtension : IMiddleware {
        private readonly ILogger<ErrorHandlerExtension> _logger;

        public ErrorHandlerExtension(ILogger<ErrorHandlerExtension> logger) {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next) {
            try {
                await next(context);
            }
            catch(Exception e) {

                _logger.LogError(e, e.Message);

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                ProblemDetails details = new() {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Type = "Erro no servidor",
                    Title = "Erro interno",
                    Detail = "Ocorreu algum erro na solicitação. Contacte o administrador do sistema."
                };

                string jsonDetails = JsonSerializer.Serialize(details);

                context.Response.ContentType = "application/json"; // assumindo que as APIs que consomem estão configuradas para processarem json e não XML

                await context.Response.WriteAsync(jsonDetails);
            }
        }
    }
}

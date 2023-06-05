namespace CustomMiddlewares.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext) 
        {
            _logger.LogInformation($"{DateTime.Now} anında gelen request methodu: {httpContext.Request.Method}. Talebin gönderildiği adresi: {httpContext.Request.Path} ");
            var responseBodyStream = httpContext.Response.Body;
            var responseStream = new MemoryStream();
            httpContext.Response.Body = responseStream;
            await _next(httpContext);
            responseStream.Seek(0, SeekOrigin.Begin);
            var responseBody = new StreamReader(responseStream).ReadToEnd();
            _logger.LogInformation($"{DateTime.Now} Response oluştu: {httpContext.Response.StatusCode} --> \n {responseBody}");

            responseStream.Seek(0, SeekOrigin.Begin);
            await responseStream.CopyToAsync(responseBodyStream);
        }

    }
}

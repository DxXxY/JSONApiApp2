using JSONApiApp.Model.Entity;

namespace JSONApiApp.Service
{
    public class RequestMiddleware
    {
        private readonly RequestDelegate _next;
        private ServiceKnowHost serviceKnowHost;

        public RequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            KnowHost newKnowHost= await context.Request.ReadFromJsonAsync<KnowHost>();
            serviceKnowHost.AddKnowHost(newKnowHost);
            await _next(context);
        }
    }
}

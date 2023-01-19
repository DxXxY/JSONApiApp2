using JSONApiApp.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace JSONApiApp.Service
{
    public class RequestMiddleware
    {
        private readonly RequestDelegate _next;
        private ServiceKnowHost serviceKnowHost;

        public RequestMiddleware(RequestDelegate next,ServiceKnowHost serviceKnowHost)
        {
            this.serviceKnowHost= serviceKnowHost;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            KnowHost newKnowHost = new KnowHost()
            {
                Info = context.Connection.RemoteIpAddress.ToString()
            };
            //await context.Request.ReadFromJsonAsync<KnowHost>();
            serviceKnowHost.AddKnowHost(newKnowHost);
            await _next(context);
        }
        public async Task<bool> isUserNew(HttpContext context)
        {
            bool isNew =  serviceKnowHost.isNewKnowHost(context.Connection.RemoteIpAddress.ToString());
            return isNew;
        } 
    }
}

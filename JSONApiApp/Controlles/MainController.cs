using JSONApiApp.Message;

namespace JSONApiApp.Controlles
{
    public class MainController
    {
        public async Task Status(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new BaseMessage.StatusMessage
                (context.Request.Host.Port, System.Net.Dns.GetHostName()));
        }
        
        public async Task Info(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new BaseMessage.StringMessage("/ping, /status, /info"));
        }
    }
}

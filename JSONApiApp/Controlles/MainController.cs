using JSONApiApp.Message;
using JSONApiApp.Model.Entity;
using JSONApiApp.Service;
using static JSONApiApp.Message.RequestMessage;

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
            await context.Response.WriteAsJsonAsync(new BaseMessage.StringMessage("/ping, /status, /info, /conver (wrtite number:**,nameNumberInput:(byte,Kbyte,Mbyte,Gbyte,Ter),nameNumberOutput:(byte,Kbyte,Mbyte,Gbyte,Ter)"));
        }
      
    }
}

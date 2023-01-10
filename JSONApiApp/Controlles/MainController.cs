using JSONApiApp.Message;
using JSONApiApp.Model.Entity;
using JSONApiApp.Service;
using static JSONApiApp.Message.KnowHostMessage;
using static JSONApiApp.Message.RequestMessage;

namespace JSONApiApp.Controlles
{
    public class MainController
    {
        ServiceKnowHost serviceKnowHost;
        ServiceMyRequest serviceMyRequest;
        public async Task Status(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new BaseMessage.StatusMessage
                (context.Request.Host.Port, System.Net.Dns.GetHostName()));
        }
        
        public async Task Info(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new BaseMessage.StringMessage("/ping, /status, /info"));
        }
        public async Task KnownHost(HttpContext context)
        {
            List<KnowHost> knowHostsList = serviceKnowHost.GetKnowHost();
            await context.Response.WriteAsJsonAsync(new KnowHostList(knowHostsList));
        }
        public async Task HostRequest(HttpContext context)
        {
            List<MyRequest> requestList = serviceMyRequest.GetMyRequest();
            await context.Response.WriteAsJsonAsync(new RequestList(requestList));
        }

    }
}

using JSONApiApp.Model.Entity;

namespace JSONApiApp.Message
{
    public class RequestMessage
    {
        public record RequestList(List<MyRequest> MyRequests);
    }
}

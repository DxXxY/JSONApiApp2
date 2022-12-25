namespace JSONApiApp.Message
{
    public class BaseMessage
    {
        public record StringMessage(string info);
        public record StatusMessage(int? Port,string name);
        
    }
}

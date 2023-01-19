using JSONApiApp.Model.Entity;

namespace JSONApiApp.Message
{
    public class KnowHostMessage
    {
        public record KnowHostList(List<KnowHost>KnowHosts);
    }
}

namespace Mundipagg.NetStandard
{
    public partial class Configuration
    {
        public static string DefaultBaseUri = "https://api.mundipagg.com/core/v1";

        public Configuration(string secretKey)
        {
            this.BasicAuthUserName = secretKey;
        }

        public string BaseUri { get; private set; } = DefaultBaseUri;
        
        public string BasicAuthUserName { get; private set; }

        public string BasicAuthPassword { get; private set; }
    }
}
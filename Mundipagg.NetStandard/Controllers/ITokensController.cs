using System.Threading.Tasks;

namespace Mundipagg.NetStandard.Controllers
{
    public partial interface ITokensController
    {
        Configuration Configuration { get; set; }

        /// <summary>
        /// Gets a token from its id
        /// </summary>
        /// <param name="id">Required parameter: Token id</param>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Models.GetTokenResponse GetToken(string id, string publicKey);

        /// <summary>
        /// Gets a token from its id
        /// </summary>
        /// <param name="id">Required parameter: Token id</param>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Task<Models.GetTokenResponse> GetTokenAsync(string id, string publicKey);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="request">Required parameter: Request for creating a token</param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Models.GetTokenResponse CreateToken(string publicKey, Models.CreateTokenRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="request">Required parameter: Request for creating a token</param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Task<Models.GetTokenResponse> CreateTokenAsync(string publicKey, Models.CreateTokenRequest request);

    }
} 
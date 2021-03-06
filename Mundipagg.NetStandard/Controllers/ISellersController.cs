using System;
using System.Threading.Tasks;

namespace Mundipagg.NetStandard.Controllers
{
    public partial interface ISellersController
    {
        Configuration Configuration { get; set; }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Seller Id</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Models.GetSellerResponse GetSellerById(string id);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Seller Id</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Task<Models.GetSellerResponse> GetSellerByIdAsync(string id);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Models.GetSellerResponse DeleteSeller(string sellerId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Task<Models.GetSellerResponse> DeleteSellerAsync(string sellerId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="request">Required parameter: Seller Model</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Models.GetSellerResponse CreateSeller(Models.CreateSellerRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="request">Required parameter: Seller Model</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Task<Models.GetSellerResponse> CreateSellerAsync(Models.CreateSellerRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="name">Optional parameter: Example: </param>
        /// <param name="document">Optional parameter: Example: </param>
        /// <param name="code">Optional parameter: Example: </param>
        /// <param name="status">Optional parameter: Example: </param>
        /// <param name="type">Optional parameter: Example: </param>
        /// <param name="createdSince">Optional parameter: Example: </param>
        /// <param name="createdUntil">Optional parameter: Example: </param>
        /// <return>Returns the Models.ListSellerResponse response from the API call</return>
        Models.ListSellerResponse GetSellers(
                int? page = null,
                int? size = null,
                string name = null,
                string document = null,
                string code = null,
                string status = null,
                string type = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="name">Optional parameter: Example: </param>
        /// <param name="document">Optional parameter: Example: </param>
        /// <param name="code">Optional parameter: Example: </param>
        /// <param name="status">Optional parameter: Example: </param>
        /// <param name="type">Optional parameter: Example: </param>
        /// <param name="createdSince">Optional parameter: Example: </param>
        /// <param name="createdUntil">Optional parameter: Example: </param>
        /// <return>Returns the Models.ListSellerResponse response from the API call</return>
        Task<Models.ListSellerResponse> GetSellersAsync(
                int? page = null,
                int? size = null,
                string name = null,
                string document = null,
                string code = null,
                string status = null,
                string type = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Update Seller model</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Models.GetSellerResponse UpdateSeller(string id, Models.UpdateSellerRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Update Seller model</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Task<Models.GetSellerResponse> UpdateSellerAsync(string id, Models.UpdateSellerRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Models.GetSellerResponse UpdateSellerMetadata(string sellerId, Models.UpdateMetadataRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Task<Models.GetSellerResponse> UpdateSellerMetadataAsync(string sellerId, Models.UpdateMetadataRequest request);

    }
} 
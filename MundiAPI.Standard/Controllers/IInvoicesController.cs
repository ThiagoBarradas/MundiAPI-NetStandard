/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundiAPI.Standard;
using MundiAPI.Standard.Utilities;
using MundiAPI.Standard.Http.Request;
using MundiAPI.Standard.Http.Response;
using MundiAPI.Standard.Http.Client;

namespace MundiAPI.Standard.Controllers
{
    public partial interface IInvoicesController
    {
        /// <summary>
        /// Cancels an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id</param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        Models.GetInvoiceResponse CancelInvoice(string invoiceId);

        /// <summary>
        /// Cancels an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id</param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        Task<Models.GetInvoiceResponse> CancelInvoiceAsync(string invoiceId);

        /// <summary>
        /// Gets the last charge from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Models.GetChargeResponse GetLastInvoiceCharge(string invoiceId);

        /// <summary>
        /// Gets the last charge from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<Models.GetChargeResponse> GetLastInvoiceChargeAsync(string invoiceId);

        /// <summary>
        /// Gets all invoices
        /// </summary>
        /// <return>Returns the Models.ListInvoicesResponse response from the API call</return>
        Models.ListInvoicesResponse GetInvoices();

        /// <summary>
        /// Gets all invoices
        /// </summary>
        /// <return>Returns the Models.ListInvoicesResponse response from the API call</return>
        Task<Models.ListInvoicesResponse> GetInvoicesAsync();

        /// <summary>
        /// Gets an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        Models.GetInvoiceResponse GetInvoice(string invoiceId);

        /// <summary>
        /// Gets an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        Task<Models.GetInvoiceResponse> GetInvoiceAsync(string invoiceId);

        /// <summary>
        /// Updates the metadata from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata</param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        Models.GetInvoiceResponse UpdateInvoiceMetadata(string invoiceId, Models.UpdateMetadataRequest request);

        /// <summary>
        /// Updates the metadata from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata</param>
        /// <return>Returns the Models.GetInvoiceResponse response from the API call</return>
        Task<Models.GetInvoiceResponse> UpdateInvoiceMetadataAsync(string invoiceId, Models.UpdateMetadataRequest request);

    }
} 
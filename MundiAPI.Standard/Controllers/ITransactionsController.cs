/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
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
    public partial interface ITransactionsController
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="transactionId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransactionResponse response from the API call</return>
        Models.GetTransactionResponse GetTransaction(string transactionId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="transactionId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransactionResponse response from the API call</return>
        Task<Models.GetTransactionResponse> GetTransactionAsync(string transactionId);

    }
} 
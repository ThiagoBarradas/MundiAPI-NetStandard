/*
 * PagarmeAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using PagarmeAPI.Standard.Controllers;
using APIMATIC.SDK.Http.Client;
using APIMATIC.SDK.Common;

namespace PagarmeAPI.Standard
{
    public partial class PagarmeAPIClient
    {

        /// <summary>
        /// Singleton access to Transactions controller
        /// </summary>
        public Transactions Transactions
        {
            get
            {
                return PagarmeAPI.Standard.Controllers.Transactions.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Recipients controller
        /// </summary>
        public Recipients Recipients
        {
            get
            {
                return PagarmeAPI.Standard.Controllers.Recipients.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Withdrawals controller
        /// </summary>
        public Withdrawals Withdrawals
        {
            get
            {
                return PagarmeAPI.Standard.Controllers.Withdrawals.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Transfers controller
        /// </summary>
        public Transfers Transfers
        {
            get
            {
                return PagarmeAPI.Standard.Controllers.Transfers.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public PagarmeAPIClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public PagarmeAPIClient(string apiKey)
        {
            Configuration.ApiKey = apiKey;
        }
        #endregion
    }
}
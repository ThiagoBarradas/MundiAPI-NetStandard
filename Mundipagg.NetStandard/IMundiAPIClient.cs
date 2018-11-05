using Mundipagg.NetStandard.Controllers;

namespace Mundipagg.NetStandard
{
    public partial interface IMundiAPIClient
    {

        /// <summary>
        /// Subscriptions controller
        /// </summary>
        ISubscriptionsController Subscriptions { get;}

        /// <summary>
        /// Orders controller
        /// </summary>
        IOrdersController Orders { get;}

        /// <summary>
        /// Plans controller
        /// </summary>
        IPlansController Plans { get;}

        /// <summary>
        /// Invoices controller
        /// </summary>
        IInvoicesController Invoices { get;}

        /// <summary>
        /// Customers controller
        /// </summary>
        ICustomersController Customers { get;}

        /// <summary>
        /// Charges controller
        /// </summary>
        IChargesController Charges { get;}

        /// <summary>
        /// Recipients controller
        /// </summary>
        IRecipientsController Recipients { get;}

        /// <summary>
        /// Tokens controller
        /// </summary>
        ITokensController Tokens { get;}

        /// <summary>
        /// Sellers controller
        /// </summary>
        ISellersController Sellers { get;}

        /// <summary>
        /// Set secret key
        /// </summary>
        /// <param name="secretKey"></param>
        void SetSecretKey(string secretKey)
    }
}
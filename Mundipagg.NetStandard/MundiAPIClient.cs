using Mundipagg.NetStandard.Controllers;

namespace Mundipagg.NetStandard
{
    public partial class MundiAPIClient: IMundiAPIClient
    {
        /// <summary>
        /// Subscriptions controller
        /// </summary>
        public ISubscriptionsController Subscriptions { get; set; } = new SubscriptionsController();

        /// <summary>
        /// Orders controller
        /// </summary>
        public IOrdersController Orders { get; set; } = new OrdersController();

        /// <summary>
        /// Plans controller
        /// </summary>
        public IPlansController Plans { get; set; } = new PlansController();

        /// <summary>
        /// Invoices controller
        /// </summary>
        public IInvoicesController Invoices { get; set; } = new InvoicesController();

        /// <summary>
        /// Customers controller
        /// </summary>
        public ICustomersController Customers { get; set; } = new CustomersController();

        /// <summary>
        /// Charges controller
        /// </summary>
        public IChargesController Charges { get; set; } = new ChargesController();

        /// <summary>
        /// Recipients controller
        /// </summary>
        public IRecipientsController Recipients { get; set; } = new RecipientsController();

        /// <summary>
        /// Tokens controller
        /// </summary>
        public ITokensController Tokens { get; set; } = new TokensController();

        /// <summary>
        /// Sellers controller
        /// </summary>
        public ISellersController Sellers { get; set; } = new SellersController();
        
        public MundiAPIClient() { }
        
        public MundiAPIClient(string secretKey)
        {
            this.SetSecretKey(secretKey);
        }
        
        public void SetSecretKey(string secretKey)
        {
            this.Configuration = new Configuration(secretKey);
        }

        private Configuration _configuration { get; set; }

        public Configuration Configuration
        {
            get { return _configuration; }
            set
            {
                this._configuration = value;
                this.Charges.Configuration = this._configuration;
                this.Customers.Configuration = this._configuration;
                this.Invoices.Configuration = this._configuration;
                this.Orders.Configuration = this._configuration;
                this.Plans.Configuration = this._configuration;
                this.Recipients.Configuration = this._configuration;
                this.Sellers.Configuration = this._configuration;
                this.Subscriptions.Configuration = this._configuration;
                this.Tokens.Configuration = this._configuration;
            }
        }
    }
}
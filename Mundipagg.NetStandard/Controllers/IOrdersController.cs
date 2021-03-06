using System;
using System.Threading.Tasks;

namespace Mundipagg.NetStandard.Controllers
{
    public partial interface IOrdersController
    {
        Configuration Configuration { get; set; }

        /// <summary>
        /// Gets an order
        /// </summary>
        /// <param name="orderId">Required parameter: Order id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse GetOrder(string orderId);

        /// <summary>
        /// Gets an order
        /// </summary>
        /// <param name="orderId">Required parameter: Order id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> GetOrderAsync(string orderId);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse CreateOrder(Models.CreateOrderRequest body);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> CreateOrderAsync(Models.CreateOrderRequest body);

        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for order's code</param>
        /// <param name="status">Optional parameter: Filter for order's status</param>
        /// <param name="createdSince">Optional parameter: Filter for order's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for order's creation date end range</param>
        /// <param name="customerId">Optional parameter: Filter for order's customer id</param>
        /// <return>Returns the Models.ListOrderResponse response from the API call</return>
        Models.ListOrderResponse GetOrders(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string customerId = null);

        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for order's code</param>
        /// <param name="status">Optional parameter: Filter for order's status</param>
        /// <param name="createdSince">Optional parameter: Filter for order's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for order's creation date end range</param>
        /// <param name="customerId">Optional parameter: Filter for order's customer id</param>
        /// <return>Returns the Models.ListOrderResponse response from the API call</return>
        Task<Models.ListOrderResponse> GetOrdersAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string customerId = null);

        /// <summary>
        /// Updates the metadata from an order
        /// </summary>
        /// <param name="orderId">Required parameter: The order id</param>
        /// <param name="request">Required parameter: Request for updating the order metadata</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse UpdateOrderMetadata(string orderId, Models.UpdateMetadataRequest request);

        /// <summary>
        /// Updates the metadata from an order
        /// </summary>
        /// <param name="orderId">Required parameter: The order id</param>
        /// <param name="request">Required parameter: Request for updating the order metadata</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> UpdateOrderMetadataAsync(string orderId, Models.UpdateMetadataRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse DeleteAllOrderItems(string orderId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> DeleteAllOrderItemsAsync(string orderId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="request">Required parameter: Item Model</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Models.GetOrderItemResponse UpdateOrderItem(string orderId, string itemId, Models.UpdateOrderItemRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="request">Required parameter: Item Model</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Task<Models.GetOrderItemResponse> UpdateOrderItemAsync(string orderId, string itemId, Models.UpdateOrderItemRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Models.GetOrderItemResponse DeleteOrderItem(string orderId, string itemId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Task<Models.GetOrderItemResponse> DeleteOrderItemAsync(string orderId, string itemId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Order Item Model</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Models.GetOrderItemResponse CreateOrderItem(string orderId, Models.CreateOrderItemRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Order Item Model</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Task<Models.GetOrderItemResponse> CreateOrderItemAsync(string orderId, Models.CreateOrderItemRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Models.GetOrderItemResponse GetOrderItem(string orderId, string itemId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Task<Models.GetOrderItemResponse> GetOrderItemAsync(string orderId, string itemId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Update Order Model</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse UpdateOrderStatus(string id, Models.UpdateOrderStatusRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Update Order Model</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> UpdateOrderStatusAsync(string id, Models.UpdateOrderStatusRequest request);

    }
} 
using Mundipagg.NetStandard.Exceptions;
using Mundipagg.NetStandard.Http.Client;
using Mundipagg.NetStandard.Http.Request;
using Mundipagg.NetStandard.Http.Response;
using Mundipagg.NetStandard.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mundipagg.NetStandard.Controllers
{
    public partial class ChargesController: BaseController, IChargesController
    {
        /// <summary>
        /// Updates the card from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating a charge's card</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public Models.GetChargeResponse UpdateChargeCard(string chargeId, Models.UpdateChargeCardRequest request)
        {
            Task<Models.GetChargeResponse> t = UpdateChargeCardAsync(chargeId, request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the card from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating a charge's card</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public async Task<Models.GetChargeResponse> UpdateChargeCardAsync(string chargeId, Models.UpdateChargeCardRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/charges/{charge_id}/card");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 0.13.40" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetChargeResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Updates a charge's payment method
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public Models.GetChargeResponse UpdateChargePaymentMethod(string chargeId, Models.UpdateChargePaymentMethodRequest request)
        {
            Task<Models.GetChargeResponse> t = UpdateChargePaymentMethodAsync(chargeId, request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates a charge's payment method
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public async Task<Models.GetChargeResponse> UpdateChargePaymentMethodAsync(string chargeId, Models.UpdateChargePaymentMethodRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/charges/{charge_id}/payment-method");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 0.13.40" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetChargeResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Creates a new charge
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public Models.GetChargeResponse CreateCharge(Models.CreateChargeRequest request)
        {
            Task<Models.GetChargeResponse> t = CreateChargeAsync(request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new charge
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public async Task<Models.GetChargeResponse> CreateChargeAsync(Models.CreateChargeRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Charges");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 0.13.40" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetChargeResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get a charge from its id
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public Models.GetChargeResponse GetCharge(string chargeId)
        {
            Task<Models.GetChargeResponse> t = GetChargeAsync(chargeId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a charge from its id
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public async Task<Models.GetChargeResponse> GetChargeAsync(string chargeId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/charges/{charge_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 0.13.40" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetChargeResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retries a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public Models.GetChargeResponse RetryCharge(string chargeId)
        {
            Task<Models.GetChargeResponse> t = RetryChargeAsync(chargeId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retries a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public async Task<Models.GetChargeResponse> RetryChargeAsync(string chargeId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/charges/{charge_id}/retry");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 0.13.40" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetChargeResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Lists all charges
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for charge's code</param>
        /// <param name="status">Optional parameter: Filter for charge's status</param>
        /// <param name="paymentMethod">Optional parameter: Filter for charge's payment method</param>
        /// <param name="customerId">Optional parameter: Filter for charge's customer id</param>
        /// <param name="orderId">Optional parameter: Filter for charge's order id</param>
        /// <param name="createdSince">Optional parameter: Filter for the beginning of the range for charge's creation</param>
        /// <param name="createdUntil">Optional parameter: Filter for the end of the range for charge's creation</param>
        /// <return>Returns the Models.ListChargesResponse response from the API call</return>
        public Models.ListChargesResponse GetCharges(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                string paymentMethod = null,
                string customerId = null,
                string orderId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
        {
            Task<Models.ListChargesResponse> t = GetChargesAsync(page, size, code, status, paymentMethod, customerId, orderId, createdSince, createdUntil);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Lists all charges
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for charge's code</param>
        /// <param name="status">Optional parameter: Filter for charge's status</param>
        /// <param name="paymentMethod">Optional parameter: Filter for charge's payment method</param>
        /// <param name="customerId">Optional parameter: Filter for charge's customer id</param>
        /// <param name="orderId">Optional parameter: Filter for charge's order id</param>
        /// <param name="createdSince">Optional parameter: Filter for the beginning of the range for charge's creation</param>
        /// <param name="createdUntil">Optional parameter: Filter for the end of the range for charge's creation</param>
        /// <return>Returns the Models.ListChargesResponse response from the API call</return>
        public async Task<Models.ListChargesResponse> GetChargesAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                string paymentMethod = null,
                string customerId = null,
                string orderId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/charges");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "code", code },
                { "status", status },
                { "payment_method", paymentMethod },
                { "customer_id", customerId },
                { "order_id", orderId },
                { "created_since", (createdSince.HasValue) ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "created_until", (createdUntil.HasValue) ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 0.13.40" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ListChargesResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Updates the metadata from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: The charge id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public Models.GetChargeResponse UpdateChargeMetadata(string chargeId, Models.UpdateMetadataRequest request)
        {
            Task<Models.GetChargeResponse> t = UpdateChargeMetadataAsync(chargeId, request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the metadata from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: The charge id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public async Task<Models.GetChargeResponse> UpdateChargeMetadataAsync(string chargeId, Models.UpdateMetadataRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Charges/{charge_id}/metadata");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 0.13.40" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetChargeResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Cancel a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public Models.GetChargeResponse CancelCharge(string chargeId, Models.CreateCancelChargeRequest request = null)
        {
            Task<Models.GetChargeResponse> t = CancelChargeAsync(chargeId, request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Cancel a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public async Task<Models.GetChargeResponse> CancelChargeAsync(string chargeId, Models.CreateCancelChargeRequest request = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/charges/{charge_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 0.13.40" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.DeleteBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetChargeResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Captures a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for capturing a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public Models.GetChargeResponse CaptureCharge(string chargeId, Models.CreateCaptureChargeRequest request = null)
        {
            Task<Models.GetChargeResponse> t = CaptureChargeAsync(chargeId, request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Captures a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for capturing a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public async Task<Models.GetChargeResponse> CaptureChargeAsync(string chargeId, Models.CreateCaptureChargeRequest request = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/charges/{charge_id}/capture");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 0.13.40" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetChargeResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Updates the due date from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Required parameter: Request for updating the due date</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public Models.GetChargeResponse UpdateChargeDueDate(string chargeId, Models.UpdateChargeDueDateRequest request)
        {
            Task<Models.GetChargeResponse> t = UpdateChargeDueDateAsync(chargeId, request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the due date from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Required parameter: Request for updating the due date</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public async Task<Models.GetChargeResponse> UpdateChargeDueDateAsync(string chargeId, Models.UpdateChargeDueDateRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Charges/{charge_id}/due-date");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 0.13.40" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetChargeResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="chargeId">Required parameter: Example: </param>
        /// <param name="request">Optional parameter: Request for confirm payment</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public Models.GetChargeResponse ConfirmPayment(string chargeId, Models.CreateConfirmPaymentRequest request = null)
        {
            Task<Models.GetChargeResponse> t = ConfirmPaymentAsync(chargeId, request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="chargeId">Required parameter: Example: </param>
        /// <param name="request">Optional parameter: Request for confirm payment</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        public async Task<Models.GetChargeResponse> ConfirmPaymentAsync(string chargeId, Models.CreateConfirmPaymentRequest request = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/charges/{charge_id}/confirm-payment");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK - DotNet 0.13.40" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetChargeResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 
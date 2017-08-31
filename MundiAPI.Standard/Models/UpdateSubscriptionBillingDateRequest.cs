/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.Standard;
using MundiAPI.Standard.Utilities;


namespace MundiAPI.Standard.Models
{
    public class UpdateSubscriptionBillingDateRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime nextBillingAt;

        /// <summary>
        /// The date when the next subscription billing must occur
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_billing_at")]
        public DateTime NextBillingAt 
        { 
            get 
            {
                return this.nextBillingAt; 
            } 
            set 
            {
                this.nextBillingAt = value;
                onPropertyChanged("NextBillingAt");
            }
        }
    }
} 
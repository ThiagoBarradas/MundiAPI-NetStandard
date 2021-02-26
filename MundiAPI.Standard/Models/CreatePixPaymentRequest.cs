/*
 * MundiAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
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
    public class CreatePixPaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime? expiresAt;
        private int? expiresIn;
        private List<Models.PixAdditionalInformation> additionalInformation;

        /// <summary>
        /// Datetime when pix payment will expire
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt 
        { 
            get 
            {
                return this.expiresAt; 
            } 
            set 
            {
                this.expiresAt = value;
                onPropertyChanged("ExpiresAt");
            }
        }

        /// <summary>
        /// Seconds until pix payment expires
        /// </summary>
        [JsonProperty("expires_in")]
        public int? ExpiresIn 
        { 
            get 
            {
                return this.expiresIn; 
            } 
            set 
            {
                this.expiresIn = value;
                onPropertyChanged("ExpiresIn");
            }
        }

        /// <summary>
        /// Pix additional information
        /// </summary>
        [JsonProperty("additional_information")]
        public List<Models.PixAdditionalInformation> AdditionalInformation 
        { 
            get 
            {
                return this.additionalInformation; 
            } 
            set 
            {
                this.additionalInformation = value;
                onPropertyChanged("AdditionalInformation");
            }
        }
    }
} 
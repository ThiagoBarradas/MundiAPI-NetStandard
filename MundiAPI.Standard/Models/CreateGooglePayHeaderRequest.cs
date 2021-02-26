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
    public class CreateGooglePayHeaderRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string ephemeralPublicKey;

        /// <summary>
        /// X.509 encoded key bytes, Base64 encoded as a string
        /// </summary>
        [JsonProperty("ephemeral_public_key")]
        public string EphemeralPublicKey 
        { 
            get 
            {
                return this.ephemeralPublicKey; 
            } 
            set 
            {
                this.ephemeralPublicKey = value;
                onPropertyChanged("EphemeralPublicKey");
            }
        }
    }
} 
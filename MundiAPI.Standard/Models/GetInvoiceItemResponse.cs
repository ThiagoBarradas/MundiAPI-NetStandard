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
    public class GetInvoiceItemResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int amount;
        private string description;
        private Models.GetPricingSchemeResponse pricingScheme;
        private Models.GetPriceBracketResponse priceBracket;
        private int? quantity;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public int Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.GetPricingSchemeResponse PricingScheme 
        { 
            get 
            {
                return this.pricingScheme; 
            } 
            set 
            {
                this.pricingScheme = value;
                onPropertyChanged("PricingScheme");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("price_bracket")]
        public Models.GetPriceBracketResponse PriceBracket 
        { 
            get 
            {
                return this.priceBracket; 
            } 
            set 
            {
                this.priceBracket = value;
                onPropertyChanged("PriceBracket");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity 
        { 
            get 
            {
                return this.quantity; 
            } 
            set 
            {
                this.quantity = value;
                onPropertyChanged("Quantity");
            }
        }
    }
} 
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
    public class GetPricingSchemeResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int price;
        private string schemeType;
        private List<Models.GetPriceBracketResponse> priceBrackets;
        private int? minimumPrice;
        private double? percentage;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("price")]
        public int Price 
        { 
            get 
            {
                return this.price; 
            } 
            set 
            {
                this.price = value;
                onPropertyChanged("Price");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("scheme_type")]
        public string SchemeType 
        { 
            get 
            {
                return this.schemeType; 
            } 
            set 
            {
                this.schemeType = value;
                onPropertyChanged("SchemeType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("price_brackets")]
        public List<Models.GetPriceBracketResponse> PriceBrackets 
        { 
            get 
            {
                return this.priceBrackets; 
            } 
            set 
            {
                this.priceBrackets = value;
                onPropertyChanged("PriceBrackets");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("minimum_price")]
        public int? MinimumPrice 
        { 
            get 
            {
                return this.minimumPrice; 
            } 
            set 
            {
                this.minimumPrice = value;
                onPropertyChanged("MinimumPrice");
            }
        }

        /// <summary>
        /// percentual value used in pricing_scheme Percent
        /// </summary>
        [JsonProperty("percentage")]
        public double? Percentage 
        { 
            get 
            {
                return this.percentage; 
            } 
            set 
            {
                this.percentage = value;
                onPropertyChanged("Percentage");
            }
        }
    }
} 
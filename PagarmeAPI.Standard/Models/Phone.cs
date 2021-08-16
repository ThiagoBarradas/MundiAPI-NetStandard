/*
 * PagarmeAPI.Standard
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
using APIMATIC.SDK.Common;


namespace PagarmeAPI.Standard.Models
{
    public class Phone : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string ddd;
        private string number;
        private string type;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ddd")]
        public string Ddd 
        { 
            get 
            {
                return this.ddd; 
            } 
            set 
            {
                this.ddd = value;
                onPropertyChanged("Ddd");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("number")]
        public string Number 
        { 
            get 
            {
                return this.number; 
            } 
            set 
            {
                this.number = value;
                onPropertyChanged("Number");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }
    }
} 
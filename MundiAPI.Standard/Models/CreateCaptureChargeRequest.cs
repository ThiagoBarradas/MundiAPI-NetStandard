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
    public class CreateCaptureChargeRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string code;
        private int? amount;
        private List<Models.CreateSplitRequest> split;
        private string operationReference;

        /// <summary>
        /// Code for the charge. Sending this field will update the code send on the charge and order creation.
        /// </summary>
        [JsonProperty("code")]
        public string Code 
        { 
            get 
            {
                return this.code; 
            } 
            set 
            {
                this.code = value;
                onPropertyChanged("Code");
            }
        }

        /// <summary>
        /// The amount that will be captured
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount 
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
        /// Splits
        /// </summary>
        [JsonProperty("split")]
        public List<Models.CreateSplitRequest> Split 
        { 
            get 
            {
                return this.split; 
            } 
            set 
            {
                this.split = value;
                onPropertyChanged("Split");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("operation_reference")]
        public string OperationReference 
        { 
            get 
            {
                return this.operationReference; 
            } 
            set 
            {
                this.operationReference = value;
                onPropertyChanged("OperationReference");
            }
        }
    }
} 
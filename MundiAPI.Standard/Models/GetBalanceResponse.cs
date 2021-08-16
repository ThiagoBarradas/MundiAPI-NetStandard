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
    public class GetBalanceResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string currency;
        private int availableAmount;
        private Models.GetRecipientResponse recipient;
        private int waitingFundsAmount;
        private int transferredAmount;

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency 
        { 
            get 
            {
                return this.currency; 
            } 
            set 
            {
                this.currency = value;
                onPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// Amount available for transferring
        /// </summary>
        [JsonProperty("available_amount")]
        public int AvailableAmount 
        { 
            get 
            {
                return this.availableAmount; 
            } 
            set 
            {
                this.availableAmount = value;
                onPropertyChanged("AvailableAmount");
            }
        }

        /// <summary>
        /// Recipient
        /// </summary>
        [JsonProperty("recipient")]
        public Models.GetRecipientResponse Recipient 
        { 
            get 
            {
                return this.recipient; 
            } 
            set 
            {
                this.recipient = value;
                onPropertyChanged("Recipient");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("waiting_funds_amount")]
        public int WaitingFundsAmount 
        { 
            get 
            {
                return this.waitingFundsAmount; 
            } 
            set 
            {
                this.waitingFundsAmount = value;
                onPropertyChanged("WaitingFundsAmount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transferred_amount")]
        public int TransferredAmount 
        { 
            get 
            {
                return this.transferredAmount; 
            } 
            set 
            {
                this.transferredAmount = value;
                onPropertyChanged("TransferredAmount");
            }
        }
    }
} 
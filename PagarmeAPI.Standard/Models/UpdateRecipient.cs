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
    public class UpdateRecipient : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.BankAccount bankAccount;
        private string transferInterval;
        private int? transferDay;
        private bool? transferEnabled;
        private int? anticipatableVolumePercentage;
        private bool? automaticAnticipationEnabled;
        private string automaticAnticipationType;
        private string automaticAnticipationDays;
        private int? automaticAnticipation1025Delay;
        private Dictionary<string, string> metadata;
        private string apiKey;
        private bool pixRecipientAsSource = false;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bank_account")]
        public Models.BankAccount BankAccount 
        { 
            get 
            {
                return this.bankAccount; 
            } 
            set 
            {
                this.bankAccount = value;
                onPropertyChanged("BankAccount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transfer_interval")]
        public string TransferInterval 
        { 
            get 
            {
                return this.transferInterval; 
            } 
            set 
            {
                this.transferInterval = value;
                onPropertyChanged("TransferInterval");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transfer_day")]
        public int? TransferDay 
        { 
            get 
            {
                return this.transferDay; 
            } 
            set 
            {
                this.transferDay = value;
                onPropertyChanged("TransferDay");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transfer_enabled")]
        public bool? TransferEnabled 
        { 
            get 
            {
                return this.transferEnabled; 
            } 
            set 
            {
                this.transferEnabled = value;
                onPropertyChanged("TransferEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("anticipatable_volume_percentage")]
        public int? AnticipatableVolumePercentage 
        { 
            get 
            {
                return this.anticipatableVolumePercentage; 
            } 
            set 
            {
                this.anticipatableVolumePercentage = value;
                onPropertyChanged("AnticipatableVolumePercentage");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("automatic_anticipation_enabled")]
        public bool? AutomaticAnticipationEnabled 
        { 
            get 
            {
                return this.automaticAnticipationEnabled; 
            } 
            set 
            {
                this.automaticAnticipationEnabled = value;
                onPropertyChanged("AutomaticAnticipationEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("automatic_anticipation_type")]
        public string AutomaticAnticipationType 
        { 
            get 
            {
                return this.automaticAnticipationType; 
            } 
            set 
            {
                this.automaticAnticipationType = value;
                onPropertyChanged("AutomaticAnticipationType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("automatic_anticipation_days")]
        public string AutomaticAnticipationDays 
        { 
            get 
            {
                return this.automaticAnticipationDays; 
            } 
            set 
            {
                this.automaticAnticipationDays = value;
                onPropertyChanged("AutomaticAnticipationDays");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("automatic_anticipation_1025_delay")]
        public int? AutomaticAnticipation1025Delay 
        { 
            get 
            {
                return this.automaticAnticipation1025Delay; 
            } 
            set 
            {
                this.automaticAnticipation1025Delay = value;
                onPropertyChanged("AutomaticAnticipation1025Delay");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("api_key")]
        public string ApiKey 
        { 
            get 
            {
                return this.apiKey; 
            } 
            set 
            {
                this.apiKey = value;
                onPropertyChanged("ApiKey");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("pix_recipient_as_source")]
        public bool PixRecipientAsSource 
        { 
            get 
            {
                return this.pixRecipientAsSource; 
            } 
            set 
            {
                this.pixRecipientAsSource = value;
                onPropertyChanged("PixRecipientAsSource");
            }
        }
    }
} 
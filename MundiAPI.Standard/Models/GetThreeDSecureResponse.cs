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
    public class GetThreeDSecureResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string mpi;
        private string eci;
        private string cavv;
        private string transactionId;
        private string successUrl;

        /// <summary>
        /// MPI Vendor
        /// </summary>
        [JsonProperty("mpi")]
        public string Mpi 
        { 
            get 
            {
                return this.mpi; 
            } 
            set 
            {
                this.mpi = value;
                onPropertyChanged("Mpi");
            }
        }

        /// <summary>
        /// Electronic Commerce Indicator (ECI) (Opcional)
        /// </summary>
        [JsonProperty("eci")]
        public string Eci 
        { 
            get 
            {
                return this.eci; 
            } 
            set 
            {
                this.eci = value;
                onPropertyChanged("Eci");
            }
        }

        /// <summary>
        /// Online payment cryptogram, definido pelo 3-D Secure.
        /// </summary>
        [JsonProperty("cavv")]
        public string Cavv 
        { 
            get 
            {
                return this.cavv; 
            } 
            set 
            {
                this.cavv = value;
                onPropertyChanged("Cavv");
            }
        }

        /// <summary>
        /// Identificador da transação (XID)
        /// </summary>
        [JsonProperty("transaction_Id")]
        public string TransactionId 
        { 
            get 
            {
                return this.transactionId; 
            } 
            set 
            {
                this.transactionId = value;
                onPropertyChanged("TransactionId");
            }
        }

        /// <summary>
        /// Url de redirecionamento de sucessso
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl 
        { 
            get 
            {
                return this.successUrl; 
            } 
            set 
            {
                this.successUrl = value;
                onPropertyChanged("SuccessUrl");
            }
        }
    }
} 
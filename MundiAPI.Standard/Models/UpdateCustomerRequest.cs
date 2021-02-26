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
    public class UpdateCustomerRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string email;
        private string document;
        private string type;
        private Models.CreateAddressRequest address;
        private Dictionary<string, string> metadata;
        private Models.CreatePhonesRequest phones;
        private string code;
        private string gender;
        private string documentType;

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Document number
        /// </summary>
        [JsonProperty("document")]
        public string Document 
        { 
            get 
            {
                return this.document; 
            } 
            set 
            {
                this.document = value;
                onPropertyChanged("Document");
            }
        }

        /// <summary>
        /// Person type
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

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address")]
        public Models.CreateAddressRequest Address 
        { 
            get 
            {
                return this.address; 
            } 
            set 
            {
                this.address = value;
                onPropertyChanged("Address");
            }
        }

        /// <summary>
        /// Metadata
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
        [JsonProperty("phones")]
        public Models.CreatePhonesRequest Phones 
        { 
            get 
            {
                return this.phones; 
            } 
            set 
            {
                this.phones = value;
                onPropertyChanged("Phones");
            }
        }

        /// <summary>
        /// Código de referência do cliente no sistema da loja. Max: 52 caracteres
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
        /// Gênero do cliente
        /// </summary>
        [JsonProperty("gender")]
        public string Gender 
        { 
            get 
            {
                return this.gender; 
            } 
            set 
            {
                this.gender = value;
                onPropertyChanged("Gender");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("document_type")]
        public string DocumentType 
        { 
            get 
            {
                return this.documentType; 
            } 
            set 
            {
                this.documentType = value;
                onPropertyChanged("DocumentType");
            }
        }
    }
} 
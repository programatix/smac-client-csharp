/*
 * SMAC API
 *
 * SMAC ASP.NET Core Web API
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Custom SMAC metadata
    /// </summary>
    [DataContract(Name = "CustomSmacMetadata")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(BioHashSmacMetadata), "BioHashSmacMetadata")]
    [JsonSubtypes.KnownSubType(typeof(CustomSmacMetadata), "CustomSmacMetadata")]
    [JsonSubtypes.KnownSubType(typeof(PhotometrixSmacMetadata), "PhotometrixSmacMetadata")]
    public partial class CustomSmacMetadata : SmacMetadata, IEquatable<CustomSmacMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSmacMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomSmacMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSmacMetadata" /> class.
        /// </summary>
        /// <param name="key">The key name of the custom data.</param>
        /// <param name="data">Custom data to embed into SMAC QR Code.</param>
        /// <param name="type">Defines the type of the metadata (required) (default to &quot;CustomSmacMetadata&quot;).</param>
        public CustomSmacMetadata(string key = default(string), Object data = default(Object), string type = "CustomSmacMetadata") : base()
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for CustomSmacMetadata and cannot be null");
            }
            this.Type = type;
            this.Key = key;
            this.Data = data;
        }

        /// <summary>
        /// The key name of the custom data
        /// </summary>
        /// <value>The key name of the custom data</value>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Custom data to embed into SMAC QR Code
        /// </summary>
        /// <value>Custom data to embed into SMAC QR Code</value>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public Object Data { get; set; }

        /// <summary>
        /// Defines the type of the metadata
        /// </summary>
        /// <value>Defines the type of the metadata</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomSmacMetadata {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomSmacMetadata);
        }

        /// <summary>
        /// Returns true if CustomSmacMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomSmacMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomSmacMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && base.Equals(input) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            yield break;
        }
    }

}

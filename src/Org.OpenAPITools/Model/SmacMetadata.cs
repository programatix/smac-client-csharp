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
    /// SmacMetadata
    /// </summary>
    [DataContract(Name = "SmacMetadata")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(BioHashSmacMetadata), "BioHashSmacMetadata")]
    [JsonSubtypes.KnownSubType(typeof(CustomSmacMetadata), "CustomSmacMetadata")]
    [JsonSubtypes.KnownSubType(typeof(PhotometrixSmacMetadata), "PhotometrixSmacMetadata")]
    public partial class SmacMetadata : IEquatable<SmacMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmacMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmacMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmacMetadata" /> class.
        /// </summary>
        /// <param name="type">Defines the type of the metadata    The value can be:  - Custom  - BioHash  - Photometrix (required).</param>
        public SmacMetadata(string type = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for SmacMetadata and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Defines the type of the metadata    The value can be:  - Custom  - BioHash  - Photometrix
        /// </summary>
        /// <value>Defines the type of the metadata    The value can be:  - Custom  - BioHash  - Photometrix</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SmacMetadata {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as SmacMetadata);
        }

        /// <summary>
        /// Returns true if SmacMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of SmacMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmacMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                int hashCode = 41;
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
            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            yield break;
        }
    }

}

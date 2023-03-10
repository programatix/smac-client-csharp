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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ExtractResponse
    /// </summary>
    [DataContract(Name = "ExtractResponse")]
    public partial class ExtractResponse : IEquatable<ExtractResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractResponse" /> class.
        /// </summary>
        /// <param name="templateBase64Url">A Base64Url representation of the biometric template (Use Microsoft.IdentityModel.Tokens.Base64UrlEncoder to decode.).</param>
        public ExtractResponse(string templateBase64Url = default(string))
        {
            this.TemplateBase64Url = templateBase64Url;
        }

        /// <summary>
        /// A Base64Url representation of the biometric template (Use Microsoft.IdentityModel.Tokens.Base64UrlEncoder to decode.)
        /// </summary>
        /// <value>A Base64Url representation of the biometric template (Use Microsoft.IdentityModel.Tokens.Base64UrlEncoder to decode.)</value>
        [DataMember(Name = "templateBase64Url", EmitDefaultValue = true)]
        public string TemplateBase64Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExtractResponse {\n");
            sb.Append("  TemplateBase64Url: ").Append(TemplateBase64Url).Append("\n");
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
            return this.Equals(input as ExtractResponse);
        }

        /// <summary>
        /// Returns true if ExtractResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtractResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtractResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TemplateBase64Url == input.TemplateBase64Url ||
                    (this.TemplateBase64Url != null &&
                    this.TemplateBase64Url.Equals(input.TemplateBase64Url))
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
                if (this.TemplateBase64Url != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateBase64Url.GetHashCode();
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
            yield break;
        }
    }

}

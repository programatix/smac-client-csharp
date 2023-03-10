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
    /// VerifyResponse
    /// </summary>
    [DataContract(Name = "VerifyResponse")]
    public partial class VerifyResponse : IEquatable<VerifyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyResponse" /> class.
        /// </summary>
        /// <param name="result">The verification result.</param>
        /// <param name="score">The verification score.</param>
        /// <param name="referenceImage">An image encoded as a &lt;a href&#x3D;\&quot;https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Data_URIs\&quot;&gt;Data URL&lt;/a&gt;.</param>
        public VerifyResponse(bool result = default(bool), double score = default(double), string referenceImage = default(string))
        {
            this.Result = result;
            this.Score = score;
            this.ReferenceImage = referenceImage;
        }

        /// <summary>
        /// The verification result
        /// </summary>
        /// <value>The verification result</value>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public bool Result { get; set; }

        /// <summary>
        /// The verification score
        /// </summary>
        /// <value>The verification score</value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public double Score { get; set; }

        /// <summary>
        /// An image encoded as a &lt;a href&#x3D;\&quot;https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Data_URIs\&quot;&gt;Data URL&lt;/a&gt;
        /// </summary>
        /// <value>An image encoded as a &lt;a href&#x3D;\&quot;https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Data_URIs\&quot;&gt;Data URL&lt;/a&gt;</value>
        [DataMember(Name = "referenceImage", EmitDefaultValue = true)]
        public string ReferenceImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerifyResponse {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  ReferenceImage: ").Append(ReferenceImage).Append("\n");
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
            return this.Equals(input as VerifyResponse);
        }

        /// <summary>
        /// Returns true if VerifyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
                ) && 
                (
                    this.ReferenceImage == input.ReferenceImage ||
                    (this.ReferenceImage != null &&
                    this.ReferenceImage.Equals(input.ReferenceImage))
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
                hashCode = (hashCode * 59) + this.Result.GetHashCode();
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
                if (this.ReferenceImage != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceImage.GetHashCode();
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

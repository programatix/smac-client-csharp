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
    /// ScanContentRequest
    /// </summary>
    [DataContract(Name = "ScanContentRequest")]
    public partial class ScanContentRequest : IEquatable<ScanContentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanContentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScanContentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanContentRequest" /> class.
        /// </summary>
        /// <param name="datasetId">The dataset identifier to retrieve (The dataset identifier is returned by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt;) (required).</param>
        /// <param name="token">The token to access the dataset (The token returned by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt;) (required).</param>
        public ScanContentRequest(Guid datasetId = default(Guid), Guid token = default(Guid))
        {
            this.DatasetId = datasetId;
            this.Token = token;
        }

        /// <summary>
        /// The dataset identifier to retrieve (The dataset identifier is returned by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt;)
        /// </summary>
        /// <value>The dataset identifier to retrieve (The dataset identifier is returned by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt;)</value>
        [DataMember(Name = "datasetId", IsRequired = true, EmitDefaultValue = true)]
        public Guid DatasetId { get; set; }

        /// <summary>
        /// The token to access the dataset (The token returned by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt;)
        /// </summary>
        /// <value>The token to access the dataset (The token returned by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt;)</value>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = true)]
        public Guid Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScanContentRequest {\n");
            sb.Append("  DatasetId: ").Append(DatasetId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as ScanContentRequest);
        }

        /// <summary>
        /// Returns true if ScanContentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ScanContentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScanContentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DatasetId == input.DatasetId ||
                    (this.DatasetId != null &&
                    this.DatasetId.Equals(input.DatasetId))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.DatasetId != null)
                {
                    hashCode = (hashCode * 59) + this.DatasetId.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
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

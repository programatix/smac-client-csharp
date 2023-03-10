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
    /// UploadPhotoResponse
    /// </summary>
    [DataContract(Name = "UploadPhotoResponse")]
    public partial class UploadPhotoResponse : IEquatable<UploadPhotoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadPhotoResponse" /> class.
        /// </summary>
        /// <param name="photoDataURL">An image encoded as a &lt;a href&#x3D;\&quot;https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Data_URIs\&quot;&gt;Data URL&lt;/a&gt;.</param>
        public UploadPhotoResponse(string photoDataURL = default(string))
        {
            this.PhotoDataURL = photoDataURL;
        }

        /// <summary>
        /// An image encoded as a &lt;a href&#x3D;\&quot;https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Data_URIs\&quot;&gt;Data URL&lt;/a&gt;
        /// </summary>
        /// <value>An image encoded as a &lt;a href&#x3D;\&quot;https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/Data_URIs\&quot;&gt;Data URL&lt;/a&gt;</value>
        [DataMember(Name = "photoDataURL", EmitDefaultValue = true)]
        public string PhotoDataURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UploadPhotoResponse {\n");
            sb.Append("  PhotoDataURL: ").Append(PhotoDataURL).Append("\n");
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
            return this.Equals(input as UploadPhotoResponse);
        }

        /// <summary>
        /// Returns true if UploadPhotoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadPhotoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadPhotoResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PhotoDataURL == input.PhotoDataURL ||
                    (this.PhotoDataURL != null &&
                    this.PhotoDataURL.Equals(input.PhotoDataURL))
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
                if (this.PhotoDataURL != null)
                {
                    hashCode = (hashCode * 59) + this.PhotoDataURL.GetHashCode();
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

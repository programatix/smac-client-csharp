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
    /// CropRequest
    /// </summary>
    [DataContract(Name = "CropRequest")]
    public partial class CropRequest : IEquatable<CropRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CropRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CropRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CropRequest" /> class.
        /// </summary>
        /// <param name="imageDataUrl">A DataUrl representation of the image file (Use Microsoft.IdentityModel.Tokens.Base64UrlEncoder to encode.) (required).</param>
        /// <param name="maxWidth">maxWidth.</param>
        /// <param name="maxHeight">maxHeight.</param>
        /// <param name="aspectRatio">aspectRatio.</param>
        public CropRequest(string imageDataUrl = default(string), int? maxWidth = default(int?), int? maxHeight = default(int?), double? aspectRatio = default(double?))
        {
            // to ensure "imageDataUrl" is required (not null)
            if (imageDataUrl == null)
            {
                throw new ArgumentNullException("imageDataUrl is a required property for CropRequest and cannot be null");
            }
            this.ImageDataUrl = imageDataUrl;
            this.MaxWidth = maxWidth;
            this.MaxHeight = maxHeight;
            this.AspectRatio = aspectRatio;
        }

        /// <summary>
        /// A DataUrl representation of the image file (Use Microsoft.IdentityModel.Tokens.Base64UrlEncoder to encode.)
        /// </summary>
        /// <value>A DataUrl representation of the image file (Use Microsoft.IdentityModel.Tokens.Base64UrlEncoder to encode.)</value>
        [DataMember(Name = "imageDataUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageDataUrl { get; set; }

        /// <summary>
        /// Gets or Sets MaxWidth
        /// </summary>
        [DataMember(Name = "maxWidth", EmitDefaultValue = true)]
        public int? MaxWidth { get; set; }

        /// <summary>
        /// Gets or Sets MaxHeight
        /// </summary>
        [DataMember(Name = "maxHeight", EmitDefaultValue = true)]
        public int? MaxHeight { get; set; }

        /// <summary>
        /// Gets or Sets AspectRatio
        /// </summary>
        [DataMember(Name = "aspectRatio", EmitDefaultValue = true)]
        public double? AspectRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CropRequest {\n");
            sb.Append("  ImageDataUrl: ").Append(ImageDataUrl).Append("\n");
            sb.Append("  MaxWidth: ").Append(MaxWidth).Append("\n");
            sb.Append("  MaxHeight: ").Append(MaxHeight).Append("\n");
            sb.Append("  AspectRatio: ").Append(AspectRatio).Append("\n");
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
            return this.Equals(input as CropRequest);
        }

        /// <summary>
        /// Returns true if CropRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CropRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CropRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImageDataUrl == input.ImageDataUrl ||
                    (this.ImageDataUrl != null &&
                    this.ImageDataUrl.Equals(input.ImageDataUrl))
                ) && 
                (
                    this.MaxWidth == input.MaxWidth ||
                    (this.MaxWidth != null &&
                    this.MaxWidth.Equals(input.MaxWidth))
                ) && 
                (
                    this.MaxHeight == input.MaxHeight ||
                    (this.MaxHeight != null &&
                    this.MaxHeight.Equals(input.MaxHeight))
                ) && 
                (
                    this.AspectRatio == input.AspectRatio ||
                    (this.AspectRatio != null &&
                    this.AspectRatio.Equals(input.AspectRatio))
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
                if (this.ImageDataUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageDataUrl.GetHashCode();
                }
                if (this.MaxWidth != null)
                {
                    hashCode = (hashCode * 59) + this.MaxWidth.GetHashCode();
                }
                if (this.MaxHeight != null)
                {
                    hashCode = (hashCode * 59) + this.MaxHeight.GetHashCode();
                }
                if (this.AspectRatio != null)
                {
                    hashCode = (hashCode * 59) + this.AspectRatio.GetHashCode();
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
            // ImageDataUrl (string) minLength
            if (this.ImageDataUrl != null && this.ImageDataUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageDataUrl, length must be greater than 1.", new [] { "ImageDataUrl" });
            }

            yield break;
        }
    }

}

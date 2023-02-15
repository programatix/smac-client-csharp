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
    /// AssociatedUser
    /// </summary>
    [DataContract(Name = "AssociatedUser")]
    public partial class AssociatedUser : IEquatable<AssociatedUser>, IValidatableObject
    {
        /// <summary>
        /// A list of associated user types
        /// </summary>
        /// <value>A list of associated user types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Holder for value: Holder
            /// </summary>
            [EnumMember(Value = "Holder")]
            Holder = 1,

            /// <summary>
            /// Enum Coholder for value: Coholder
            /// </summary>
            [EnumMember(Value = "Coholder")]
            Coholder = 2

        }


        /// <summary>
        /// A list of associated user types
        /// </summary>
        /// <value>A list of associated user types</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssociatedUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedUser" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="type">A list of associated user types (required).</param>
        public AssociatedUser(string email = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for AssociatedUser and cannot be null");
            }
            this.Email = email;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssociatedUser {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as AssociatedUser);
        }

        /// <summary>
        /// Returns true if AssociatedUser instances are equal
        /// </summary>
        /// <param name="input">Instance of AssociatedUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssociatedUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // Email (string) minLength
            if (this.Email != null && this.Email.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be greater than 1.", new [] { "Email" });
            }

            yield break;
        }
    }

}
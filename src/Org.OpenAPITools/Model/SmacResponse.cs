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
    /// SmacResponse
    /// </summary>
    [DataContract(Name = "SmacResponse")]
    public partial class SmacResponse : IEquatable<SmacResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmacResponse" /> class.
        /// </summary>
        /// <param name="id">The SMAC identifier.</param>
        /// <param name="name">The SMAC name.</param>
        /// <param name="description">The SMAC description.</param>
        /// <param name="datasets">The attached dataset identifiers.</param>
        /// <param name="datasetsCount">The number of attached datasets.</param>
        /// <param name="scansCount">The number of scans performed on the SMAC.</param>
        /// <param name="associatedUsers">The list of associated users.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="updatedDate">updatedDate.</param>
        public SmacResponse(Guid id = default(Guid), string name = default(string), string description = default(string), List<Guid> datasets = default(List<Guid>), int datasetsCount = default(int), int scansCount = default(int), List<AssociatedUser> associatedUsers = default(List<AssociatedUser>), DateTime createdDate = default(DateTime), DateTime updatedDate = default(DateTime))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Datasets = datasets;
            this.DatasetsCount = datasetsCount;
            this.ScansCount = scansCount;
            this.AssociatedUsers = associatedUsers;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
        }

        /// <summary>
        /// The SMAC identifier
        /// </summary>
        /// <value>The SMAC identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The SMAC name
        /// </summary>
        /// <value>The SMAC name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The SMAC description
        /// </summary>
        /// <value>The SMAC description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The attached dataset identifiers
        /// </summary>
        /// <value>The attached dataset identifiers</value>
        [DataMember(Name = "datasets", EmitDefaultValue = true)]
        public List<Guid> Datasets { get; set; }

        /// <summary>
        /// The number of attached datasets
        /// </summary>
        /// <value>The number of attached datasets</value>
        [DataMember(Name = "datasetsCount", EmitDefaultValue = false)]
        public int DatasetsCount { get; set; }

        /// <summary>
        /// The number of scans performed on the SMAC
        /// </summary>
        /// <value>The number of scans performed on the SMAC</value>
        [DataMember(Name = "scansCount", EmitDefaultValue = false)]
        public int ScansCount { get; set; }

        /// <summary>
        /// The list of associated users
        /// </summary>
        /// <value>The list of associated users</value>
        [DataMember(Name = "associatedUsers", EmitDefaultValue = true)]
        public List<AssociatedUser> AssociatedUsers { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedDate
        /// </summary>
        [DataMember(Name = "updatedDate", EmitDefaultValue = false)]
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SmacResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Datasets: ").Append(Datasets).Append("\n");
            sb.Append("  DatasetsCount: ").Append(DatasetsCount).Append("\n");
            sb.Append("  ScansCount: ").Append(ScansCount).Append("\n");
            sb.Append("  AssociatedUsers: ").Append(AssociatedUsers).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return this.Equals(input as SmacResponse);
        }

        /// <summary>
        /// Returns true if SmacResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SmacResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmacResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Datasets == input.Datasets ||
                    this.Datasets != null &&
                    input.Datasets != null &&
                    this.Datasets.SequenceEqual(input.Datasets)
                ) && 
                (
                    this.DatasetsCount == input.DatasetsCount ||
                    this.DatasetsCount.Equals(input.DatasetsCount)
                ) && 
                (
                    this.ScansCount == input.ScansCount ||
                    this.ScansCount.Equals(input.ScansCount)
                ) && 
                (
                    this.AssociatedUsers == input.AssociatedUsers ||
                    this.AssociatedUsers != null &&
                    input.AssociatedUsers != null &&
                    this.AssociatedUsers.SequenceEqual(input.AssociatedUsers)
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Datasets != null)
                {
                    hashCode = (hashCode * 59) + this.Datasets.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DatasetsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.ScansCount.GetHashCode();
                if (this.AssociatedUsers != null)
                {
                    hashCode = (hashCode * 59) + this.AssociatedUsers.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.UpdatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedDate.GetHashCode();
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
